---
uid: crmscript-stop-recurrence
title: Stop repeating follow-ups
description: How to stop a repeating follow-up with CRMScript
author: Bergfrid Skaara Dias
so.date: 03.21.2022
keywords: CRMScript, calendar, diary, appointments, follow-up, recurrence
so.topic: howto
---


# Stop repeating follow-ups

When you stop a [recurrence][1], all repetitions of the follow-up **after the occurrence you edit** are deleted.

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

<!-- Referenced links -->
[1]: ../../learn/recurrence/index.md
