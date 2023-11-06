---
uid: help-en-project-guide-working-with
title: Work with project guide
description: Work with project guide
author: SuperOffice RnD
so.date: 07.04.2022
keywords: project, guide
so.topic: howto
language: en
---

# Work with project guides

If a project guide is defined for a project type that you specify for a project, the following happens:

* The first status in the project guide is selected in the **Status** field on the main **Project** card.

* Follow-ups and/or documents for the status are listed on the **Project guide** section tab.

## Steps

1. Click the **Create** button in front of the follow-up/document name.

   ![Project guide section tab with overview of Planned status -screenshot][img1]

1. In the dialog that appears, you [create the follow-up][2] or [document][3] in the usual way. Many of the fields are prefilled, but you can change the information, or add more information.

    You can delegate the follow-up to your colleagues by setting them as the owner of the follow-up. If defined in Settings and maintenance for a specific follow-up, the **Assign task to project member** dialog appears, where you can select a colleague as the owner of the follow-up.

1. When you complete the follow-up, check **Completed** in the relevant dialog, or in the checkbox in front of the follow-up name on the **Project guide** section tab. By default, documents are marked as completed.

    > [!TIP]
    > To create several follow-ups of the same type, right-click the activity and select **Create another**.
    >
    > ![In the project guide tab you can right click and select Create another -screenshot][img2]

1. After all the required follow-ups and documents for a project status are completed, you move on to the next status.

    > [!NOTE]
    > If you wish, you can go to the next status without creating or performing all the follow-ups/documents in a status.

1. Repeat the above procedure for all follow-ups/documents in each status of the project guide.

## Move to next status

You can move the project to the next status in two ways:

* To move the project to the next status automatically:

    It can be defined in Settings and maintenance that the project guide should propose moving the project on to the next status when the last follow-up in a status is marked as complete. The **Project guide - move the project to the next status** dialog then opens.

    Click **Yes** to move the project to the next status, or click **No** to continue working on the project within the same status.

* To move the project to the next status manually:

    Right-click the button for the next status in the **Project guide** section tab and select **Move to this status**.

    Or do one of the following on the main **Project** card:

    1. Click **Edit** on the main **Project** card.
    1. Click the arrow next to the **Status** field.
    1. Select the required status from the list that appears. [!include[SM](../../../learn/includes/are-defined-sm.md)]
    1. Click **Save**.

## Example

Keep in mind that your project guides may be configured differently in Settings and maintenance.

### Enter a new project and select a project type

You record a new project and select the **Conference** project type, which is linked to a project guide. The project guide contains the following statuses, follow-ups and documents.

| Statuses | Follow-ups | Documents |
|---|---|---|
| Planned | Planning meeting (Meeting (Internal)) | Conference programme (Memo) |
| In progress | Create list of project members (Follow-up) | conference (Meeting (External)) |
| Closing | Evaluation meeting (Meeting (Internal)) |
| Evaluation report (Memo) |

### The Planned status

1. You have agreed a meeting time and want to create the **Planning meeting** follow-up in the Diary and invite participants.

    1. In the project guide, you click **Create** next to the **Planning meeting** follow-up.
        The **Follow-up** dialog opens, with **Meeting (Internal)** specified as the type and the name of the project prefilled.
    1. Complete the information and [invite participants][1].
    1. Click **Save**.

1. At the meeting you decide on the conference programme (agenda) and you want to create a memo containing this information.

    1. Click **Create** next to **Conference programme**.
        The **Document** dialog opens with **Memo** already selected as the document template, and the name of the project prefilled.
    1. Complete the rest of the information in the fields in the **Document** dialog.
    1. Click the **Create** button to create and save the memo.

1. After the meeting has taken place and the conference programme is ready, you want to confirm this in the project guide and move on to the next project status.

    In the project guide, check the box next to the **Planning meeting** follow-up.

    > [!TIP]
    > You can also do this from the activities list in, for example, the Diary and the Company screens.

    1. The **Project guide - move the project to the next status** dialog opens.
    1. In this dialog, you are asked if you want to move the project to the next status, which is **In progress**.
    1. Click **Yes** to move the project to the next status.

    > [!NOTE]
    > The **Project guide - move the project to the next status** dialog opens because that is what is defined for the project type in Settings and maintenance.

### The In progress status

1. All the follow-ups and documents in the **Planned** status are completed, and you have moved the project on using the **Project guide - move the project to the next status** dialog. This dialog is displayed when you set the last follow-up to completed. The follow-ups and documents for this new status are now displayed in the **Project guide** section tab.

    > [!NOTE]
    > The **Project guide - move the project to the next status** dialog comes up only if this behavior is defined for the project type. If it is not defined, [move the project to the next status](#move-to-next-status).

1. At the planning meeting, you agree that your colleague should set up a list of conference delegates. You want to create a task in their diary as a reminder.

    1. Click **Create** next to the **Create list of project members** follow-up.
        The **Assign task to project member** dialog opens.

    1. In the list of project members, select the person you want to assign the task, and click **OK**.

    1. Enter the required information in the dialog and click **Save**. (In the **Details** tab, you can see that your colleague is already defined as the owner.)

    1. The follow-up is displayed in your colleague's diary, and after they have sett up the list, they will mark the follow-up as **Completed**.

        > [!NOTE]
        > The **Assign task to project member** dialog opens because that is what is defined in Settings and maintenance.

1. You now want to produce an invitation letter.

    Click **Create** next to the **Conference invitation** document and [create the document][3].

1. Finally, the conference itself is held. You create the **Conference** meeting.

    1. Click **Create** next to the **Conference** follow-up.
        The **Follow-up** dialog opens, with **Meeting (External)** specified as the type and the name of the project prefilled.
    2. Complete the information and invite the conference participants in the usual way.
    3. Click **Save**.

### The Closing status

1. After the conference and all relevant follow-ups and documents in the **In progress** status are completed, you go to the last status in the project guide, which is **Closing**.

    * Click **Yes** in the **Project guide - move the project to the next status** dialog.
        or
    * Click **Edit** on the main **Project** card, click the arrow to the right of the **Status** field and select **Closing** from the list, and then click **OK**.

1. You want to hold an internal meeting to summarize the conference.

    1. Click **Create** next to the **Evaluation meeting** follow-up, enter information, and save.
    2. When the meeting is completed, check the box.

1. Then you want to produce an evaluation report that summarizes the evaluation meeting and the conference.

    Click **Create** next to the **Evaluation report** document to create the document.

After all the required follow-ups and documents for the project are completed, you can set the project status to completed.

## Related topics

* [The Document dialog][1]
* [The dialog for follow-ups][2]
* [Add and edit project guides in Settings and maintenance][4]

<!-- Referenced links -->
[1]: ../../../diary/learn/invitation/add-participant.md
[2]: ../../../diary/learn/create-follow-up.md
[3]: ../../../document/learn/edit.md
[4]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/project/project-guide-create.png
[img2]: ../../../../media/loc/en/project/project-guide-right-click.png
