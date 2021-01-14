---
title: crmscript_invitations
description: Meeting invitations
author:
so.date:
keywords:
so.topic:
---

# Meeting invitations

Meetings have multiple **participants**: you **invite** several associates or resources to join.

While appointments with the owner plus 1 resource technically are bookings, we here define a *meeting* as:

* 2 or more persons
* optionally a resource

## The host

### Create invitation

> [!TIP]
> It is good practice to always find out when people will be available, before inviting them to a meeting by linking them to follow-ups.

```crmscript
NSAppointmentAgent appointmentAgent;

// Schedule
DateTime start;
start.moveToHourStart();
start.addHour(1);
DateTime end = start;
end.addHour(1);

NSAppointmentEntity a = appointmentAgent.CreateDefaultAppointmentEntityByTypeAndAssociate(7, 1);
a.SetStartDate(start);
a.SetEndDate(end);
a.SetDescription("Sprint retrospective");

// Build list of available participants
NSParticipantInfo[] participants;
NSAssociateAgent associateAgent;

Integer[] teamMembers;
teamMembers.pushBack(8);
teamMembers.pushBack(27);

for(Integer i = 0; i < teamMembers.length(); i++) {

  NSAppointment[] appointmentList = appointmentAgent.GetAssociateDiary(teamMembers[i], start, end, -1);
  
  if (appointmentList.length() == 0) {
  
    NSParticipantInfo p;
    p.SetAssociateId(teamMembers[i] );
    participants.pushBack(p);
  }
  else {
    printLine(associateAgent.GetAssociate(teamMembers[i]).GetFullName() + " is unavailable at the given time.");
  }
}

// Add a room
NSParticipantInfo room;
room.SetAssociateId(37);
participants.pushBack(room);

// Finalize booking
a.SetParticipants(participants);
a = appointmentAgent.SaveAppointmentEntity(a);
```

### Track responses

Before you can track responses, you need to fetch the main appointment and all its descendants. You can then explore the invitation status of each appointment.

In this example, we check and print the response for each attendee using a String array. You can look up status codes in the reference section at the end of this page and on the [appointments page][1].

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

## The attendee

### Show follow-ups you are invited to

`GetMyAppointments()` will retrieve appointments for the currently signed-in user. To retrieve by associate ID, use `GetPersonDiary()` instead.

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

### Accept invitation

Calling `Accept()` is all it takes to turn an invite into an appointment in your diary. In real life, checking for conflicts 1st is recommended.

The 1st argument is the appointment ID. The 2nd is used with recurring meetings, and we'll leave it at 0 for now.

```crmscript
NSAppointmentAgent appointmentAgent;
appointmentAgent.Accept(242,0);
```

### Make changes

Attendees may change only the priority, alarm, and completed fields. The rest is the responsibility of the meeting organizer. Updates are covered for [appointments][1] in general.

## Reference

### Relevant statuses

| Status | Description                                            |
|:------:|--------------------------------------------------------|
| 5      | Invitation (initial status for a booking)              |
| 6      | Meeting has been moved, request new response           |
| 7      | User has seen, but not declined or accepted the invite |
| 8      | Meeting has been moved. User has seen, but not responded to the invite |
| 9      | User has declined the meeting                          |
| 10     | Meeting is canceled                                    |

<!-- Referenced links -->
[1]: appointment.md
