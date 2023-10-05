---
title: Diary howto
uid: diary-howto
description: How to work with appointments at multiple levels of NetServer.
author: Bergfrid Skaara Dias
so.date: 10.05.2023
keywords: diary, calendar, appointment, API, associate, call, task, todo, follow-up
so.topic: howto
---

# How to

## Introduction

Appointments are the foundation of the SuperOffice diary. **Follow-up** is a collective term for **appointments**, **phone calls**, and **tasks**. These entities are always tied to an [associate][39] and have some form of time reference.

Associate acts as the owner of the appointment. If you don't assign an associate to the `Associate` property of the appointment, the current user will become the owner of the appointment and only one row will be added to the appointment table when the appointment is saved.

Follow-ups are part of a broader group of entities labeled **activities**:

* [follow-ups][38]
  * appointment
  * task
  * call
* documents
  * [document][36]
  * [email][35]
* mailings and form submissions
* [chat sessions][37]

When working with follow-ups, data will often intersect with the following entities:

* [company][31] (contact table)
* [contact][32] (person table)
* [project][34]
* [sale][33]

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

## Reference

### Frequently used database fields

| Field | Description |
|:---|:---|
| appointment_id | ID |
| associate_id   | owner |
| contact_id     | company |
| person_id      | participant if a meeting |
| task_idx       | FK Task list |
| type           | EnumAppointmentType |
| status         | EnumAppointmentStatus |
| mother_id      | For group reservations and invites |
| location       | Custom string or info from a booked resource |
| alldayEvent    | 0 = no; 1 = yes  |
| freeBusy       | 0 = busy; 1 =  free |

For a complete list of fields, see the [database reference][30].

### Appointment types

| Type | Description |
|:----:|:--|
| 0 | Undefined/initializing |
| 1 | In calendar, if overdue or done today, also in todo list |
| 2 | In todo list (no start time) |
| 6 | Meeting invite (changes to 1 when accepted) |
| 7 | Pending assignment (changes to 2 when accepted) |

### Appointment status

| Status | Description |
|:-:|:--|
| 0 | Unknown/ a post-it |
| 1 | Not started |
| 2 | Started |
| 3 | Completed |
| 4 | Hidden |
| 5-10 | Booking |
| 11-13 | Assignment |

### Timestamp values

| Field | Description |
|:---|:---|
| registered | UtcDateTime of registration          |
| updated    | UtcDateTime of last update           |
| done       | When a task was completed (DateTime) |
| do_by      | Planned deadline for task (DateTime) |
| activeDate | Display date (DateTime)              |
| endDate    | Planned completion time (DateTime)   |

### Relevant invitation statuses

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
[30]: ../../database/tables/appointment.md
[31]: ../../company/index.yml
[32]: ../../contact/index.yml
[33]: ../../sale/index.yml
[34]: ../../project/index.yml
[35]: ../../email/index.yml
[36]: ../../document/index.yml
[37]: ../../automation/chatbot/index.md
[38]: ../learn/follow-ups.md
[39]: ../../contact/associate.md

<!-- Referenced images -->
