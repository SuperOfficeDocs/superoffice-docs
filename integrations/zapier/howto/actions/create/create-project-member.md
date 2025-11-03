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

> [!NOTE]
> To be able to create Zaps, you must connect a SuperOffice CRM account that has **General Administrator** user rights.

## Steps

1. On the page that lists all your Zaps, click **Create**. You will be taken to a new Zap creation window.

    ![Zapier: Create a new Zap -screenshot][img1]

1. Create your **Trigger** by clicking on it. It can be an action in Google Sheets or another action in external systems or a part of SuperOffice.

    ![Zapier: Create your trigger -screenshot][img2]

1. Click on **Action**. You will be taken to a window from which you can select the application you want to use. Search for and click on SuperOffice.

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Create Project Member**, then click the **Account** section and log in using your SuperOffice account.

    ![Set up your action -screenshot][img4]

1. Click on the **Continue** button at the bottom of the side panel and you will be taken to the **Configure** step.

1. Fill out the mandatory fields **Title**, **Responsible**, **Type** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. Check that the action works by clicking **Test step**.

1. If the above steps were configured correctly, the response should consist of **Project member id**, **Company id**, **Company**, **Project id**, **Project**, **Project member type id**, **Project member type**, **Contact id**, **Contact**, **Contact email**, **Comment**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Remove Project Member Action][1]
* [New Project Member Trigger][2]
* [Project Member Changed Trigger][3]
* [Create a Zap with SuperOffice CRM][4]

<!-- Referenced links -->
[1]: ../remove/remove-project-member.md
[2]: ../../triggers/new/new-project-member.md
[3]: ../../triggers/changed/project-member-changed.md
[4]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img1]: ../../media/common/create-zap.png
[img2]: ../../media/common/new-zap-window.png
[img3]: ../../media/common/search-superoffice-in-zapier.png
[img4]: ../../media/actions/create/create-project-member/create-project-member-action.png
[img5]: ../../media/actions/create/create-project-member/create-project-member-window.png
[img6]: ../../media/actions/create/create-project-member/create-project-member-output.png
