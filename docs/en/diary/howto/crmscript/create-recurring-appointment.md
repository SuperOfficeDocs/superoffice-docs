---
uid: crmscript-crate-recurrence
title: Create repeating follow-ups
description: How to create repeating follow-ups with CRMScript
author: Bergfrid Skaara Dias
so.date: 03.21.2022
keywords: CRMScript, calendar, diary, appointments, follow-up, recurrence
so.topic: howto
---

# Create repeating follow-ups

1. Create the appointment, call, meeting, or task as usual.
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

## NSRecurrenceInfo CreateDefaultRecurrence()

```crmscript!
NSAppointmentAgent appointmentAgent;
NSRecurrenceInfo r = appointmentAgent.CreateDefaultRecurrence();

printLine("Start: " + r.GetStartDate().toString());
printLine("Pattern: " + r.GetPattern().toString());
```

> [!TIP]
> Alternatively use `CreateDefaultRecurrenceByDate()` to the date that the recurring pattern should start.

## Repeat at standard interval

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

## Repeat at user-defined interval

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

## Repeat at selected dates

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

## Repeat until

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

## Related topics

* [About recurring appointments and patterns][4]
* [NSAppointmentAgent][1]
* [NSAppointmentEntity][2]
* [NSRecurrenceInfo][3]

### NSRecurrenceInfo

| Field             | Type             | Description                         |
|:------------------|:-----------------|:------------------------------------|
| IsRecurrence      | Bool             | whether it is a repeating follow-up |
| RecurrenceId      | Integer          | unique ID of the rule               |
| RecurrenceEndType | Integer          | 0 = unknown<br>1 = end by date<br>2 = end after n repetitions |
| RecurrenceCounter | Integer          | the number of repetitions<br>used only when the end is calculated from a count |
| StartDate         | DateTime         | when repetition starts              |
| EndDate           | DateTime         | when repetition ends<br>used only when the end is calculated from a date |
| Dates             | NSRecurrenceDate[] | List of all dates the follow-up occurs<br>wraps a DateTime |
| Pattern           | Integer          | the main pattern of recurrence      |

<!-- Referenced links -->
[1]: <xref:CRMScript.NetServer.NSAppointmentAgent>
[2]: <xref:CRMScript.NetServer.NSAppointmentEntity>
[3]: <xref:CRMScript.NetServer.NSRecurrenceInfo>
[4]: ../index.md#recurrence
