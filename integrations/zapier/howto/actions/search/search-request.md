---
uid: zapier-find-request-action
title: Find SuperOffice CRM Request action
description: How to use SuperOffice find request action with Zapier
keywords: Find request, new Zap, Zapier find action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Find a SuperOffice CRM Request action

> [!NOTE]
> To be able to create Zaps, you must connect a SuperOffice CRM account that has **General Administrator** user rights.

## Steps

1. On the page that lists all your Zaps, click **Create**. You will be taken to a new Zap creation window.

    ![Zapier: Create a new Zap -screenshot][img1]

1. Create your **Trigger** by clicking on it. It can be an action in Google Sheets or another action in external systems or a part of SuperOffice.

    ![Zapier: Create your trigger -screenshot][img2]

1. Click on **Action**. You will be taken to a window from which you can select the application you want to use. Search for and click on SuperOffice.

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Find request**, then click the **Account** section and log in using your SuperOffice account.

    ![Set up your action -screenshot][img4]

1. Click on the **Continue** button at the bottom of the side panel and you will be taken to the **Configure** step.

    ![Fill out your action -screenshot][img5]

1. Choose your **Search Criteria** from the available options.

    ![Choose your search criteria -screenshot][img6]
    
1. Set your **Search Value**.

    ![Set your search value -screenshot][img7]

1. Check that the action works by clicking **Test step**.

1. If the above steps were configured correctly, the response should consist of **Request id**, **Title**, **Author**, **Contact id**, **Company name**, **Owner id**, **Owner**, **Category id**, **Category**, **Priority id**, **Priority**, **Status**, **Access level for request**, **Origin**, **Created by id**, **Created by**, **Replied at**, **Closed at**, **Deadline**, **Self URL**

    ![Zapier: Verify -screenshot][img8]

## Related content

* [Create Request Action][1]
* [Update Request Action][2]
* [New Request Trigger][3]
* [Create a Zap with SuperOffice CRM][4]

<!-- Referenced links -->
[1]: ../create/create-request.md
[2]: ../update/update-request.md
[3]: ../../triggers/new/new-request.md
[4]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img1]: ../../media/common/create-zap.png
[img2]: ../../media/common/new-zap-window.png
[img3]: ../../media/common/search-superoffice-in-zapier.png
[img4]: ../../media/actions/search/search-request/search-request-action.png
[img5]: ../../media/actions/search/search-request/search-request-window.png
[img6]: ../../media/actions/search/search-request/search-criteria-request-window.png
[img7]: ../../media/actions/search/search-request/search-value-request-window.png
[img8]: ../../media/actions/search/search-request/search-request-output.png
