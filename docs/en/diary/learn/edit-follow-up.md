---
uid: help-en-follow-up-edit
title: Edit follow-up
description: How to open, edit, or delete a follow-up; Change the end time for a follow-up in the Diary; Edit or delete invitation; Edit repeating follow-up
author: Bergfrid Dias
so.date: 11.20.2023
so.version: 10.2.11
keywords: diary, follow-up, appointment, meeting, task, to-do, call, phone, invitation
so.topic: howto
language: en
---

# Edit follow-up

[!include[Note](includes/note-edit-followup.md)]

If you edit the time, date, or location of a follow-up - or delete an invitation that you created and sent - the invitees will receive a message about this.

## Steps

1. Open an existing follow-up by double-clicking it:

    * In the **Activities** section tab in the Company, Contact, Diary, Project, or Sale screen.
    * On the different tabs in the Diary screen.

2. [Make the required changes in the dialog.][3]

    [!include[Recurrence](includes/note-repetition.md)]

3. Click **Save**.

> [!NOTE]
> You cannot edit completed follow-ups until you have undone their **Completed** status.

## <a id="change-end" />Change the end time for a follow-up in the Diary

In the Diary screen, you can change the end time for a follow-up without having to open it:

1. Click the follow-up in the **Day** tab, **Week** tab, or **View** tab.

2. Position the mouse pointer on the bottom border of the follow-up. The pointer changes into a double arrows.

3. Click the border and hold down the mouse button, while dragging the blue line up or down to decrease or increase the time slot for the follow-up. You can see the end time for the follow up in the top of the blue area.

4. Release the mouse button. The time slot for the follow-up is changed.

> [!NOTE]
> You can also change the time slot by opening the follow-up and changing the **Start**, **End**, **Due**, or **Duration** fields.

## <a id="repeat" />Edit repeating follow-up

Changes work in the same way as when you edit follow-ups, but when you make a change, the **Repeating follow-ups** dialog appears.

![Repeating follow-up dialog -screenshot][img1]

* If you select **Change only this instance**, the change will not affect other times.

* If you select **Change all future instances including this one**, the change will apply to this follow-up and all repetitions in the future as well.

You can change only the start date for the follow-up while viewing the recurrence details. To change the time, click **OK** or **Cancel** to return to the follow-up details.

If you decide to change the rule in the middle of a series of meetings, then a new rule is created, and the old rule is stopped at the point where the break occurs.

If you change the start time for a single meeting, the rule is not affected. The meeting is treated as an exception to the rule. The exception can be made un-exceptional by moving it back into line with the other meetings.

[!include[Caution](includes/caution-do-not-change-recurring-date.md)]

## <a id="delete" />Delete follow-up using the Diary

* If you delete a follow-up you are invited to, the follow-up is removed from your diary only.
* If you delete an invitation that you own from your Diary, this follow-up also disappears from the invitees' diaries.

1. Select the required follow-up.
2. Right-click and choose **Delete**.
3. Confirm or cancel the deletion in the confirmation dialog.

[!include[Deleting items](../../learn/includes/tip-deletion.md)]

## Related topics

* [Change Completed status of an activity][2]
* [Stop repeating follow-ups][5]

<!-- Referenced links -->
[2]: change-completed-status.md
[3]: create-follow-up.md#fields
[5]: recurrence/stop.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/diary/change-repeating-fo.png
