---
uid: accept-invitation-services
title: How to accept an invitation (services)
description: How to accept an invitation using NetServer services
keywords: diary, calendar, appointment, invitation, API, web services
author: Bergfrid Skaara Dias
date: 03.18.2022
content_type: howto
redirect_from:
  - /en/diary/howto/services/accept-invitation-services
  - /en/api/netserver/web-services/howto/diary/accept-invitation-services
---

# How to accept an invitation (services)

This example shows how to accept an [invitation][2] through the [NetServer services][3] layer with just a few code statements.

We use NetServer providers (plugins created with a Factory class) to retrieve information on invitations for a specific associate.

`IArchiveProvider` is the external standard interface of archive providers exposed to the service layer and the world in general. The interface aggregates the extensible and provider properties of classes such as `ActivityArchiveProvider`, `ProjectMemberProvide`, and `InvitationProvider`. This acts as an intermediate stage between the pure property interface and the actual provider class that has queries.

After getting an overview by [listing invitations for an associate][1], we plan to accept the invitation with `appointmentId = 150`. This is done using the [AppointmentAgent][4] from the `SuperOffice.CRM.Services` namespace. All calls to the agent correspond to a web service services call.

## Code

```csharp
using SuperOffice;
using SuperOffice.CRM.ArchiveLists;
using SuperOffice.CRM.Services;

using(SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Creating an instance of the Appointment Agent
  using(AppointmentAgent newAppAgt = new AppointmentAgent())
  {
    //Accepting the invitation
    AppointmentEntity newAppEnt = newAppAgt.Accept(150,SuperOffice.Data.RecurrenceUpdateMode.OnlyThis);
  }
}
```

## Walk-through

In the example, we have created an instance of the `AppointmentAgent` and called its `Accept` method passing the `appointmentId` and the `UpdateMode`.

**Output:**

```text
associate/contactFullName    date        endDate           appointmentId
StateZeroDatabase       [D:07/05/2007]    [D:07/05/2007]    [I:186]
StateZeroDatabase       [D:07/26/2007]    [D:07/26/2007]    [I:179]
StateZeroDatabase       [D:04/28/2007]    [D:04/28/2007]    [I:172]
StateZeroDatabase       [D:06/14/2007]    [D:06/14/2007]    [I:161]
```

The reason that the details of an invitation with `appointmentId` 150 is not shown (like it did when we [listed it][1]), is that once the invitation has been accepted it becomes a normal appointment without the invitation status set and it can no longer be retrieved by using the [InvitationProvider][5].

<!-- Referenced links -->
[1]: get-invitations-services.md
[2]: ../../../../diary/learn/invitation/index.md
[3]: ../../index.md
[4]: ../../../reference/restful/agent/Appointment_Agent/index.md
[5]: ../../../archive-providers/reference/invitation.md
