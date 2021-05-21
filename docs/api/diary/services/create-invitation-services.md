---
title: How to create an invitation (services)
uid: create_invitation_ws
description: How to create an invitation using services
author: {github-id}
so.date: 06.24.2016
keywords: diary
so.topic: howto
# so.envir:
# so.client:
---

# How to create an invitation (services)

After creating an appointment you may need to invite members. The following example demonstrates how this is done.

## Example 1

[!code-csharp[CS](includes/create-invite-services-1.cs)]

Here we have first created an `AppointmentAgent`. The `Appointment` entity has its properties set to default values. For example, the `Associate` is automatically set to the current user (SAL0).

> [!NOTE]
> Associate is a property of *Entity* data type which is a SuperOffice-specific type.

However, in the above example, we have assigned an Associate explicitly, will be assigned the appointment and it will be shown in the invitation dialog where the associate may accept or decline it.

When we save this appointment using the `SaveAppointmentEntity` method exposed in the `AppoinmentAgent`, 2 rows will be added to the appointment table.

The first row is an `Appointment` in the appointment owner’s own diary. The second row is an invitation to SAL0 from the owner to attend the same meeting. When the currently logged-in user (SAL0) logs in, they will be shown a new invitation corresponding to this appointment.

## Example 2

[!code-csharp[CS](includes/create-invite-services-2.cs)]

Here there is no reference to an invitation, when we invite a person to the appointment we have created, the invitation will be created for that person.

First, we have created an appointment agent and after setting the start date, end date, and description we have created a `ParticipantInfo` array. In the array, we have given the `AssociateId` of a user and a resource, and a `PersonId` of someone who is not a user – a person we want to invite to the newly created appointment.

The above `Save` will create 3 appointments, one for each participant. The service will not create an appointment for the current user unless you add a participant object to the list. If you want to include the current user as a participant, you must remember to add a participant object with the current user as a participating associate.

The first participant doesn't get an invitation since the first participant is considered the inviter. The appointment just appears in the first participant’s diary.

> [!NOTE]
> The `AssociateId`, `PersonId`, and the `ContactId` that you specify in the participant info object **must be consistent**. If you specify more than one field for a participant, they must agree with the information in the database. Specifying multiple values on a single participant object will not create multiple invitations. Each participant object is a single invitation.
