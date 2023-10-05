---
title: Diary
uid: diary-overview
description: Introduction to the diary and working with appointments.
author: Bergfrid Skaara Dias
so.date: 03.22.2022
keywords: diary, calendar, appointment, associate, call, task, todo, follow-up
so.topic: concept
---

# Diary

Appointments are the foundation of the SuperOffice diary.

![Diary screen -screenshot][img1]

The diary consists of a calendar and a todo list and is used similar to a Filofax with separate pages for every day, week, and month.

* **calendar**: shows entries allocated to a particular time or date
* **todo list**: shows stuff that you have not yet completed, mostly calls and tasks without time or date

In the UI, both are closely linked to the **Diary** screen.

## Three types of follow-ups

In SuperOffice CRM, **follow-up** is a collective term for **appointments**, **phone calls**, and **tasks** . These entities are always tied to an [associate][9] and have some form of time reference.

| type | start time | end time | duration | deadline | displayed | description | example |
|---|:-:|:-:|:-:|:-:|---|---|---|
| appointment | x | x | calculated | | calendar | activity w/ defined start and end time | meetings |
| task/todo | | | | x | todo list | follow-up w/ no start time | reminder for stuff due by a specific time |
| call | x | | x | | todo list | phone call | |

> [!NOTE]
> Overdue appointments will by default also appear in the todo list!
>
> Logged phone calls will also appear in the calendar.

### Timestamp values

| Field | Description |
|:---|:---|
| registered | UtcDateTime of registration          |
| updated    | UtcDateTime of last update           |
| done       | When a task was completed (DateTime) |
| do_by      | Planned deadline for task (DateTime) |
| activeDate | Display date (DateTime)              |
| endDate    | Planned completion time (DateTime)   |

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

For a complete list of fields, see the [database reference][4].

## Appointments

An **appointment** is a type of **follow-up** with a defined start and end time, such as a meeting. It will be shown in the calendar of the owner's diary.

[Associate][9] acts as the owner of the appointment. If you don't assign an associate to the `Associate` property of the appointment, the current user will become the owner of the appointment and only one row will be added to the [appointment][5] table when the appointment is saved.

### Common scenarios

| scenario | resource | 2+ participants | description |
|---|:-:|:-:|---|
| own time reserved | | | you have set aside time to work on something, alone |
| own time and resource reserved   | x | | as above + need room or equipment |
| meeting w/ multiple participants | x | x | a meeting, commonly also w/ a resource or location  |

**Also:**

* Appointments can be single events or part of a recurring series.
* Overdue and completed appointments will be in the todo list in addition to in the calendar.
* Appointments involving a resource and/or additional participants are called **bookings** (or group reservation).
* Appointments can be created by the owner or assigned/delegated to an associate.

### Types

| Type | Description |
|:----:|:--|
| 0 | Undefined/initializing |
| 1 | In calendar, if overdue or done today, also in todo list |
| 2 | In todo list (no start time) |
| 6 | Meeting invite (changes to 1 when accepted) |
| 7 | Pending assignment (changes to 2 when accepted) |

### Status

| Status | Description |
|:-:|:--|
| 0 | Unknown/ a post-it |
| 1 | Not started |
| 2 | Started |
| 3 | Completed |
| 4 | Hidden |
| 5-10 | Booking |
| 11-13 | Assignment |

## Todo list

A **task** is a follow-up without a start time. It usually doesn't have a duration either, but it always has a **deadline**.
Tasks are typically used for things you have to remember to do by a certain time.

By default, you'll find tasks in the diary todo list, where they can be checked off when completed.

## Phone calls

A **call** is a follow-up representing a very specific action - the phone call.

It is also kinda a hybrid between an appointment and a task:

* When you initially plan a call, it lives in the todo list with a deadline much like a task.
* When you make the call, it gets fixed in time and now resembles an appointment.
  * The start time becomes the current time and today's date.
  * The default duration is 15 minutes.

## Follow-ups vs. other entities

Follow-ups are part of a broader group of entities labeled **activities**:

* follow-ups
  * appointment
  * task
  * call
* documents
  * [document][11]
  * [email][10]
* mailings and form submissions
* [chat sessions][12]

When working with follow-ups, data will often intersect with the following entities:

* [company][1] (contact table)
* [contact][2] (person table)
* [project][4]
* [sale][3]

## See also

* [Recurring appointments][6]
* [Invitations][7]
* [Working with appointments in API][8]

<!-- Referenced links -->
[1]: ../company/index.yml
[2]: ../contact/index.yml
[3]: ../sale/index.yml
[4]: ../project/index.yml
[5]: ../database/tables/appointment.md
[6]: recurring-appointments.md
[7]: learn/invitation/index.md
[8]: howto/index.md
[9]: ../contact/associate.md
[10]: ../email/index.yml
[11]: ../document/index.yml
[12]: ../automation/chatbot/index.md

<!-- Referenced images -->
[img1]: media/diary-screen.png
