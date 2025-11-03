---
uid: zapier-create-document-action
title: Set SuperOffice CRM Document create action
description: How to use SuperOffice create document action with Zapier
keywords: Create document, new Zap, Zapier create action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Create a SuperOffice CRM document action

> [!NOTE]
> To be able to create Zaps, you must connect a SuperOffice CRM account that has **General Administrator** user rights.

## Steps

1. On the page that lists all your Zaps, click **Create**. You will be taken to a new Zap creation window.

    ![Zapier: Create a new Zap -screenshot][img1]

1. Create your **Trigger** by clicking on it. It can be an action in Google Sheets or another action in external systems or a part of SuperOffice.

    ![Zapier: Create your trigger -screenshot][img2]

1. Click on **Action**. You will be taken to a window from which you can select the application you want to use. Search for and click on SuperOffice.

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Create Document**, then click the **Account** section and log in using your SuperOffice account.

    ![Set up your action -screenshot][img4]

1. Click on the **Continue** button at the bottom of the side panel and you will be taken to the **Configure** step.

1. Fill out the mandatory fields **Document**, **Template name** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. Check that the action works by clicking **Test step**.

1. If the above steps were configured correctly, the response should consist of **Document id**, **Company id**, **Company name**, **Contact id**, **Contact name**, **Project id**, **Project name**, **Sale id**, **Sale title**, **Template id**, **Template name**, **Completed?**, **Date**, **Our ref.**, **Your ref.**, **Title/Subject**, **Description**, **Owner id**, **Owner**, **Filename**, **Created date**, **Created by**, **Updated date**, **Update by**.


    ![Zapier: Verify -screenshot][img6]

## Related content

* [Update Document Action][1]
* [New Document Trigger][2]
* [Document Changed Trigger][3]
* [Create a Zap with SuperOffice CRM][4]

<!-- Referenced links -->
[1]: ../update/update-document.md
[2]: ../../triggers/new/new-document.md
[3]: ../../triggers/changed/document-changed.md
[4]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img1]: ../../media/common/create-zap.png
[img2]: ../../media/common/new-zap-window.png
[img3]: ../../media/common/search-superoffice-in-zapier.png
[img4]: ../../media/actions/create/create-document/create-document-action.png
[img5]: ../../media/actions/create/create-document/create-document-window.png
[img6]: ../../media/actions/create/create-document/create-document-output.png
