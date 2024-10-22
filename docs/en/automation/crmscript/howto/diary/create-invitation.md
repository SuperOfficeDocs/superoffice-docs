---
uid: crmscript-create-invitation
title: Create invitation
description: How to create meeting invitations with CRMScript
keywords: CRMScript, calendar, diary, appointments, follow-up, invitation
author: Bergfrid Skaara Dias
date: 03.21.2022
version: 10
topic: howto
---

# Create invitation

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

// Build list of available attendees
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

## Read more

* [Invitations][1]

<!-- Referenced links -->
[1]: ../../../../diary/learn/invitation/index.md
