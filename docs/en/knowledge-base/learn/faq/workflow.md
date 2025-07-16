---
uid: help-en-faq-workflow
title: Workflow stages
description: Workflow stages
keywords: FAQ workflow
author: SuperOffice Product and Engineering
date: 06.29.2022
version: 10.5
content_type: howto
category: service
topic: faq
license: servicepremium
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: en
redirect_from: /en/faq/learn/workflow
---

# Workflow stages

In a new installation, the workflow contains two default stages: **Unpublished** and **Published**. It is possible to add additional stages between these two. For example, you can set up a workflow where an FAQ entry is sent to be proof-read, so that someone checks the entry and then publishes it, or sends it unpublished back for editing.

## Create new stage

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **FAQ**.
1. Click the **Workflow** button. This takes you to the **View workflow** screen.
1. Click the **New stage** button. This takes you to the **New stage** screen.
1. Enter a descriptive name for the stage in the **Name** field.
1. In the **Place new stage between** list, select where in the process you want to insert the new stage.
1. Click **OK**. This takes you to the **Edit stage** screen.
1. In the **Select user** list at the bottom of the screen, select the name of a user who is to have access to this stage in the workflow.
1. Select which access level the user should have. You can choose from the following options:
    * **Can move**: The user is permitted to change the workflow stage for entries (publish or cancel publishing).
    * **Can edit**: The user is permitted to edit FAQ entries.
    * **Full access**: The user has all rights in relation to the workflow.
1. Click **+** to add the user to the list under **User access**.
1. Repeat steps 7-9 to add more users.
1. Click **OK**. The stage is created and now available when you publish FAQ entries.

## Edit stage

You can both change the name of a stage and alter which users are to have access to it.

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **FAQ**.
1. Click the **Workflow** button.
1. Click the name of the stage. This takes you to the **Edit stage** screen.
1. Edit the name as required.
1. Change which users are to have access to the stage:
    * To add users, follow the procedure above.
    * To remove users, select the user(s) in question, click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **Remove access for selected users**.
1. Click **OK**. The changes are saved.

## Delete stage

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **FAQ**.
1. Click the **Workflow** button (<i class="ph ph-gear" aria-hidden="true"></i>).
1. Click the name of the stage. This takes you to the **Edit stage** screen.
1. Click **Delete**. If the stage is not associated with any FAQ entries, it is deleted immediately.

   > [!NOTE]
   > You cannot delete the default **Unpublished** and **Published** stages.

1. If it is linked to FAQ entries, select which stage in the workflow these FAQ entries should be moved to. Select the stage you want in the **Move to workflow** list.
1. Click **Delete**. The stage is deleted and associated FAQ entries are moved to the selected stage.

## Publish via workflow

1. [Open the FAQ entry][1].
1. To adjust anything before publishing, follow the procedure under [Publish FAQ entries][2].
1. Click the **Move forward in workflow** button until **Published** is shown in the **Workflow stage** field in the **Details** tab.

   > [!TIP]
   > You can cancel publishing of the FAQ entry by clicking the **Move backward in workflow** button.

<!-- Referenced links -->
[1]: index.md
[2]: publish.md
