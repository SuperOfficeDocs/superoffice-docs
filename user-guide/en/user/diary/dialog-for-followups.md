---
uid: help-en-dialog-for-followups
title: Dialog for followups
description: Dialog for followups
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# The Dialog for follow-ups

Regardless of the type of follow-up you are working with, you will see the dialog for follow-ups. The actual name of this dialog varies according to the type of follow-up – **Appointment** (see [Appointment][1]), **Task** (see [Task][2]) or **Phone Call** (see [Phone Call][3]) – but the fields are the same in each case. The fields in the dialog and how to use them are described below.

The dialog consists of a main section with general information about the follow-up, and five tabs with additional information.

* [Description][4]
* [Details][5]
* [Participants][6]
* [Links][7]
* [More][8]

The main section contains the following essential information about the follow-up:

**\[Type\]:**

Click the arrow next to this field ( ![icon][img2] ) to display a predefined list of follow-up types to choose from, for example, a meeting or outgoing phone call. You can also search for types by typing into this field. Here you can also use [FastSearcher][12].

> [!NOTE]
> It is the **\[Type\]** field which determines the type of follow-up in question, i.e. an appointment, task or phone call.

**\[Video meeting\]:**

Click ![icon][img3] to set up a video meeting. The icon changes to ![icon][img4]. See [Set up video meetings][9].

**\[Company\]:**

Enter here the name of the company linked to the follow-up (optional). If you cannot remember the whole name, you can search directly from this field.

**\[Contact\]:**

Click the arrow next to this field and a list of known contacts in the company is displayed. If no company has been selected, you will see a list of contacts that are not associated with a company. You can search directly from this field.

**Project:**

Enter the name of the project that the follow-up is linked to. If you cannot remember the whole name, you can search directly from this field.

> [!NOTE]
> In the **Project** field, you can specify any of the projects which are saved in SuperOffice CRM, regardless of which company the follow-up is linked to.

**Sale:**

Here you enter the name of the sale, if any, that the follow-up is linked to. If you cannot remember the whole name, you can search directly from this field.

\[Time zone selector\]

If time zones have been activated in SuperOffice Settings and maintenance, you can select which time zone the follow-up will be created in. The time zones are displayed by country, and you can search both by country and city directly in the time zone field (see [Time zones][10]).

**Start / End/Due / Duration:**

Enter a date and, where appropriate, a time in the **Start** field and the **End** field (for appointments and phone calls) or **Due** field (for tasks), for the follow-up start and the follow-up end/deadline respectively. If you specify a time, the content of the **Duration** field is automatically adjusted accordingly.

> [!TIP]
> If the follow-up conflicts with another one or has several participants, the **First available** field is displayed, showing the first available meeting time.

**All day:**

If you check **All day**, the time of the appointment is set to the period specified as the default working day.

> [!TIP]
> These default values are specified in the [Preferences][13] dialog. Select **Diary**, and enter the required times for **All-day start time** and **All-day end time**.

**Location:**

Here you choose the address where the follow-up will take place. By default, this field is empty, but if you click the arrow ( ![icon][img2] ) next to the field, two entries are displayed in a list box. One is the user's company and the other is the company that is to be followed up. If you have specified a resource of type **Location** as a participant in the **Participants** tab, e.g. a meeting room, the resource is also displayed in this list box.

> [!TIP]
> You can also simply enter an address for the location.

Completed ![icon][img5] ![icon][img6]

Check here when the follow-up is completed. For more information, see [Mark activities as completed/not completed][11].

**Task:**

![icon][img1]

Click this button to access relevant tasks that can be performed on the active entry. Examples: Delete, Print, Send as e-mail, Assign to and Cancel meeting. In SuperOffice Settings and maintenance, you can also define your own tasks and add them under the **Task** button. For more information about this, see the Help for SuperOffice Settings and maintenance.

**Registered/Last modified:**

These fields show the date when the follow-up was first created and when it was last modified. They also show who completed these actions.

> [!TIP]
> If you hold the mouse pointer over this text, a tooltip appears containing more information about when the follow-up was created and last modified.

<!-- Referenced links -->
[1]: appointment.md
[2]: task.md
[3]: phone-call.md
[4]: description-tab-follow-ups.md
[5]: details-tab-follow-ups.md
[6]: participants-category.md
[7]: links-tab-follow-ups.md
[8]: more-tab-follow-ups.md
[9]: video-meetings.md
[10]: time-zones.md
[11]: marking-activities-as-completed-not-completed.md
[12]: ../standardcrm/key-functions/using-fastsearcher.md
[13]: ../standardcrm/key-functions/preferences.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img2]: ../../../media/icons/dialogboksknapper-pil-ned.bmp
[img3]: ../../../media/icons/videomeeting-inactive.png
[img4]: ../../../media/icons/videomeeting-active.png
[img5]: ../../../media/icons/followup-notcompleted.png
[img6]: ../../../media/icons/followup-completed.png
