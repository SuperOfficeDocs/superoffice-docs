---
uid: crmscript-accept-invitation
title: Create invitation
description: How to accept meeting invitations with CRMScript
author: Bergfrid Skaara Dias
so.date: 03.21.2022
keywords: CRMScript, calendar, diary, appointments, follow-up, invitation
so.topic: howto
---

# How to accept an invitation

## Show follow-ups you are invited to

[GetMyAppointments()][2] will retrieve appointments for the currently signed-in user. To retrieve by associate ID, use [GetPersonDiary()][3] instead.

```crmscript!
DateTime start;
DateTime end = start;
end.moveToQuarterEnd();

NSAppointmentAgent appointmentAgent;
NSAppointment[] appointmentList = appointmentAgent.GetMyAppointments(start, end, -1);

for (Integer i = 0; i < appointmentList.length(); i++) {
  NSAppointment a = appointmentList[i];
  Integer s = a.GetInvitationStatus();
  if (s >= 5 && s <= 10) {
    printLine(a.GetAppointmentId().toString() + "\t at " + a.GetStartDate().toString() + " - " + a.GetEndDate().toString());
  }
}
```

## Accept()

Calling `Accept()` is all it takes to turn [an invite][4] into an appointment in your diary. In real life, checking for conflicts 1st is recommended.

The 1st argument is the appointment ID. The 2nd is used with recurring meetings, and we'll leave it at 0 for now.

```crmscript
NSAppointmentAgent appointmentAgent;
appointmentAgent.Accept(242,0);
```

## Make changes

Attendees may change only the priority, alarm, and completed fields. The rest is the responsibility of the meeting organizer. Updates are covered for [appointments][1] in general.

<!-- Referenced links -->
[1]: update-appointment.md
[2]: <xref:CRMScript.NetServer.NSAppointmentAgent.GetMyAppointments(Integer)>
[3]: <xref:CRMScript.NetServer.NSAppointmentAgent.GetPersonDiary(Integer,Integer)>
[4]: ../../learn/invitation/index.md
