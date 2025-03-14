---
uid: help-en-project-guide-create
title: Create a new project guide
description: How to create a new project guide in SuperOffice
keywords: create project guide, new project guide, project guide, guide, workflow, project
author: SuperOffice RnD
date: 01.03.2025
version: 10
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Create a new project guide

[!include[Must be admin](../../learn/includes/req-admin.md)]

In Settings and maintenance, you define which project types are to be assigned a project guide and which statuses and activities the project guides are to contain. What a project guide looks like can therefore vary.

For example, you may have a project type named **Conference**. This project type may be linked to a project guide containing the following statuses, follow-ups and documents:

| Statuses | Follow-ups | Documents |
|---|---|---|
| Planned | Planning meeting (Meeting (Internal)) | Conference programme (Note) |
| In progress | Create list of project members (Task); Conference (Meeting (External)) | Conference invitation (Letter) |
| Closing | Evaluation meeting (Meeting (Internal)) | Evaluation report (Note) |

This procedure shows you how to create a project guide from scratch.

1. Define [statuses](#create-stage) to include in the project guide.
2. Define the [project type](#create-type) (with associated statuses) to link the project guide to.
3. Design the [project guide](#create-guide).

![Go to the Workflow section and create your own project routines in SuperOffice CRM -screenshot][img2]

## <a id="create-stage"></a> Create statuses for the project guide

A project guide must be linked to a project type, which in turn consists of several statuses. [How to create a status][2].

For example, a project guide for a project of the Conference type could have statuses Planned, In progress, and Closing.

Go to the next procedure to link the statuses to a project type.

## <a id="create-type"></a> Create a project type for the project guide

A project guide must be linked to a project type. [How to create a project type][3].

Examples of project types: "Conference", "Campaign", "Internal".

1. Check **This project type is linked to a guide**.
1. Select at least two statuses.
1. Go to the next procedure to create the project guide.

## <a id="create-guide"></a>Create a project guide

After you create statuses and specify a project type for the project guide, you can design the project guide itself. You do this by adding follow-ups and/or documents for each status in the project guide.

1. Select <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Workflow** in the Navigator.

2. Go to the **Project guide** tab.

3. In the **Project type** list, select the project type you want to create a project guide for. The statuses selected for this project type are displayed in the list above.

    > [!NOTE]
    > If the project type is not set up to have a project guide, click **Click here to enable guide** at the bottom of the screen.
    >
    > If there are no statuses defined for the project type, click **Click here to add statuses** at the bottom of the screen. You can also edit the project type by clicking the **Edit** button at the top.

4. Select the required status in the list. The status's details are shown at the bottom of the screen.

5. [Add one or more follow-ups for the selected status](#add-fo-status).

    > [!NOTE]
    > You do not have to add a document for each status, but you should add at least one follow-up for each status.

6. [Add one or more documents for the selected status](#add-doc-status).

7. Repeat steps 4-6 for each status you want to add follow-ups and documents for.

The changes are saved automatically. The project guide will now be displayed in SuperOffice CRM when a project is created with the project type selected in step 2.

## <a id="add-fo-status"></a>Add a follow-up for a status

1. Select the required project type and status as described above.

2. Click **Add** under **Suggested follow-ups in status**.

3. In the **Suggested follow-up** dialog, enter the name of the follow-up in the **Name** field. This should be a descriptive name for the follow-up.

4. Enter the purpose of the follow-up, in the **The purpose of this follow-up** field. This text is displayed when you hold the mouse-pointer over the follow-up in the **Project guide** section tab in SuperOffice CRM.

    > [!NOTE]
    > Some of the options before are, for logical reasons, not relevant for the first follow-up in a project guide.

5. Check **Assign follow-up to project member** to make it possible to assign this follow-up to one of the project participants. When the project owner creates this follow-up in SuperOffice CRM, they can choose one of their associates to be the owner of the follow-up.

6. Check **Milestone follow-up** to define the follow-up as a milestone.

7. Select a type for the follow-up in the **Follow-up type** list.

8. In the **Start date** field, enter when the follow-up should start, as the number of days from today.

9. In the **Duration** field, specify how long the follow-up should last. The format is *0h00m*.

10. In the **Default text in follow-up** field, enter a description for the follow-up.

    > [!TIP]
    > The user can change the above information as required.

11. Click **Save**.

12. Repeat this procedure to add more follow-ups in this or other statuses.

### Example of a follow-up

* **Project type**: Conference
* **Status**: Planned
* **Name** of follow-up: Planning meeting
* **Purpose of this follow-up**: Hold a meeting to plan the conference and set out a conference programme.
* **Follow-up type**: Meeting (Internal)
* **Duration**: 1 hour
* **Default text**:

Planning meeting:

\- What should the conference cover?
\- Attendees?
\- Speakers?
\- Where?

## <a id="add-doc-status"></a>Add a document for a status

1. Select the required project type and status as described above.
2. Click **Add** under **Suggested documents in status**.
3. In the **Suggested document** dialog, enter the name of the document in the **Name** field. This should be a descriptive name for the document.
4. Enter the purpose of the document, in the **The purpose of this document** field. This text is displayed when you hold the mouse-pointer over the document in the **Project guide** section tab in SuperOffice CRM.
5. Select the required [template][4] in the **Template** field.
6. Enter the subject to be used in the document in the **Default subject** field.
7. Enter any reference in the **Our ref.** field. For example, a [template variable][1] for a project number, project title or another field relating to the project.
8. Click **Save**.
9. Repeat this procedure to add more documents in this or other statuses.

### Example of a document

* **Project type**: Conference
* **Status**: Planned
* **Name** of document: Conference programme
* **Purpose of this project status**: Set out a programme for the conference.
* **Template**: Note
* **Default subject**: Conference programme

## Related content

* [Edit or deactivate a project guide][5]

<!-- Referenced links -->
[1]: ../../document/templates/variables/from-project-card.md
[4]: ../../document/templates/learn/index.md
[2]: project-status.md
[3]: project-type.md
[5]: edit-project-guide.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/project/create-project-guide.png
