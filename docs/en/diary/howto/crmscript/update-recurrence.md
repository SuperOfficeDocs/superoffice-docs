---
uid: crmscript-update-recurrence
title: Edit repeating follow-ups
description: How to update a repeating follow-up with CRMScript
author: Bergfrid Skaara Dias
so.date: 03.21.2022
keywords: CRMScript, calendar, diary, appointments, follow-up, recurrence
so.topic: howto
---

# Edit repeating follow-ups

You can change either one or all future repetitions of a [recurring follow-up][1].

## Change one repetition

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

## Change all future repetitions

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

<!-- Referenced links -->
[1]: ../../learn/recurrence/index.md
