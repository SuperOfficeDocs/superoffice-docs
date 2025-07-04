---
uid: diary-reference
title: Working with diaries
description: How to work with follow-ups (appointments) at multiple levels of NetServer.
keywords: diary, calendar, appointment, meeting, API, associate, call, task, todo, follow-up, recurrence, recurrencerule, frequency, pattern
author: Bergfrid Skaara Dias
date: 10.25.2024
version: 10
topic: reference
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/diary/howto/index
---

# Working with follow-ups (appointments) in API

**Follow-ups** are the foundation of the SuperOffice diary. These entities are always tied to an [associate][37] and have some form of time reference.

Follow-ups are part of a broader group of entities labeled **activities**:

* [follow-ups][38]
  * Meeting (appointment)
  * To-do (task)
  * Call (follow-up)
* documents
  * [document][36]
  * [email][35]
* mailings and form submissions
* [chat sessions][1]

When working with follow-ups, data will often intersect with the following entities:

* [company][31] (contact table)
* [contact][32] (person table)
* [project][34]
* [sale][33]

## Owner

Associate acts as the owner of the follow-up. If you don't assign an associate to the `Associate` property of the appointment, the current user will become the owner of the appointment and only one row will be added to the [appointment table][40] when the appointment is saved.

## Create appointments

You can create an appointment at multiple levels of NetServer, for example [web services][14] and in [CRMScript][5]. For other options, see the linked "working with" sections at the bottom of this page.

## Invitations

When two appointments have a shared text record and different status values it can be called an **invitation**.

### Examples

* [Create invitation - CRMScript][8]
* [Create invitation - web services][15]
* [Get invitations - web services][16]
* [Accept invitation - CRMScript][7]
* [Accept invitation - web services][17]

## Recurrence

A repeating follow-up is a series events scheduled to occur at regular intervals. For example, a weekly status meeting. A recurring appointment is stored in two parts:

* A recurrence rule, which defines the pattern of the recurrence
* All the appointments created by the recurrence are created in the appointment table, and each one points to the recurrence rule that defines it.

* [Create recurring appointment - CRMScript][6]
* [Create recurring appointment - web services][18]

**See also:**

* [recurrencerule table][41]
* [RecurrencePattern enum][45]

### Example (SQL)

The system generates appointment records for all the recurrence instances:

```SQL
SELECT appointment_id, associate_id, activeDate, type, status, recurrenceRuleId 
FROM appointment WHERE recurrenceRuleId = 1
```

| appointment_id | associate_id | activeDate | type | status | recurrenceRuleId |
|---|---|---|---|---|---|
| 264 | 15 | 2021-11-04 11:30:00 | 1 | 1 | 1 |
| 267 | 15 | 2021-11-09 11:30:00 | 1 | 1 | 1 |
| 268 | 15 | 2021-11-11 11:30:00 | 1 | 1 | 1 |
| 269 | 15 | 2021-11-16 11:30:00 | 1 | 1 | 1 |
| 270 | 15 | 2021-11-18 11:30:00 | 1 | 1 | 1 |
| 271 | 15 | 2021-11-23 11:30:00 | 1 | 1 | 1 |

Let's look at the rule:

```SQL
SELECT * FROM recurrencerule WHERE recurrencerule_id = 1
```

| RecurrenceRule_id | pattern | subPattern | startDate | endDate | cyclicDay | cyclicWeek | cyclicMonth|
|---|---|---|---|---|---|---|---|
| 1 | 2 | 0 | 2021-11-04 11:30:00 | 2022-01-27 12:00:00 | 0 | 1 | 0 |

This recurrence rule has:

* pattern = 2 (weekly) (corresponds to the radio-button choice in the dialog).
* subPattern = 0 (none)
* cyclicWeek = 1  = "every 1 week(s)"

## Reference

### Frequently used database fields

| Field | Description |
|:--|:--|
| appointment_id | ID |
| associate_id | owner |
| contact_id | company |
| person_id | attendee if a meeting |
| task_idx | FK Task list |
| type | EnumAppointmentType |
| status | EnumAppointmentStatus |
| mother_id | For group reservations and invites |
| location | Custom string or info from a booked resource |
| alldayEvent | 0 = no; 1 = yes |
| freeBusy | 0 = busy; 1 =  free |

For a complete list of fields, see the [database reference][40].

### Appointment types

| Type | Description |
|:-:|:--|
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
|:--|:--|
| registered | UtcDateTime of registration |
| updated | UtcDateTime of last update |
| done | When a task was completed (DateTime) |
| do_by | Planned deadline for task (DateTime) |
| activeDate | Display date (DateTime) |
| endDate | Planned completion time (DateTime) |

### Relevant invitation statuses

| Status | Description |
|:-:|---|
| 5  | Invitation (initial status for a booking) |
| 6  | Meeting has been moved, request new response |
| 7  | User has seen, but not declined or accepted the invite |
| 8  | Meeting has been moved. User has seen, but not responded to the invite |
| 9  | User has declined the meeting |
| 10 | Meeting is canceled |

### Frequency

| Value | Description | Comment | Example |
|:--|:--|:--|:--|
| daily | every working day<br>every day of the week | or custom | every other day |
| weekly | every week on given day | must set weekday | every 3 weeks on Tuesday |
| monthly | every month on given day | must set day of month  | on the 5th of the month, every 4th month |
| yearly | every year on given date | must set day and month | every 23rd of September |

A **cycle** is the number of days between each recurrence.

The enum values correspond to what you see in the **Pattern** dialog.

### Enum RecurrencePattern

| Value | Description |
|:-:|:--|
| 0 | unknown |
| 1 | daily |
| 2 | weekly |
| 3 | monthly |
| 4 | yearly |
| 5 | custom |

### Enum RecurrenceSubPattern

| Value | Name | Type | Description |
|:-:|:--|---|---|
| 0 | Unknown | | |
| 1 | EveryWorkday| daily | Mon-Fri |
| 2 | EveryWeekday | daily | Mon-Sun |
| 3 | EveryCyclicDay | daily | cyclic interval of days |
| 4 | DayOfMonth | weekly | repeat on day n of the month<br>ex: the 17th day of every 2 months |
| 5 | WeekdayOfMonth | weekly | repeat on given weekday <br>ex: the 3rd Thursday of every 3 months |
| 6 | DayOfMonth | yearly | repeat on given date every year |
| 7 | WeekdayOfMonth | yearly | repeat on given weekdays of month<br>ex: the 3rd Thursday of every August |

> [!CAUTION]
> The **sub-pattern should match the pattern**. There is little error-checking if you mix the wrong set. You can set pattern = yearly and sub-pattern = dailyEveryDay and something strange will probably happen.

#### Weekdays

| Value | Weekday |
|:-:|:--|
| 0 | Unknown |
| 1 | Monday |
| 2 | Tuesday |
| 4 | Wednesday |
| 8 | Thursday |
| 16 | Friday |
| 32 | Saturday |
| 64 | Sunday |

> [!TIP]
> Enumeration flag values can be combined.

#### Week of month

| Value | Description |
|:-:|:--|
| 0 | Unknown |
| 1 | The 1st week of the month |
| 2 | The 2nd week of the month |
| 3 | The 3rd week of the month |
| 4 | The 4th week of the month |
| 5 | The last week of the month |

## How-tos by API

* [Working with appointments in CRMScript][2]
* [Working with appointments in web NetServer services and REST][19]
* [Working with appointments at the data layer (entities)][10]
* [Working with appointments using rows][11]
* [Working with appointments in Objectified SQL][12]
* [Raw SQL queries][13]

<!-- Referenced links -->
[1]: ../../automation/chatbot/index.md
[2]: ../../automation/crmscript/howto/diary/index.md
[5]: ../../automation/crmscript/howto/diary/create-appointment.md
[6]: ../../automation/crmscript/howto/diary/create-recurring-appointment.md
[8]: ../../automation/crmscript/howto/diary/create-invitation.md
[7]: ../../automation/crmscript/howto/diary/accept-invitation.md

[10]: ../../api/entities/howto/diary/index.md
[11]: ../../api/rows/howto/diary/index.md
[12]: ../../api/osql/howto/diary/index.md
[13]: ../../api/sql/howto/diary/index.md

[14]: ../../api/web-services/howto/diary/create-apt-services.md
[15]: ../../api/web-services/howto/diary/create-invitation-services.md
[16]: ../../api/web-services/howto/diary/get-invitations-services.md
[17]: ../../api/web-services/howto/diary/accept-invitation-services.md
[18]: ../../api/web-services/howto/diary/create-recurring-appointment-services.md
[19]: ../../api/web-services/howto/diary/index.md

[31]: ../../company/index.yml
[32]: ../../contact/index.yml
[33]: ../../sale/index.yml
[34]: ../../project/index.yml
[35]: ../../email/index.yml
[36]: ../../document/index.yml
[37]: ../../contact/reference/index.md#associate
[38]: ../learn/follow-ups.md

[40]: ../../database/tables/appointment.md
[41]: ../../database/tables/recurrencerule.md
[45]: ../../database/tables/enums/recurrencepattern.md

<!-- Referenced images -->
