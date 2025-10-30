---
uid: zapier-update-document-content
title: Update SuperOffice CRM document content
description: How to update SuperOffice document content with Zapier
keywords: Update document content, new Zap, Zapier update action
author: miguellemos95
date: 10.16.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Update SuperOffice CRM document content

> [!NOTE]
> To be able to create Zaps, you must connect a SuperOffice CRM account that has **General Administrator** user rights.

## Steps

1. On the page that lists all your Zaps, click **Create**. You will be taken to a new Zap creation window.

    ![Zapier: Create a new Zap -screenshot][img1]

1. Create your **Trigger** by clicking on it. It can be an action in Google Sheets or another action in external systems or a part of SuperOffice.

    ![Zapier: Create your trigger -screenshot][img2]

1. Click on **Action**. You will be taken to a window from which you can select the application you want to use. Search for and click on SuperOffice.

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Update Document Content**, then click the **Account** section and log in using your SuperOffice account.

    ![Set up your action -screenshot][img4]

1. Click on the **Continue** button at the bottom of the side panel and you will be taken to the **Configure** step.

1. Fill out the mandatory fields **Document id** and **Document**.

    ![Fill out your action -screenshot][img5]

1. Check that the action works by clicking **Test step**.

1. If the above steps were configured correctly, the response should consist of **Document id**, **Company id**, **Company name**, **Contact id**, **Contact name**, **Project id**, **Project name**, **Sale id**, **Sale title**, **Template id**, **Template name**, **Completed?**, **Date**, **Our ref.**, **Your ref.**, **Title/Subject**, **Description**, **Owner id**, **Owner**, **Filename**, **Created date**, **Created by**, **Updated date**, **Update by**, **File**


    ![Zapier: Verify -screenshot][img6]

## Related content

* [Update document content][1]
* [Create a Zap with SuperOffice CRM][2]

<!-- Referenced links -->
[1]: update-document-content.md
[2]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img1]: ../../media/create-zap.png
[img2]: ../../media/new-zap-window.png
[img3]: ../../media/search-superoffice-in-zapier.png
[img4]: ../../media/update-document-content/update-document-content-action.png
[img5]: ../../media/update-document-content/update-document-content-window.png
[img6]: ../../media/update-document-content/update-document-content-output.png
