---
title: How to create an invitation (data layer)
uid: create_invitation_entity
description: How to create an invitation using entities
author: {github-id}
so.date: 05.11.2016
keywords: diary
so.topic: howto
# so.envir:
# so.client:
---

# How to create an invitation (data layer)

After creating an appointment you may need to invite members. The following example demonstrates how this is done.

[!code-csharp[CS](includes/create-invite-entity.cs)]

In this example, we have initially created an appointment and set certain properties of it.

## Participants

A `Person` entity is used for adding as a participant to this appointment.

In the latter part of the example, we have set some properties of the participant such as `AssociateId`, `PersonId`, and `SendEmail`. You can create an array of `ParticipantInfo` as we have done above.

## AppointmentMatrix

An instance of the `AppointmentMatrix` is created by passing the newly created appointment. You can add the participants to the matrix by using the `AddParticipant` method.

When the `AppointmentMatrix` is saved, 2 records will be added to the `appointment` table:

* One corresponding to the creator of the appointment
* One referring to the participant

If we have added more participants, more records will be entered into the `appointment` table.
