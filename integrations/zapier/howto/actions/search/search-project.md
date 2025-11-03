---
uid: zapier-find-project-action
title: Find SuperOffice CRM Project action
description: How to use SuperOffice find project action with Zapier
keywords: Find project, new Zap, Zapier find action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Find a SuperOffice CRM Project action

> [!NOTE]
> To be able to create Zaps, you must connect a SuperOffice CRM account that has **General Administrator** user rights.

## Steps

1. On the page that lists all your Zaps, click **Create**. You will be taken to a new Zap creation window.

    ![Zapier: Create a new Zap -screenshot][img1]

1. Create your **Trigger** by clicking on it. It can be an action in Google Sheets or another action in external systems or a part of SuperOffice.

    ![Zapier: Create your trigger -screenshot][img2]

1. Click on **Action**. You will be taken to a window from which you can select the application you want to use. Search for and click on SuperOffice.

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Find project**, then click the **Account** section and log in using your SuperOffice account.

    ![Set up your action -screenshot][img4]

1. Click on the **Continue** button at the bottom of the side panel and you will be taken to the **Configure** step.

    ![Fill out your action -screenshot][img5]

1. Choose your **Search Criteria** from the available options.

    ![Choose your search criteria -screenshot][img6]
    
1. Set your **Search Value**.

    ![Set your search value -screenshot][img7]

1. Check that the action works by clicking **Test step**.

1. If the above steps were configured correctly, the response should consist of **Project id**, **Title**, **Responsible id**, **Responsible**, **Description**, **Number**, **Web site**, **Type id**, **Type**, **Status id**, **Status**, **Completed**, **End date**, **Next milestone**, **Note**, **Created by**, **Created date**, **Updated by**, **Updated date**, **Project members**, **Self URL**, **Zap Search Was Found Status**.

    ![Zapier: Verify -screenshot][img8]

## Related content

* [Create Project Action][1]
* [Update Project Action][2]
* [New Project Trigger][3]
* [Project Changed Trigger][4]
* [Create a Zap with SuperOffice CRM][5]

<!-- Referenced links -->
[1]: ../create/create-project.md
[2]: ../update/update-project.md
[3]: ../../triggers/new/new-project.md
[4]: ../../triggers/changed/project-changed.md
[5]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img1]: ../../media/common/create-zap.png
[img2]: ../../media/common/new-zap-window.png
[img3]: ../../media/common/search-superoffice-in-zapier.png
[img4]: ../../media/actions/search/search-project/search-project-action.png
[img5]: ../../media/actions/search/search-project/search-project-window.png
[img6]: ../../media/actions/search/search-project/search-criteria-project-window.png
[img7]: ../../media/actions/search/search-project/search-value-project-window.png
[img8]: ../../media/actions/search/search-project/search-project-output.png
