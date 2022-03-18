---
title: How to accept an invitation (services)
uid: accept_invitation_services
description: How to accept an invitation using NetServer services
author: Bergfrid Skaara Dias
so.date: 03.18.2022
keywords: diary, calendar, appointment, invitation, API, web services
so.topic: howto
# so.envir:
# so.client:
---

# How to accept an invitation (services)

This example shows how to accept an [invitation][2] through the [NetServer services][3] layer with just a few code statements.

We use NetServer providers (plugins created with a Factory class) to retrieve information on invitations for a specific associate.

`IArchiveProvider` is the external standard interface of archive providers exposed to the service layer and the world in general. The interface aggregates the extensible and provider properties of classes such as `ActivityArchiveProvider`, `ProjectMemberProvide`, and `InvitationProvider`. This acts as an intermediate stage between the pure property interface and the actual provider class that has queries.

After getting an overview by [listing invitations for an associate][1], we plan to accept the invitation with `appointmentId = 150`. This is done using the [AppointmentAgent][4] from the `SuperOffice.CRM.Services` namespace. All calls to the agent correspond to a web service services call.

## Code

[!code-csharp[CS](includes/accept-invite-services.cs)]

## Walk-through

In the example, we have created an instance of the `AppointmentAgent` and called its `Accept` method passing the `appointmentId` and the `UpdateMode`.

**Output:**

```text
associate/contactFullName    date        endDate           appointmentId
StateZeroDatabase       [D:07/05/2007]    [D:07/05/2007]    [I:186]
StateZeroDatabase       [D:07/26/2007]    [D:07/26/2007]    [I:179]
StateZeroDatabase       [D:04/28/2007]    [D:04/28/2007]    [I:172]
StateZeroDatabase       [D:06/14/2007]    [D:06/14/2007]    [I:161
```

The reason that the details of an invitation with `appointmentId` 150 is not shown (like it did when we [listed it][1]), is that once the invitation has been accepted it becomes a normal appointment without the invitation status set and it can no longer be retrieved by using the [InvitationProvider][5].

<!-- Referenced links -->
[1]: get-invitations-services.md
[2]: ../../invitations.md
[3]: ../../../api/web-services/index.md
[4]: ../../../api/reference/restful/agent/Appointment_Agent/index.md
[5]: ../../../api/archive-providers/reference/invitation.md
