---
uid: zapier-create-project-action
title: Set SuperOffice CRM Project create action
description: How to use SuperOffice create project action with Zapier
keywords: Create project, new Zap, Zapier create action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Create SuperOffice CRM Project action

## Steps

1. [!include[ALT](includes/initial-steps-new-action.md)]

1. Click on the **Action** step to set up app, event, and account:

    * In the **Action event** section, select **Create Project**

    ![Set up an action -screenshot][img4]

1. Click **Continue**.

1. Fill out the mandatory fields **Title**, **Responsible**, **Type** and optionally other fields.

    ![Fill out an action -screenshot][img5]

1. Click **Test step** to check that the action works.

    If the above steps were configured correctly, the response should consist of **Project id**, **Title**, **Responsible id**, **Responsible**, **Description**, **Number**, **Web site**, **Type id**, **Type**, **Status id**, **Status**, **Completed**, **End date**, **Next milestone**, **Note**, **Created by**, **Created date**, **Updated by**, **Updated date**, **Project members**, **Self URL**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Update Project Action][1]
* [Find Project Action][2]
* [New Project Trigger][3]
* [Project Changed Trigger][4]
* [Create a SuperOffice CRM action - detailed steps][5]

<!-- Referenced links -->
[1]: search-project.md
[2]: update-project.md
[3]: ../triggers/new.md
[4]: ../triggers/changed.md
[5]: index.md

<!-- Referenced images -->
[img4]: media/create-project-action.png
[img5]: media/create-project-window.png
[img6]: media/create-project-output.png
