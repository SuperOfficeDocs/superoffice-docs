---
uid: crmscript-get-appointment
title: Get appointments
description: How to get appointments with CRMScript
keywords: CRMScript, calendar, diary, appointment, follow-up, NSAppointment
author: Bergfrid Skaara Dias
date: 03.18.2022
version: 10
topic: howto
---

# Get appointments

> [!TIP]
> You can only retrieve appointments for persons that are SuperOffice users ([associates][1]).
>
> The signed-in user must also have permission to view those appointments. Otherwise, an exception is thrown.

## NSAppointment[] GetAppointmentList(Integer[] ids)

Fetches a collection of appointments corresponding to a list of IDs.

```crmscript!
Integer[] appointmentIDs;
appointmentIDs.pushFront(84);
appointmentIDs.pushFront(86);
appointmentIDs.pushFront(88);
NSAppointmentAgent appointmentAgent;
NSAppointment[] appointmentList = appointmentAgent.GetAppointmentList(appointmentIDs);

for(Integer i = 0; i < appointmentList.length(); i++) {
  print("ID: " + appointmentList[i].GetAppointmentId().toString());
  printLine("\t At: " + appointmentList[i].GetStartDate().toString() + " to " + appointmentList[i].GetEndDate().toString());
}
```

> [!TIP]
> You can also use the [archive agent][2] to fetch appointments.

<!-- markdownlint-disable-next-line MD013 -->
## NSAppointment[] GetPersonDiary(Integer personId, DateTime startTime, DateTime endTime, Integer count)

Fetches a limited number of appointments within a time range for the given person. `GetPersonDiary()` will ignore appointments not shown in the user's diary.

```crmscript!
NSAppointmentAgent appointmentAgent;
DateTime start;
DateTime end;

NSAppointment[] appointmentList = appointmentAgent.GetPersonDiary(5, start.addMonth(-6), end, 10);

for(Integer i = 0; i < appointmentList.length(); i++) {
  print("ID: " + appointmentList[i].GetAppointmentId().toString());
  printLine("\t At: " + appointmentList[i].GetStartDate().toString() + " to " + appointmentList[i].GetEndDate().toString());
}
```

> [!TIP]
> Set `count` to -1 to not restrict the collection of appointments retrieved.

<!-- markdownlint-disable-next-line MD013 -->
## NSAppointment[] GetPersonAppointments(Integer personId, Bool includeProjectAppointments, DateTime startTime, DateTime endTime, Integer count)

Same as `GetPersonDiary()`, but will also include all appointments in projects that the user is a member of if set to **true**.

```crmscript!
NSAppointmentAgent appointmentAgent;
DateTime start;
DateTime end;

NSAppointment[] appointmentList = appointmentAgent.GetPersonAppointments(5, true, start.addMonth(-6), end, 5);

for(Integer i = 0; i < appointmentList.length(); i++) {
  printLine("ID: " + appointmentList[i].GetAppointmentId().toString());
}
```

<!-- Referenced links -->
[1]: ../../../../contact/reference/index.md#associate
[2]: ../../netserver/crmscript-archiveagent.md
