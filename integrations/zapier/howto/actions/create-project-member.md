---
uid: zapier-create-project-member-action
title: Create SuperOffice CRM Project Member
description: How to create SuperOffice project member with Zapier
keywords: Create project member, new Zap, Zapier create action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Create a SuperOffice CRM Project Member action

## Steps

1. [!include[ALT](includes/initial-steps-new-action.md)]

1. Click on the **Action** step to set up app, event, and account:

    * In the **Action event** section, select **Create Project Member**

    ![Set up an action -screenshot][img4]

1. Click **Continue**.

1. Fill out the mandatory fields **Title**, **Responsible**, **Type** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. Click **Test step** to check that the action works.

    If the above steps were configured correctly, the response should consist of **Project member id**, **Company id**, **Company**, **Project id**, **Project**, **Project member type id**, **Project member type**, **Contact id**, **Contact**, **Contact email**, **Comment**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Remove Project Member Action][1]
* [New Project Member Trigger][2]
* [Project Member Changed Trigger][3]
* [Create a SuperOffice CRM action - detailed steps][4]

<!-- Referenced links -->
[1]: remove-project-member.md
[2]: ../triggers/new.md
[3]: ../triggers/changed.md
[4]: index.md

<!-- Referenced images -->
[img4]: media/create-project-member-action.png
[img5]: media/create-project-member-window.png
[img6]: media/create-project-member-output.png
