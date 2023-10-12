---
uid: help-en-follow-ups
title: Follow-ups
description: Follow-ups - appointment, task, phone call
author: Bergfrid Dias
so.date: 10.11.2023
keywords: diary, follow-up, appointment, meeting, task, to-do, phone, call, participant
so.topic: concept
language: en
---

# Follow-ups

*Follow-up* is a collective term for [appointment](#apt), [task](#task), and [phone call](#call). These activities are closely linked to the Diary screen and function in largely the same way.

Open an existing follow-up by double-clicking it in the Diary or the **Activities** section tab.

## General information

| Icon | Property | Description |
|:-:|---|---|
| ![icon][img9]| Owner | Who the follow-up belongs to. The original creator or the associate that the follow-up was assigned/delegated to. |
| ![icon][img3]| Title | A descriptive label. Additional details go in the agenda. |
| (a colored dot) | Type | A pre-defined list of activities such as Meeting (external) and Phone-In. |
| ![icon][img7], ![icon][img8] | Company / contact | Who the follow-up concerns. |
| ![icon][img10]| Time and date | When the follow-up starts or is due. |
| ![icon][img4]| Recurrence | If and how the follow-up repeats. |
| (no icon) | Availability | Free/busy. Affects conflict handling. |
| ![icon][img2] | Alarm | If and when to notify the person. |
| ![icon][img5] | Sale | A sale linked to the follow-up. |
| ![icon][img6] | Project | A project linked to the follow-up. |

## Create new

No matter where you are in SuperOffice CRM, you can create a follow-up by clicking **+New** in the top bar and then select **Appointment**, **Task**, or **Phone call**.

> [!NOTE]
> Follow-ups created from the Diary screen are by default appointments. However, you can change the type before you save.

## Locate your follow-ups

In in the Diary screen, appointments and phone calls appear on the **Day**, **Week**, **Month**, and **View** tabs - and in the **Day**, **Month**, **Next day**, and **Week** side panels.

The **Activities** section tab (in the Company, Contact, Sale, Project, and Diary screen) shows all follow-ups, including tasks.

## Follow-up types

| Type | Start time | End time | Duration | Deadline | Shown in | Description | Example |
|---|:-:|:-:|:-:|:-:|---|---|---|
| Appointment (meeting) | &#10003; | &#10003; | Calculated | | Calendar | Activity w/ defined start and end time | External meeting with supplier |
| Task (To-do) | | | | &#10003; | Activities section tab | Follow-up w/ no start time | reminder for stuff due by a specific time |
| Call (follow-up) | &#10003; | | &#10003; | | Activities section tab | Phone call | Incoming call from customer |

## <a id="apt" />Appointment (meeting)

Appointments are activities with a defined start and end time, such as meetings. They are shown in the owner's calendar.

An appointment can be a single event or part of a recurring series. Appointments involving a resource and/or additional participants are called [invitations][5] (or group reservations).

Overdue and completed appointments will be in the **Activities** section tab in addition to in the calendar.

### Common scenarios

| Scenario | Resource | 2+ participants | Description |
|---|:-:|:-:|---|
| Own time reserved | | | You have set aside time to work on something, alone |
| Own time and resource reserved | &#10003; | | As above plus need room or equipment |
| Meeting with multiple participants | &#10003; | &#10003; | A meeting, commonly also with a resource or location |

## <a id="task" />Task (to-do)

A *task* is a follow-up without a start time. It usually does not have a duration either, but it always has a **deadline**. Tasks are typically used for things you have to remember to do by a certain time.

By default, you will find tasks in the diary todo list, where they can be checked off when completed. If you specify a start and end time for a task, it is entered in the diary at the given day and time.

## <a id="call" />Phone call (follow-up)

A *call* is a follow-up representing a very specific action - the phone call. For example, you want to enter an outgoing phone call.

It is also kinda a hybrid between an appointment and a task:

* When you initially plan a call, it lives in the todo list with a deadline much like a task.
* When you make the call, it gets fixed in time and now resembles an appointment.
  * The start time becomes the current time and today's date.
  * The default duration is 15 minutes.

## Default duration

The default duration is 1 hour for an appointment and 15 minutes for a call. To change the default value:

1. Go to ![icon][img14] **Personal settings** and select **Preferences**.
1. Select **Default values**.
1. Enter a value for one or both of these values and click **Save**.
    * **Duration for new appointment**
    * **Duration of a new phone call**

## Related content

* [Create an appointments, a task, or a phone call][2]
* [Learn about activities][4]

<!-- Referenced links -->
[2]: create-follow-up.md
[4]: ../../learn/basics/activity.md
[5]: invitation/index.md

<!-- Referenced images -->
[img2]: ../../../../common/icons/diary-alarm.png
[img3]: ../../../../common/icons/title.png
[img4]: ../../../../common/icons/diary-recurring-transparent.png
[img5]: ../../../../common/icons/sale.png
[img6]: ../../../../common/icons/singlecolour/project.png
[img7]: ../../../../common/icons/singlecolour/contact.png
[img8]: ../../../../common/icons/person.png
[img9]: ../../../../common/icons/associate-current.png
[img10]: ../../../../common/icons/now.png
[img14]: ../../../media/icons/personal-settings-small.png
