---
uid: zapier-remove-project-member
title: Remove SuperOffice CRM project member
description: How to remove SuperOffice project member with Zapier
keywords: Remove project member, new Zap, Zapier remove action
author: miguellemos95
date: 10.31.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Remove SuperOffice CRM project member

> [!NOTE]
> To be able to create Zaps, you must connect a SuperOffice CRM account that has **General Administrator** user rights.

## Steps

1. On the page that lists all your Zaps, click **Create**. You will be taken to a new Zap creation window.

    ![Zapier: Create a new Zap -screenshot][img1]

1. Create your **Trigger** by clicking on it. It can be an action in Google Sheets or another action in external systems or a part of SuperOffice.

    ![Zapier: Create your trigger -screenshot][img2]

1. Click on **Action**. You will be taken to a window from which you can select the application you want to use. Search for and click on SuperOffice.

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Remove Project Member**, then click the **Account** section and log in using your SuperOffice account.

    ![Set up your action -screenshot][img4]

1. Click on the **Continue** button at the bottom of the side panel and you will be taken to the **Configure** step.

1. Click on the **Selection** field and select one of the available deletion criteria.

    ![Fill out your action -screenshot][img5]

1. If its selected **Project member id** option, fill out the mandatory field **Project member id**.

    ![Fill out your Project member id action -screenshot][img6]

1. If its selected **Project & member** option, fill out the mandatory field **Project** and **Member**.

    ![Fill out your Project & member action -screenshot][img7]

1. Check that the action works by clicking **Test step**.

1. If the above steps were configured correctly, the response should consist of **Project id**, **Title**, **Responsible id**, **Responsible**, **Description**, **Number**, **Web site**, **Type id**, **Type**, **Status id**, **Status**, **Completed**, **End date**, **Next milestone**, **Note**, **Created by**, **Created date**, **Updated by**, **Updated date**, **Project members**, **Self URL**.

    ![Zapier: Verify -screenshot][img8]

## Related content

* [Remove project member][1]
* [Create a Zap with SuperOffice CRM][2]

<!-- Referenced links -->
[1]: remove-project-member.md
[2]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img1]: ../../media/create-zap.png
[img2]: ../../media/new-zap-window.png
[img3]: ../../media/search-superoffice-in-zapier.png
[img4]: ../../media/remove/remove-project-member/remove-project-member-action.png
[img5]: ../../media/remove/remove-project-member/remove-project-member-selection-window.png
[img6]: ../../media/remove/remove-project-member/remove-by-project-member-id-window.png
[img7]: ../../media/remove/remove-project-member/remove-by-project-and-member-window.png
[img8]: ../../media/remove/remove-project-member/remove-project-member-output.png
