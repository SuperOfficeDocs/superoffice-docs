---
uid: crmscript-stop-recurrence
title: Stop repeating follow-ups
description: How to stop a repeating follow-up with CRMScript
keywords: CRMScript, calendar, diary, appointments, follow-up, recurrence
author: Bergfrid Skaara Dias
date: 03.21.2022
version: 10
content_type: howto
redirect_from: /en/diary/howto/crmscript/stop-recurrence
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
[1]: ../../../../diary/learn/recurrence/index.md
