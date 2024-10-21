---
uid: crmscript-get-recurrence-info
title: View recurrence info
description: How to get recurrence info with CRMScript
keywords: CRMScript, calendar, diary, appointments, follow-up, recurrence
author: Bergfrid Skaara Dias
date: 03.21.2022
version: 10
topic: howto
---

# View recurrence info of a follow-up

Depending on the level details you need, you can use either the [NSAppointment][1] or the [NSAppointmentEntity][2] class.

## Basic info (NSAppointment)

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

## Complex info (NSAppointmentEntity, NSRecurrenceInfo)

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

<!-- Referenced links -->
[1]: <xref:CRMScript.NetServer.NSAppointment>
[2]: <xref:CRMScript.NetServer.NSAppointmentEntity>
