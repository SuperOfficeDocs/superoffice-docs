---
uid: help-en-project-guide-example
title: Example project guide
description: Example project guide
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: help
language: en
---

# Project guide example

Which project types are assigned a project guide and which statuses and activities the project guides are to contain is set up in SuperOffice Settings and maintenance. What a project guide looks like can therefore vary, but below is an example of how a project using a project guide may proceed.

## A: Enter a new project and select a project type

You record a new project and select the **Conference** project type, which is linked to a project guide. The project guide contains the following statuses, follow-ups and documents.

| Statuses | Follow-ups | Documents |
|---|---|---|
| Planned | Planning meeting (Meeting (Internal)) | Conference programme (Memo) |
| In progress | Create list of project members (Follow-up) | erence (Meeting (External)) |
| Closing | Evaluation meeting (Meeting (Internal)) |
| Evaluation report (Memo) |

## B: The Planned status

1. You have agreed a meeting time and want to create the **Planning meeting** appointment in the Diary and invite participants.

    1. In the project guide, you click **Create** next to the **Planning meeting** follow-up.
        The **Appointment** dialog opens, with **Meeting (Internal)** specified as the appointment type and the name of the project prefilled.
    2. Complete the information and invite participants. This is described under [The Dialog for follow-ups][1].
    3. Click **Save**.

2. At the meeting you decide on the conference programme (agenda) and you want to create a memo containing this information.

    1. Click **Create** next to **Conference programme**.
        The **Document** dialog opens with **Memo** already selected as the document template, and the name of the project prefilled.
    2. Complete the rest of the information in the fields in the **Document** dialog.
    3. Click the **Create** button to create and save the memo.

3. Once the meeting has taken place and the conference programme has been decided on, you want to confirm this in the project guide and move on to the next project status.

    In the project guide, check the box next to the **Planning meeting** follow-up.

    > [!TIP]
    > You can also do this from the activities list in, for example, the **Diary** and the **Company** screens.

    1. The **Project guide - move the project to the next status** dialog opens.
    2. In this dialog, you are asked if you want to move the project to the next status, which is **In progress**.
    3. Click **Yes** to move the project to the next status.

    > [!NOTE]
    > The **Project guide - move the project to the next status** dialog opens because that is what is defined for the project type. This is done in SuperOffice Settings and maintenance.

## C: The In progress status

1. All the follow-ups and documents in the **Planned** status have been completed, and you have moved the project on using the **Project guide - move the project to the next status** dialog. This dialog is displayed when you set the last follow-up to completed. The follow-ups and documents for this new status are now displayed in the **Project guide** section tab.

    [!NOTE]
    > The **Project guide - move the project to the next status** dialog only comes up if this behaviour is defined for the project type. If it is not defined, you need to [move the project to the next status][5].

2. At the planning meeting, you agree that your colleague should set up a list of conference delegates. You want to create a task in his diary to remind him about this.

    1. Click **Create** next to the **Create list of project members** follow-up.
        The **Assign task to project member** dialog opens.

    2. In the list of project members, select the person you want to assign the task, and click **OK**. The **Appointment** dialog opens.

    3. Enter the required information and click **Save**. (In the **Details** tab, you can see that your colleague is already defined as the owner.)

    4. The follow-up is displayed in your colleague's diary, and once he has finished setting up the list, he will mark the follow-up as **Completed**.

        > [!NOTE]
        > The **Assign task to project member** dialog opens because that is what is defined in SuperOffice Settings and maintenance.

3. You now want to produce an invitation letter.

    Click **Create** next to the **Conference invitation** document and create the document. (See [Edit documents][2]).

4. Finally, the conference itself is held. You create the **Conference** meeting.

    1. Click **Create** next to the **Conference** follow-up.
        The **Appointment** dialog opens, with **Meeting (External)** specified as the appointment type and the name of the project prefilled.
    2. Complete the information and invite the conference participants in the usual way.
    3. Click **Save**.

## D: The Closing status

1. Once the conference has been held and all relevant follow-ups and documents in the **In progress** status have been completed, you go to the last status in the project guide, which is **Closing**.

    * Click **Yes** in the **Project guide - move the project to the next status** dialog.
        or
    * Click **Edit** on the main **Project** card, click the arrow to the right of the **Status** field and select **Closing** from the list, and then click **OK**.

2. You want to hold an internal meeting to summarise the conference.

    1. Click **Create** next to the **Evaluation meeting** appointment and create the appointment in the usual way.
    2. When the appointment has been completed, check the box.

3. Then you want to produce an evaluation report which summarises the evaluation meeting and the conference.

    Click **Create** next to the **Evaluation report** document to create the document.

Once all the required follow-ups and documents for the project have been completed, you can set the project status to completed.

## Related topics

* [Work with project guides][3]
* [View follow-ups and documents][4]

<!-- Referenced links -->
[1]: ../../clients/sales/diary/dialog-for-followups.md
[2]: ../../document/edit.md
[3]: work-with-projectguide.md
[4]: view-followups-and-documents.md
[5]: work-with-projectguide.md#move-to-next-status

<!-- Referenced images -->
