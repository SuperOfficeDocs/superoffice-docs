---
# Mandatory fields.
title: accept_invitation_services       # (Required) Very important for SEO.
description: How to accept an invitation using NetServer services # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords: diary
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to accept an invitation (services)

This example shows how to accept an invitation through the NetServer services layer with just a few code statements.

We use NetServer providers (plugins created with a Factory class) to retrieve information on invitations for a specific associate.

`IArchiveProvider` is the external standard interface of archive providers exposed to the service layer and the world in general. The interface aggregates the extensible and provider properties of classes such as `ActivityArchiveProvider`, `ProjectMemberProvide`, and `InvitationProvider`. This acts as an intermediate stage between the pure property interface and the actual provider class that has queries.

After getting an overview by [listing invitations for an associate][1], we plan to accept the invitation with `appointmentId = 150`. This is done using the `AppointmentAgent` from the `SuperOffice.CRM.Services` namespace. All call to the agent corresponds to a web service services call.

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

The reason that the details of an invitation with `appointmentId` 150 is not shown (like it did when we [listed it][1]), is that once the invitation has been accepted it becomes a normal appointment without the invitation status set and it can no longer be retrieved by using the `InvitationProvider`.

<!-- Referenced links -->
[1]: get-invitations-services.md
