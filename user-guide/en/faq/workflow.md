---
uid: help-en-faq-workflow
title: Workflow stages
description: Workflow stages
author: SuperOffice RnD
so.date: 06.29.2022
keywords: FAQ
so.topic: howto
language: en
---

# Workflow stages

In a new installation, the workflow contains two default stages: **Unpublished** and **Published**. It is possible to add additional stages between these two. For example, you can set up a workflow where an FAQ entry is sent to be proof-read, so that someone checks the entry and then publishes it, or sends it unpublished back for editing.

## Create new stage

1. Select **Knowledge Base** > **FAQ**.
2. Click the **Workflow** button. This takes you to the **View workflow** screen.
3. Click the **New stage** button. This takes you to the **New stage** screen.
4. Enter a descriptive name for the stage in the **Name** field.
5. In the **Place new stage between** list, select where in the process you want to insert the new stage.
6. Click **OK**. This takes you to the **Edit stage** screen.
7. In the **Select user** list at the bottom of the screen, select the name of a user who is to have access to this stage in the workflow.
8. Select which access level the user should have. You can choose from the following options:
    * **Can move**: The user is permitted to change the workflow stage for entries, i.e. publish or cancel publishing.
    * **Can edit**: The user is permitted to edit FAQ entries.
    * **Full access**: The user has all rights in relation to the workflow..
9. Click the ![icon][img3] **Add** button to add the user to the list under **User access**.
10. Repeat steps 7-9 to add more users.
11. Click **OK**. The stage is created and now available when you publish FAQ entries.

## Edit stage

You can both change the name of a stage and alter which users are to have access to it.

1. Select **Knowledge Base** > **FAQ** and click the **Workflow** button.
2. Click the name of the stage. This takes you to the **Edit stage** screen.
3. Edit the name as required.
4. Change which users are to have access to the stage:
    * To add users, follow the procedure above.
    * To remove users, select the user(s) in question, click the ![icon][img1] menu button, and select **Remove access for selected users**.
5. Click **OK**. The changes are saved.

## Delete stage

> [!NOTE]
> You cannot delete the default **Unpublished** and **Published** stages.

1. Select **Knowledge Base** > **FAQ** and click the ![icon][img2] **Workflow** button.
2. Click the name of the stage. This takes you to the **Edit stage** screen.
3. Click **Delete**. If the stage is not associated with any FAQ entries, it is deleted immediately.
4. If it is linked to FAQ entries, you need to select which stage in the workflow these FAQ entries should be moved to. Select the stage you want in the **Move to workflow** list.
5. Click **Delete**. The stage is deleted and associated FAQ entries are moved to the selected stage.

## Publish via workflow

1. [Open the FAQ entry][1].
2. If you want to adjust anything before publishing, follow the procedure under [Publish FAQ entries][2].
3. Click the **Move forward in workflow** button until **Published** is shown in the **Workflow stage** field in the **Details** tab.

> [!TIP]
> You can cancel publishing of the FAQ entry by clicking the **Move backward in workflow** button.

<!-- Referenced links -->
[1]: view-entry.md
[2]: publish.md

<!-- Referenced images -->
[img1]: ../../media/icons/btn-menu.png
[img2]: ../../../common/icons/gearblack.png
[img3]: ../../media/icons/btn-add.png
