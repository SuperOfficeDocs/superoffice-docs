---
uid: crmscript_recurrence
title: Recurrence
author:
so.date:
keywords:
so.topic:
---

# Recurrence

A repeating follow-up is a series of appointments, tasks, or calls scheduled to occur at regular intervals. For example, a weekly status meeting.

## Frequency

| Value   | Description                                | Comment                | Example                        |
|:--------|:-------------------------------------------|:-----------------------|:-------------------------------|
| daily   | every working day<br>every day of the week | or custom              | every other day                |
| weekly  | every week on given day                    | must set weekday       | every 3 weeks on Tuesday       |
| monthly | every month on given day                   | must set day of month  | on the 5th of the month, every 4th month |
| yearly  | every year on given date                   | must set day and month | every 23rd of September        |

A **cycle** is the number of days between each recurrence.

## View recurrence info of a follow-up

### Basic info (NSAppointment)

```crmscript!
Integer aId = 234;
NSAppointmentAgent appointmentAgent;
NSAppointment a = appointmentAgent.GetAppointment(aId);

if (a.GetIsRecurrence()){
  Integer pattern = a.GetRecurringPattern();
  DateTime start = a.GetRecurringStartDate();
  printLine("Follow-up " + aId.toString() + " is recurring. Pattern: " +pattern.toString() + "\tStart: " + start.toString());
}
```

### Complex info (NSAppointmentEntity, NSRecurrenceInfo)

```crmscript!
Integer aId = 234;
Integer pattern = 0;
Integer subPattern = 0;
Integer endType = 0;
Integer count = 0;

DateTime start;
DateTime end;

NSAppointmentAgent appointmentAgent;
NSAppointmentEntity a = appointmentAgent.GetAppointmentEntity(aId);

NSRecurrenceInfo recurrenceInfo = a.GetRecurrence();

if (recurrenceInfo.GetIsRecurrence()) {
  start = recurrenceInfo.GetStartDate();
  pattern = recurrenceInfo.GetPattern();
  endType = recurrenceInfo.GetRecurrenceEndType();

  if (pattern == 1) {
    subPattern = recurrenceInfo.GetDayPattern().GetPattern();
  }
  else if (pattern == 2) {
    subPattern = recurrenceInfo.GetWeekPattern().GetCycle();
  }
  else if (pattern == 3) {
    subPattern = recurrenceInfo.GetMonthPattern().GetPattern();
  }
  else if (pattern == 4) {
    subPattern = recurrenceInfo.GetYearPattern().GetPattern();
  }

  if (endType == 1) {
    end = recurrenceInfo.GetEndDate();
  }
  else if (endType == 2) {
    count = recurrenceInfo.GetRecurrenceCounter();
  }

  printLine("Follow-up " + aId.toString() + " is recurring.\nPattern: " + pattern.toString() + "\tSub-pattern: " + subPattern.toString());
  printLine("Start: " + start.toString() + "\nEnd: " + end.toString());
}
```

## Get follow-ups belonging to a series

### NSAppointment[] GetAppointmentRecords(Integer motherId, Integer recurrenceRuleId)

```crmscript!
Integer recurrenceId = 1;
NSAppointmentAgent appointmentAgent;
NSAppointment[] appointmentList = appointmentAgent.GetAppointmentRecords(0,recurrenceId);

for(Integer i = 0; i < appointmentList.length(); i++) {
  printLine("ID: " + appointmentList[i].GetAppointmentId().toString() + "\t At: " + appointmentList[i].GetStartDate().toString());
}
```

> [!TIP]
> Set `motherId` to **0** unless you're working with [meeting invitations][1].

## Create repeating follow-ups

1. Create the [appointment][2], [call][3], [meeting][1], or [task][4] as usual.
2. Set recurrence info.
3. Save the follow-up.

```crmscript
NSAppointmentAgent appointmentAgent;
NSAppointmentEntity newAppointment = appointmentAgent.CreateDefaultAppointmentEntityByTypeAndAssociate(7, 1);

newAppointment.SetDescription("Morning coffee");

NSRecurrenceInfo r = appointmentAgent.CreateDefaultRecurrence();
newAppointment.SetRecurrence(r);

newAppointment = appointmentAgent.SaveAppointmentEntity(newAppointment);
```

### NSRecurrenceInfo CreateDefaultRecurrence()

```crmscript!
NSAppointmentAgent appointmentAgent;
NSRecurrenceInfo r = appointmentAgent.CreateDefaultRecurrence();

printLine("Start: " + r.GetStartDate().toString());
printLine("Pattern: " + r.GetPattern().toString());
```

> [!TIP]
> Alternatively use `CreateDefaultRecurrenceByDate()` to the date that the recurring pattern should start.

### Repeat at standard interval

To repeat at a standard interval (daily, weekly, monthly, yearly), call `SetPattern()` with value \[1-4\]. See the reference section for details.

This example creates a 10-minute daily coffee break at 14:00 starting August 1st.

```crmscript
DateTime start = String("2020-08-01 14:00").toDateTime();
DateTime end = start;
end.addMin(10);
DateTime stop = start;
stop.moveToYearEnd();

NSAppointmentAgent appointmentAgent;
NSAppointmentEntity newAppointment = appointmentAgent.CreateDefaultAppointmentEntityByTypeAndAssociate(7, 1);

newAppointment.SetStartDate(start);
newAppointment.SetEndDate(end);
newAppointment.SetDescription("coffee break");

NSRecurrenceInfo r = appointmentAgent.CreateDefaultRecurrence();
r.SetPattern(1);
r.SetIsRecurrence(true);
r.SetRecurrenceEndType(1);
r.SetStartDate(start);
r.SetEndDate(stop);

NSRecurrenceDayPattern p;
p.SetPattern(1);
r.SetDayPattern(p);

newAppointment.SetRecurrence(r);
newAppointment = appointmentAgent.SaveAppointmentEntity(newAppointment);
```

### Repeat at user-defined interval

Example: hourly reminders throughout the working day

```crmscript
NSRecurrenceInfo r;
r.SetPattern(5);

DateTime now;
NSRecurrenceDate[] dates;
for (Integer i =  0; i < 8; +++) {
  NSRecurrenceDate d;
  d.SetDate(now);
  d.SetDescription("Stretch and have some water");
  dates.pushBack(d);
  d.addHour(1);
}

r.SetDates(dates);
```

### Repeat at selected dates

You can also manually create a list of selected dates that don't follow a pattern.

```crmscript
NSRecurrenceInfo r;
r.SetPattern(5);

DateTime[] selectedDates;
selectedDates.pushBack(String("2020-08-17").toDateTime());
selectedDates.pushBack(String("2020-09-21").toDateTime());
selectedDates.pushBack(String("2020-11-16").toDateTime());
selectedDates.pushBack(String("2021-01-04").toDateTime());

NSRecurrenceDate[] dates;
for (Integer i =  0; i < selectedDates.length(); +++) {
  NSRecurrenceDate d;
  d.SetDate(selectedDates[i]);
  d.SetDescription("Planning - daycare closed");
  dates.pushBack(d);
}

r.SetDates(dates);
```

### Repeat until

You can choose to stop after a specific number of times or after a specific date.

**Repeat 10 times:**

```crmscript
NSRecurrenceInfo r;
r.SetRecurrenceEndType(2);
r.SetRecurrenceCounter(10);
```

**Repeat until end of next month:**

```crmscript
DateTime d;
d.moveToMonthEnd();
d.addMonth(1);
NSRecurrenceInfo r;
r.SetRecurrenceEndType(1);
r.SetEndDate(d);
```

## Edit repeating follow-ups

### Change 1 repetition

Change only this instance, the change will not affect other times.

Postponing the current follow-up by 2 hours:

```crmscript
Integer aId = 234;

NSAppointmentAgent appointmentAgent;
NSAppointmentEntity a = appointmentAgent.GetAppointmentEntity(aId);

NSRecurrenceInfo r = a.GetRecurrence();

if (r.GetIsRecurrence()) {
  r.SetStartDate(r.GetStartDate().addHour(2));
  newAppointment.SetRecurrence(r);
  newAppointment = appointmentAgent.SaveAppointmentEntity(newAppointment);
}
```

### Change all future repetitions

Change all future instances including this one - the change will apply to this follow-up in the future as well.

```crmscript
Integer aId = 234;
DateTime now;

NSAppointmentAgent appointmentAgent;
NSAppointmentEntity a = appointmentAgent.GetAppointmentEntity(aId);

NSRecurrenceInfo r = a.GetRecurrence();

if (r.GetIsRecurrence()) {
  NSAppointment[] appointmentList = appointmentAgent.GetAppointmentRecords(0,r.GetRecurrenceId());

  for(Integer i = 0; i < appointmentList.length(); i++) {
    if (appointmentList[i].GetStartDate().diff(now) > 0) {
      NSAppointmentEntity futureAppointment = appointmentAgent.GetAppointmentEntity(appointmentList[i].GetAppointmentId());
      // set changes here
      futureAppointment = appointmentAgent.SaveAppointmentEntity(futureAppointment);
    }
  }
}
```

## Stop repeating follow-ups

When you stop a recurrence, all repetitions of the follow-up **after the occurrence you edit** are deleted.

If you cancel the recurrence of the 1st in a series, the pattern is deleted and the follow-up becomes a single appointment/call/task.

```crmscript
Integer aId = 234;
DateTime now;

NSAppointmentAgent appointmentAgent;
NSAppointmentEntity a = appointmentAgent.GetAppointmentEntity(aId);

NSRecurrenceInfo r = a.GetRecurrence();
if (r.GetIsRecurrence()) {
  r.SetIsRecurrence(false);
  r.SetPattern(0);
  a.SetRecurrence(r);
  a = appointmentAgent.SaveAppointmentEntity(a);
}
```

## Reference

### NSRecurrenceInfo

| Field             | Type             | Description                         |
|:------------------|:-----------------|:------------------------------------|
| IsRecurrence      | Bool             | whether it is a repeating follow-up |
| RecurrenceId      | Integer          | unique ID of the rule               |
| RecurrenceEndType | Integer          | 0 = unknown<br>1 = end by date<br>2 = end after n repetitions                 |
| RecurrenceCounter | Integer          | the number of repetitions<br>used only when the end is calculated from a count |
| StartDate         | DateTime         | when repetition starts              |
| EndDate           | DateTime         | when repetition ends<br>used only when the end is calculated from a date       |
| Dates             | RecurrenceDate[] | List of all dates the follow-up occurs<br>wraps a DateTime                     |
| Pattern           | Integer          | the main pattern of recurrence      |

### Main patterns

| Value | Description |
|:-----:|:------------|
| 0     | unknown     |
| 1     | daily       |
| 2     | weekly      |
| 3     | monthly     |
| 4     | yearly      |
| 5     | custom      |

### Sub-patterns

| Value | Name           | Type   | Description                     |
|:-----:|:---------------|--------|---------------------------------|
| 0     | Unknown        |        |                                 |
| 1     | EveryWorkday   | daily  | Mon-Fri                         |
| 2     | EveryWeekday   | daily  | Mon-Sun                         |
| 3     | EveryCyclicDay | daily  | cyclic interval of days         |
| 4     | DayOfMonth     | weekly | repeat on day n of the month<br>ex: the 17th day of every 2 months        |
| 5     | WeekdayOfMonth | weekly | repeat on given weekday     <br>ex: the 3rd Thursday of every 3 months    |
| 6     | DayOfMonth     | yearly | repeat on given date every year |
| 7     | WeekdayOfMonth | yearly | repeat on given weekdays of month<br>ex: the 3rd Thursday of every August |

### Weekdays

| Value | Weekday   |
|:-----:|:----------|
| 0     | Unknown   |
| 1     | Monday    |
| 2     | Tuesday   |
| 4     | Wednesday |
| 8     | Thursday  |
| 16    | Friday    |
| 32    | Saturday  |
| 64    | Sunday    |

> [!TIP]
> Enumeration flag values can be combined.

### Week of month

| Value | Description                |
|:-----:|:---------------------------|
| 0     | Unknown                    |
| 1     | The 1st week of the month  |
| 2     | The 2nd week of the month  |
| 3     | The 3rd week of the month  |
| 4     | The 4th week of the month  |
| 5     | The last week of the month |

<!-- Referenced links -->
[1]: invitations.md
[2]: appointment.md
[3]: call.md
[4]: task.md
