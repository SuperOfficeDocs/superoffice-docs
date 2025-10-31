---
uid: zapier-create-request
title: Create SuperOffice CRM request
description: How to create SuperOffice request with Zapier
keywords: Create request, new Zap, Zapier update action
author: miguellemos95
date: 10.31.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Create SuperOffice CRM request

> [!NOTE]
> To be able to create Zaps, you must connect a SuperOffice CRM account that has **General Administrator** user rights.

## Steps

1. On the page that lists all your Zaps, click **Create**. You will be taken to a new Zap creation window.

    ![Zapier: Create a new Zap -screenshot][img1]

1. Create your **Trigger** by clicking on it. It can be an action in Google Sheets or another action in external systems or a part of SuperOffice.

    ![Zapier: Create your trigger -screenshot][img2]

1. Click on **Action**. You will be taken to a window from which you can select the application you want to use. Search for and click on SuperOffice.

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Create Request**, then click the **Account** section and log in using your SuperOffice account.

    ![Set up your action -screenshot][img4]

1. Click on the **Continue** button at the bottom of the side panel and you will be taken to the **Configure** step.

1. Fill out the mandatory fields **Title**, **Responsible**, **Type** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. Check that the action works by clicking **Test step**.

1. If the above steps were configured correctly, the response should consist of **Request id**, **Title**, **Author**, **Contact id**, **Contact name**, **Company id**, **Company name**, **Owner id**, **Owner**, **Category id**, **Category**, **Priority id**, **Priority**, **Status**, **Access level for request**, **Origin**, **Created by id**, **Created by**, **Replied at**, **Closed at**, **Deadline**, **Self URL**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Create request][1]
* [Create a Zap with SuperOffice CRM][2]

<!-- Referenced links -->
[1]: create-request.md
[2]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img1]: ../../media/create-zap.png
[img2]: ../../media/new-zap-window.png
[img3]: ../../media/search-superoffice-in-zapier.png
[img4]: ../../media/create/create-request/create-request-action.png
[img5]: ../../media/create/create-request/create-request-window.png
[img6]: ../../media/create/create-request/create-request-output.png
