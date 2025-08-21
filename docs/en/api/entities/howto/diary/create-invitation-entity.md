---
uid: create-invitation-entity
title: How to create an invitation (data layer)
description: How to create an invitation using entities at the NetServer data layer.
keywords: diary, calendar, appointment, API, entity, ParticipantInfo, AddParticipant, AppointmentMatrix
author: Bergfrid Skaara Dias
date: 03.04.2022
content_type: howto
redirect_from:
  - /en/diary/howto/entity/create-invitation-entity
  - /en/api/netserver/entities/howto/diary/create-invitation-entity
---

# How to create an invitation (data layer)

After creating an appointment you may need to [invite members][2]. The following example demonstrates how this is done.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice.Data;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Create a New Appointment
  Appointment appointmentOne = Appointment.CreateNew();
  appointmentOne.SetDefaults();
  appointmentOne.AlldayEvent = 1;
  appointmentOne.DoBy = DateTime.Now.AddHours(8);
  appointmentOne.Task = TaskRow.GetFromIdxTaskId(14);
  appointmentOne.AppointmentText = TextRow.CreateNew();
  appointmentOne.AppointmentText.Text = "This is a Project Meeting";

  //Retrieve a person to invite
  Person invitee = Person.GetFromIdxPersonId(5);

  //Add attendee to the Appointment
  SuperOffice.CRM.Services.ParticipantInfo[] participants = new SuperOffice.CRM.Services.ParticipantInfo[1];
  participants[0] = new SuperOffice.CRM.Services.ParticipantInfo();

  //Set the properties of the attendee
  participants[0].AssociateId = invitee.AssociateId;
  participants[0].PersonId = invitee.PersonId;
  participants[0].SendEmail = false;
  RecurrenceUpdateMode recurrenceMode = RecurrenceUpdateMode.OnlyThis;

  //Add the appointment to the appointmentMatrix
  AppointmentMatrix appType = new AppointmentMatrix(appointmentOne, recurrenceMode);
  appType.AddParticipant(participants);

  //Save the appointment
  appType.Save();
}
```

In this example, we have initially created an appointment and set certain properties of it.

## Attendees

A `Person` entity is used for adding as a attendee to this appointment.

In the latter part of the example, we have set some properties of the attendee such as `AssociateId`, `PersonId`, and `SendEmail`. You can create an array of [ParticipantInfo][4] as we have done above.

## AppointmentMatrix

An instance of the `AppointmentMatrix` is created by passing the newly created appointment. You can add the attendees to the matrix by using the `AddParticipant` method.

When the `AppointmentMatrix` is saved, 2 records will be added to the [appointment table][1]:

* One corresponding to the creator of the appointment
* One referring to the attendee

If we have added more attendees, more records will be entered into the `appointment` table.

## See also

* [Appointment table][1]
* [Invitations][2]

<!-- Referenced links -->
[1]: ../../../../database/tables/appointment.md
[2]: ../../../../diary/learn/invitation/index.md
[4]: <xref:SuperOffice.CRM.Services.ParticipantInfo>

<!-- Referenced images -->
