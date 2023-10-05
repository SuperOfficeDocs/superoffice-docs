---
title: Diary howto
uid: diary-howto
description: How to work with appointments at multiple levels of NetServer.
author: Bergfrid Skaara Dias
so.date: 10.05.2023
keywords: diary, calendar, appointment, API
so.topic: howto
---

# How to

## Create appointments

You can create an appointment at multiple levels of NetServer:

* [Create an appointment with CRMScript][15]
* [Create an appointment using services][14]
* [Create an Appointment entity][1]
* [Create an Appointment entity through an entity][2]
* [Create an Appointment entity through an entity collection][3]
* [Create an Appointment row][4]
* [Create an Appointment through row collection (Rows)][5]
* [Create an Appointment through OSQL][6]
* [Create an Appointment through raw SQL][7]

## Invitations

When two appointments have a shared text record and different status values it can be called an **invitation**.

### Create

* [Create invitation - CRMScript][28]
* [Create invitation - web services][25]
* [Create invitation - entity][23]
* [Create invitation - raw SQL][21]

### Get

* [Get invitations - web services][26]

### Accept

* [Accept invitation - CRMScript][29]
* [Accept invitation - web services][27]
* [Accept invitation - entity][24]
* [Accept invitation - raw SQL][22]

## How-tos by API

* [CRMScript][8]
* [Web services][9]
* [Entity layer][10]
* [Rows][11]
* [OSQL][12]
* [Raw SQL][13]

## Relevant statuses

| Status | Description |
|:-:|----|
| 5  | Invitation (initial status for a booking) |
| 6  | Meeting has been moved, request new response |
| 7  | User has seen, but not declined or accepted the invite |
| 8  | Meeting has been moved. User has seen, but not responded to the invite |
| 9  | User has declined the meeting |
| 10 | Meeting is canceled |

<!-- Referenced links -->
[1]: entity/create-apt-entity.md
[2]: entity/create-apt-entity-in-entity.md
[3]: entity/create-apt-entity-in-collection.md
[4]: row/create-apt-row.md
[5]: row/create-apt-rows.md
[6]: osql/create-apt-osql.md
[7]: sql/create-apt-sql.md
[8]: crmscript/index.md
[9]: services/index.md
[10]: entity/index.md
[11]: row/index.md
[12]: osql/index.md
[13]: sql/index.md
[14]: services/create-apt-services.md
[15]: crmscript/create-appointment.md
[21]: sql/create-invitation-sql.md
[22]: sql/accept-invitation-sql.md
[23]: entity/create-invitation-entity.md
[24]: entity/accept-invitation-entity.md
[25]: services/create-invitation-services.md
[26]: services/get-invitations-services.md
[27]: services/accept-invitation-services.md
[28]: crmscript/create-invitation.md
[29]: crmscript/accept-invitation.md

<!-- Referenced images -->
