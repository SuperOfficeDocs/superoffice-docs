---
uid: zapier-remove-project-member-action
title: Set SuperOffice CRM Project Member remove action
description: How to use SuperOffice remove project member action with Zapier
keywords: Remove project member, new Zap, Zapier remove action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Remove a SuperOffice CRM Project Member action

## Steps

1. [!include[ALT](includes/initial-steps-new-action.md)]

1. Click on the **Action** step to set up app, event, and account:

    * In the **Action event** section, select **Remove Project Member**

    ![Set up an action -screenshot][img4]

1. Click **Continue**.

1. Click on the **Selection** field and select one of the available deletion criteria.

    ![Fill out your action -screenshot][img5]

1. If its selected **Project member id** option, fill out the mandatory field **Project member id**.

    ![Fill out your Project member id action -screenshot][img6]

1. If its selected **Project & member** option, fill out the mandatory field **Project** and **Member**.

    ![Fill out your Project & member action -screenshot][img7]

1. Click **Test step** to check that the action works.

    If the above steps were configured correctly, the response should consist of **Project id**, **Title**, **Responsible id**, **Responsible**, **Description**, **Number**, **Web site**, **Type id**, **Type**, **Status id**, **Status**, **Completed**, **End date**, **Next milestone**, **Note**, **Created by**, **Created date**, **Updated by**, **Updated date**, **Project members**, **Self URL**.

    ![Zapier: Verify -screenshot][img8]

## Related content

* [Create Project Member Action][1]
* [New Project Member Trigger][2]
* [Project Member Changed Trigger][3]
* [Create a SuperOffice CRM action - detailed steps][4]

<!-- Referenced links -->
[1]: create-project-member.md
[2]: ../triggers/new.md
[3]: ../triggers/changed.md
[4]: index.md

<!-- Referenced images -->
[img4]: media/remove-project-member-action.png
[img5]: media/remove-project-member-selection-window.png
[img6]: media/remove-by-project-member-id-window.png
[img7]: media/remove-by-project-and-member-window.png
[img8]: media/remove-project-member-output.png
