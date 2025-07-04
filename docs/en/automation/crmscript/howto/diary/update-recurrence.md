---
uid: crmscript-update-recurrence
title: Edit repeating follow-ups
description: How to update a repeating follow-up with CRMScript
keywords: CRMScript, calendar, diary, appointments, follow-up, recurrence
author: Bergfrid Skaara Dias
date: 03.21.2022
version: 10
content_type: howto
redirect_from: /en/diary/howto/crmscript/update-recurrence
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
[1]: ../../../../diary/learn/recurrence/index.md
