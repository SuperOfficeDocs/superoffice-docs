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

Regardless of the type of follow-up you are working with, you will see the dialog for follow-ups. The actual name of this dialog varies according to the type of follow-up – [Appointment][1], [Task][2], or [Phone Call][3] – but the fields are the same in each case. The fields in the dialog and how to use them are described below.

The dialog consists of a main section with general information about the follow-up, and five tabs with additional information:

* Description
* Details
* Participants
* Links
* More

## Information about the follow-up

The main section contains the following essential information about the follow-up:

### Type

Click the arrow next to this field (![icon][img2]) to display a predefined list of follow-up types to choose from, for example, a meeting or outgoing phone call. You can also search for types by typing into this field. Here you can also use [FastSearcher][12].

> [!NOTE]
> The **Type** field determines the type of follow-up in question: appointment, task, or phone call.

## Video meeting

Click ![icon][img3] to set up a [video meeting][9]. The icon changes to ![icon][img4].

### Company

Enter here the name of the company linked to the follow-up (optional). If you cannot remember the whole name, you can search directly from this field.

### Contact

Click the arrow next to this field and a list of known contacts in the company is displayed. If no company is selected, you will see a list of contacts that are not associated with a company. You can search directly from this field.

### Project

Enter the name of the project that the follow-up is linked to. If you cannot remember the whole name, you can search directly from this field.

> [!NOTE]
> In the **Project** field, you can specify any project in SuperOffice CRM, regardless of which company the follow-up is linked to.

### Sale

Enter the name of the sale (if any) that the follow-up is linked to. If you cannot remember the whole name, you can search directly from this field.

### Time zone selector

If [time zones][10] have been activated in SuperOffice Settings and maintenance, you can select which time zone the follow-up will be created in. The time zones are displayed by country, and you can search both by country and city directly in the time zone field.

### Start / End/Due / Duration

Enter a date and, where appropriate, a time in the **Start** field and the **End** field (for appointments and phone calls) or **Due** field (for tasks), for the follow-up start and the follow-up end/deadline respectively. If you specify a time, the content of the **Duration** field is automatically adjusted accordingly.

> [!TIP]
> If the follow-up conflicts with another one or has several participants, the **First available** field is displayed, showing the first available meeting time.

### All day

If you check **All day**, the time of the appointment is set to the period specified as the default working day.

> [!TIP]
> These default values are specified in the [Preferences][13] dialog. Select **Diary**, and enter the required times for **All-day start time** and **All-day end time**.

### Location

Here you choose the address where the follow-up will take place. By default, this field is empty, but if you click the arrow ![icon][img2] next to the field, two entries are displayed in a list box. One is the user's company and the other is the company to follow up.

If you specified a resource of type **Location** (for example a meeting room) as a participant in the **Participants** tab, the resource is also displayed in this list box.

> [!TIP]
> You can also simply enter an address for the location.

Completed ![icon][img5] ![icon][img6]

Check here when the [follow-up is completed][11].

### Task

![icon][img1]

Click this button to access relevant tasks that can be performed on the active entry. Examples: Delete, Print, Send as email, Assign to and Cancel meeting. In SuperOffice Settings and maintenance, you can also define your own tasks and add them under the **Task** button.

### Registered/Last modified

These fields show the date when the follow-up was first created and when it was last modified. They also show who completed these actions.

> [!TIP]
> If you hold the mouse pointer over this text, a tooltip appears containing more information about when the follow-up was created and last modified.

## The Description tab

In this tab, you can add a description of the follow-up. You can use this facility for freetext searching. The description cannot be longer than 2048 characters.

## The Details tab

The **Details** tab contains detailed information about the follow-up.

### Recurrence

In this field, you indicate if the follow-up repeats. Click the word **Never** to the right of the **Recurrence** field if you want the [appointment to be repeated][4] at regular intervals. If a follow-up is repeating, an icon ![icon][img1] at the upper left of the main part of the dialog.

### Priority

Specify here the priority of the follow-up. Click the arrow to display a list with the default options of high, medium and low priority. These are defined in SuperOffice Settings and maintenance.

### Alarm

For notification of the follow-up, check **Alarm**. If an [alarm is specified][5] for a follow-up, an icon ![icon][img2] is displayed at the upper left of the main part of the dialog.

### Owner

Here you specify who owns the follow-up. The default is the user currently logged in. If you click the name next to the **Owner** field, you can transfer the appointment to another SuperOffice user. The **Assign to** dialog opens. Under the **Assign this follow-up to** field is a list box where you can select the required user group. Select the required user and click **OK** to save the changes and close the dialog.

> [!NOTE]
> If a user is already occupied at the time in question, the word **CONFLICT** is displayed in the **Status** field. To hide users with conflicts, check **Hide conflict** at the bottom of the dialog.

### Show as

Check **Free** or **Busy** in the **Show as** field to specify if you are available to others while the appointment is taking place. If you select **Free**, you can have other follow-ups simultaneously, for example if you reserved the majority of the day to work on a project but you still have time for short meetings.

### Visible for

Click the **Visible for** field to display a list that allows you to choose if the follow-up should be visible to all users, visible only to the user defined as owner, or visible to all users in one of the user groups that the owner belongs to.

> [!NOTE]
> If you set visibility to owner only, the entry will appear in italics on the **Activities** section tab.

This option is only available if **Confidential activities** is enabled for the current user in SuperOffice Settings and maintenance.

### Publish (requires separate license)

Check here if you want the follow-up to be visible to external users.

## The Participants tab

This tab contains a [list of participants][6] in the follow-up. Registered participants are marked with a dot.

If you click the **View as group** button ![icon][img7] at the bottom right of the **Participants** tab, the **View** tab in the diary opens, giving you an overview of the [diaries of the invited associates][7] (SuperOffice users).

## The Links tab

This tab contains information about URLs, activities (documents and follow-ups), projects and sales that are [linked to the follow-up][8] in question. If anything is registered in this tab, a dot is displayed next to **Links**.

## The More tab

This tab displays any [custom fields][14] configured in SuperOffice Settings and maintenance.

<!-- Referenced links -->
[1]: ../appointment.md
[2]: ../task.md
[3]: ../phone-call/index.md
[4]: ../recurrence/index.md
[5]: ../set-alarm.md
[6]: ../invitation/index.md
[7]: ../open.md
[8]: ../../howto/linking-documents-to-follow-ups.md
[9]: ../video-meetings.md
[10]: ../../globalization/time-zones.md
[11]: ../change-completed-status.md
[12]: ../../search-options/using-fastsearcher.md
[13]: ../../getting-started/preferences.md
[14]: ../../custom-objects/overview.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img2]: ../../../../common/icons/dropdown-icon.png
[img3]: ../../../../common/icons/videocall-off.png
[img4]: ../../../../common/icons/videocall.png
[img5]: ../../../media/icons/followup-notcompleted.png
[img6]: ../../../media/icons/followup-completed.png
[img7]: ../../../../common/icons/diary-participants.png
