---
uid: crmscript-track-invitation-response
title: Track responses
description: How to track responses to an invitation with CRMScript
author: Bergfrid Skaara Dias
so.date: 03.21.2022
keywords: CRMScript, calendar, diary, appointments, follow-up, invitation
so.topic: howto
---

# Track responses

Before you can track responses, you need to fetch the main appointment and all its descendants. You can then explore the **invitation status** of each appointment.

In this example, we check and print the response for each attendee using a `String` array. You can look up status codes on the [invitations page][1].

```crmscript!
String[15] state;
state[1] = "accepted";
state[5] = "not seen";
state[7] = "seen, but not declined or accepted";
state[9] = "declined";

Integer aId = 242;
NSAppointmentAgent appointmentAgent;

NSAppointmentEntity appointment = appointmentAgent.GetAppointmentEntity(aId);
NSAppointment[] invites = appointmentAgent.GetAppointmentRecords(aId, 0);

Integer rejects = appointment.GetRejectCounter();

if (rejects == 0) {
  printLine("There are currently no rejects.\n");
}
else {
  printLine("There are " + rejects.toString() + " rejects.\n");
}

for (Integer i = 0; i < invites.length(); i++) {
  NSAppointment a = invites[i];

  if (a.GetAppointmentId() == aId) {
    continue;
  }

  Integer s = a.GetInvitationStatus();
  if (s == 1 || s == 5 || s == 7 || s == 9) {
    printLine(a.GetAssociateFullName() + " with ID=" + a.GetAssociateId().toString() + " has " + state[s] + " the invitation.");
    if (s == 9) {
      printLine("Reason: " + a.GetRejectReason());
    }
  }
}
```

<!-- Referenced links -->
[1]: ../../learn/invitation/index.md
