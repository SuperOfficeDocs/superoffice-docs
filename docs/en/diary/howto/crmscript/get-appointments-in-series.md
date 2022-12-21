---
uid: crmscript-get-apt-in-series
title: Get follow-ups in series
description: How to get follow-ups belonging to a series with CRMScript
author: Bergfrid Skaara Dias
so.date: 03.21.2022
keywords: CRMScript, calendar, diary, appointments, follow-up, recurrence
so.topic: howto
---

# Get follow-ups belonging to a series

## NSAppointment[] GetAppointmentRecords(Integer motherId, Integer recurrenceRuleId)

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

<!-- Referenced links -->
[1]: book-resource.md
