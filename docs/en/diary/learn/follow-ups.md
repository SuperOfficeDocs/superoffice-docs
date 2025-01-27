---
uid: help-en-follow-ups
title: Follow-ups
description: Follow-ups - meeting, to-do, call
keywords: follow-up, appointment, meeting, task, to-do, phone, call, attendee, participant, diary
author: Bergfrid Dias
date: 01.10.2025
version: 10.5
topic: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Follow-ups

*Follow-up* is a collective term for [meetings](#meeting) and [to-dos](#todo). A [phone call](#call) is a hybrid of the two. These activities are closely linked to the Diary screen and function in largely the same way.

Open an existing follow-up by double-clicking it in the Diary or the **Activities** section tab.

## General information

| Icon | Property | Description |
|:-:|---|---|
| <i class="ph ph-user" aria-label="User"></i> | Owner | Who the follow-up belongs to. The original creator or the associate that the follow-up was assigned/delegated to. |
| <i class="ph ph-text-align-left" aria-label="Align left"></i> | Title | A descriptive label. Additional details go in the agenda. |
| (a colored dot) | Type | A pre-defined list of activities such as Meeting (external) and Phone-In. |
| <i class="ph ph-buildings" aria-label="Company"></i>, <i class="ph ph-user-circle" aria-label="Contact"></i> | Company / contact | Who the follow-up concerns. |
| <i class="ph ph-clock" aria-label="Clock"></i> | Time and date | When the follow-up starts or is due. |
| <i class="ph ph-arrows-clockwise" aria-label="Recurrence"></i> | Recurrence | If and how the follow-up repeats. |
| (no icon) | Availability | Free/busy. Affects conflict handling. |
| <i class="ph ph-bell" aria-label="Bell"></i> | Alarm | If and when to notify the person. |
| <i class="ph ph-currency-circle-dollar" aria-label="Sale"></i> | Sale | A sale linked to the follow-up. |
| <i class="ph ph-clipboard-text" aria-label="Clipboard"></i> | Project | A project linked to the follow-up. |
| <i class="ph ph-users" aria-label="Users"></i> | Attendees | A project linked to the follow-up. |
| <i class="ph ph-chair" aria-label="Clipboard"></i> | Resource | Meeting rooms, locations, or resources. |
| <i class="ph ph-map-pin" aria-label="Clipboard"></i> | Location | The location or address where the meeting takes place. |

## Create new

No matter where you are in SuperOffice CRM, you can create a follow-up by clicking **New** on the top bar and then select **Meeting**, **To-do**, or **Follow-up**.

> [!NOTE]
> Follow-ups created from the Diary screen are by default meetings. However, you can change the type before you save.

## Locate your follow-ups

In in the Diary screen, meetings and phone calls appear on the **Day**, **Week**, **Month**, and **View** tabs - and in the **Day**, **Month**, **Next day**, and **Week** side panels.

The **Activities** section tab (in the Company, Contact, Sale, Project, and Diary screen) shows all follow-ups, including to-dos.

## Follow-up types

| Type | Start time | End time | Duration | Deadline | Shown in | Description | Example |
|---|:-:|:-:|:-:|:-:|---|---|---|
| Meeting (appointment) | &#10003; | &#10003; | Calculated | | Calendar | Activity w/ defined start and end time | External meeting with supplier |
| To-do (task) | | | | &#10003; | Activities section tab | Follow-up w/ no start time | reminder for stuff due by a specific time |
| Follow-up (call) | &#10003; | | &#10003; | | Activities section tab | Phone call | Incoming call from customer |

## <a id="meeting"></a>Meeting (appointment)

Meetings are activities with a defined start and end time. They are shown in the owner's calendar.

A meeting can be a single event or part of a recurring series. Meetings involving a resource and/or additional attendees are called [invitations][5].

Overdue and completed meetings will be in the **Activities** section tab in addition to in the calendar.

### Common scenarios

| Scenario | Resource | 2+ attendees | Description |
|---|:-:|:-:|---|
| Own time reserved | | | You have set aside time to work on something, alone |
| Own time and resource reserved | &#10003; | | As above plus need room or equipment |
| Meeting with multiple attendees | &#10003; | &#10003; | A meeting, commonly also with a resource or location |

## <a id="todo"></a>To-do (task)

A *to-do* is a follow-up without a start time. It usually does not have a duration either, but it always has a **deadline**. To-dos are typically used for things you have to remember to do by a certain time.

By default, you will find to-dos in the diary todo list, where they can be checked off when completed. If you specify a start and end time for a to-do, it is entered in the diary at the given day and time.

## <a id="call"></a>Follow-up (phone call)

A *call* represents a very specific action - the phone call - and is a hybrid between an meeting and a to-do:

* When you initially plan a call, it lives in the todo list with a deadline much like a to-do.
* When you make the call, it gets fixed in time and now resembles an meeting.
  * The start time becomes the current time and today's date.
  * The default duration is 15 minutes.

## Default duration

The default duration is 1 hour for a meeting and 15 minutes for a call. To change the default value:

1. Go to <i class="ph ph-user-circle" aria-hidden="true"></i> **Personal settings** and select **Preferences**.
1. Select **Default values**.
1. Enter a value for one or both of these values and click **Save**.
    * **Duration for new meeting**
    * **Duration of a new follow-up**

## <a id="more-tab"></a>The More tab

The [More tab][12] displays custom fields for the follow-up.

## Related content

* [Create a follow-up][2]
* [Learn about activities][4]

<!-- Referenced links -->
[2]: create-follow-up.md
[4]: ../../learn/basics/activity.md
[5]: invitation/index.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
