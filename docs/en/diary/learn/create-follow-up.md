---
uid: help-en-follow-up-create
title: Add follow-up
description: How to add or copy meeting, to-do, or call in SuperOffice CRM.
keywords: add follow-up, new follow-up, book meeting, schedule meeting, add to-do, add call, follow-up, appointment, meeting, task, to-do, call, phone, diary
author: Bergfrid Dias
date: 03.06.2025
version: 10.5.2
topic: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Add follow-up

Creating follow-ups and scheduling all meetings and activities in your SuperOffice Diary help you to always have a complete overview of what is happening, build up solid communication history, and keep your colleagues informed.

## Steps

There are many ways to create a follow-up. This method works from anywhere in SuperOffice CRM and for all types of follow-ups.

1. Click **New** on the top bar and select **Meeting**, **To-do**, or **Follow-up**.

2. [Enter the required information in the fields.](#fields)

    Some information is inserted automatically based on the context, for example, today's date.

3. Click the **Save** button.

**Other options:**

| Starting point | Meeting | Follow-up | To-do  |
|---|---|---|---|
| Activities section tab | x | x | x |
| Task button on a contact | x | x | |
| Diary | x | | |

### <a id="fields"></a>How to enter information

> [!NOTE]
> Many fields have a list of predefined values you can choose from. Click <i class="ph ph-caret-down" aria-label="Chevron"></i> to expand the list. Then select a value for that field. Alternatively, start typing in the field to search for a specific value, such as a company name.

If your SuperOffice has [time zones][9] turned on, you can select which time zone the follow-up will be created in. The time zones are displayed by country, and you can search both by country and city directly in the time zone field.

If you check **All day**, the time of the follow-up is set to the period specified as the [default working day][8] (**All-day start time** and **All-day end time** preference).

![Follow-up dialog -screenshot][img7]

1. Enter a title.

1. Click the colored ball and select a follow-up type.

1. Optionally, select a company or contact the follow-up pertains to. If you want to invite them and others to your meeting, click **Invite**.

    * [Add attendees][5].
    * Optionally, add a location or address.
    * Optionally, add meeting rooms, locations, or resources.

    ![Extended follow-up dialog -screenshot][img8]

1. Specify time and date. Click **Show more** to set [recurrence][4], "all day", "busy/free", and timezone. Click the bell icon in the header to [set the alarm][3].

1. Optionally, select a project and/or sale to link it to the follow-up. You can choose any project/sale regardless of which company you chose earlier.

1. Select the **Agenda** tab to add additional information, such as an agenda, a description of the follow-up, files, images, and links. Use the buttons in the footer to add rich text formatting and content.

    > [!TIP]
    > If you want to restrict access to employees-only, place that content in the **Internal notes** tab. Whatever is added here is not sent to external attendees. Click the clock icon to add a timestamp. A dot on the tab indicates that someone has added a note.

## Create follow-up from Activities section tab

* Click the **Add** button in the **Activities** section tab.

* Or, double-click an empty row below the last activity in the list. If you see no empty rows, position the mouse pointer between the section tabs and the card above. The pointer changes to a double-headed arrow. Then click and drag the line up to expand the section tab area.

> [!NOTE]
> If you specify a time or duration for a follow-up you are creating from within the activities list, it is entered in the Diary.

## Create follow-up from Task button

1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> in the Contact card.

    * To create a meeting, select **Request a meeting**.

    * To register a call, select **Make a phone call**.

1. Enter information and click **Save**.

## Create meeting from Diary

* **To choose a time slot:** click the time at which you want the meeting to start and hold the mouse button down while you drag the mouse to the required end time for the task. A blue area is displayed while you define the time slot before the **Follow-up** dialog opens.

* **To use default duration:** double-click a time in the Diary or right-click a time in the Diary and select **New**.

> [!NOTE]
> If you create the meeting from the **View** tab, you can choose to have attendees automatically filled out with the members of the view. To set this option, go to <i class="ph ph-user-circle" aria-hidden="true"></i> **Personal settings** > **Preferences** > **Functions** and set the **Participants from group view** preference to **Yes**. Click **Save**.

### <a id="associate"></a>Create meeting for an associate

You can open another user's diary, or the diary of an available resource, to see when they are free or to create follow-ups for them directly.

1. Select the **View** tab in the Diary screen.

2. Click the diary owner list and select the person's diary.

3. Create a new meeting in this diary using the mouse.

4. In the **Follow-up** dialog, [enter the required information](#fields).

5. [Choose the attendee to include][5], if they are not automatically included.

6. Click **Save**. The meeting will be displayed in the selected person's diary.

## <a id="copy"></a>Copy a follow-up to the Diary

You can also create a new follow-up by copying an existing follow-up to another time or day in the diary.

1. Open the diary and locate the follow-up you wish to copy.

2. If the follow-up is completed, right-click it and choose **Completed** to enable editing. (Remember to re-set the status after copying it.)

3. Hold down the **Shift** key while you drag and drop the follow-up to a different time.

## Related content

* [Follow-up types][1]
* [Activities][7]
* [Create a video meeting from the SuperOffice diary][2]

<!-- Referenced links -->
[1]: follow-ups.md
[2]: video-meetings.md
[3]: set-alarm.md
[4]: recurrence/index.md
[5]: invitation/add-attendee.md
[7]: ../../learn/basics/activity.md
[8]: ../../learn/getting-started/preferences.md
[9]: ../../globalization-and-localization/learn/time-zones.md

<!-- Referenced images -->
[img7]: ../../../media/loc/en/diary/follow-up-dialog.png
[img8]: ../../../media/loc/en/diary/follow-up-attendees.png
