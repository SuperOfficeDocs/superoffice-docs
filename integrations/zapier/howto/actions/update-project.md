---
uid: zapier-update-project-action
title: Set SuperOffice CRM Project update action
description: How to use SuperOffice update project action with Zapier
keywords: Update project, new Zap, Zapier update action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
redirect_from: /integrations/zapier/howto/update-project
---

# Update SuperOffice CRM Project action

## Steps

1. [!include[ALT](includes/initial-steps-new-action.md)]

1. Click on the **Action** step to set up app, event, and account:

    * In the **Action event** section, select **Update Project**

    ![Set up an action -screenshot][img4]

1. Click **Continue**.

1. Fill out the mandatory fields **Project ID**, **Title**, **Responsible**, **Type** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. Click **Test step** to check that the action works.

    If the above steps were configured correctly, the response should consist of **Project id**, **Title**, **Responsible id**, **Responsible**, **Description**, **Number**, **Web site**, **Type id**, **Type**, **Status id**, **Status**, **Completed**, **End date**, **Next milestone**, **Note**, **Created by**, **Created date**, **Updated by**, **Updated date**, **Project members**, **Self URL**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Find Project Action][1]
* [Create Project Action][2]
* [New Project Trigger][3]
* [Project Changed Trigger][4]
* [Create a SuperOffice CRM action - detailed steps][5]

<!-- Referenced links -->
[1]: search-project.md
[2]: create-project.md
[3]: ../triggers/new.md
[4]: ../triggers/changed.md
[5]: index.md

<!-- Referenced images -->
[img4]: media/update-project-action.png
[img5]: media/update-project-window.png
[img6]: media/update-project-output.png
