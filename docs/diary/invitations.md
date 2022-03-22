---
uid: invitations-intro
title: Invitations
description: Calling meetings or other arrangements with multiple participants.
author: Bergfrid Skaara Dias
so.date: 03.18.2022
keywords: diary, calendar, appointment, invitation, meeting, associate, participant
so.topic: concept
---

# Invitations

When two appointments have a shared text record and different status values it can be called an **invitation**.

Invitations are **created** when calling meetings or other arrangements between different members of a company. Meetings have multiple **participants**: you invite several associates or resources to join.

While appointments with the owner plus one resource technically are bookings, we here define a **meeting** as:

* 2 or more persons
* optionally a resource

When we save the appointment, an invitation will also be added to the person we invited and will be shown in the diary of the person on the appropriate date and time. **This only happens if the invited person also is an associate.** You may invite persons belonging to other contacts as well, these will not have a diary where the appointment is shown, but it will be shown in the activity archive of their contact instead.

> [!NOTE]
> Resources and non-user persons don't receive invitations – the appointment is just created as a normal appointment for these participants.

When an invitation is **accepted** it will be displayed on the user’s diary.

## Relevant statuses

| Status | Description |
|:-:|----|
| 5  | Invitation (initial status for a booking) |
| 6  | Meeting has been moved, request new response |
| 7  | User has seen, but not declined or accepted the invite |
| 8  | Meeting has been moved. User has seen, but not responded to the invite |
| 9  | User has declined the meeting |
| 10 | Meeting is canceled |

## Available how-tos

### Create

* [Create invitation - CRMScript][8]
* [Create invitation - web services][5]
* [Create invitation - entity][3]
* [Create invitation - raw SQL][1]

### Get

* [Get invitations - web services][6]

### Accept

* [Accept invitation - CRMScript][9]
* [Accept invitation - web services][7]
* [Accept invitation - entity][4]
* [Accept invitation - raw SQL][2]

<!-- Referenced links -->
[1]: howto/sql/create-invitation-sql.md
[2]: howto/sql/accept-invitation-sql.md
[3]: howto/entity/create-invitation-entity.md
[4]: howto/entity/accept-invitation-entity.md
[5]: howto/services/create-invitation-services.md
[6]: howto/services/get-invitations-services.md
[7]: howto/services/accept-invitation-services.md
[8]: howto/crmscript/create-invitation.md
[9]: howto/crmscript/accept-invitation.md
