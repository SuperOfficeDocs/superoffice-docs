---
uid: create-invitation-entity
title: How to create an invitation (data layer)
description: How to create an invitation using entities at the NetServer data layer.
keywords: diary, calendar, appointment, API, entity, ParticipantInfo, AddParticipant, AppointmentMatrix
author: Bergfrid Skaara Dias
date: 03.04.2022
content_type: howto
---

# How to create an invitation (data layer)

After creating an appointment you may need to [invite members][2]. The following example demonstrates how this is done.

[!code-csharp[CS](includes/create-invite-entity.cs)]

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
