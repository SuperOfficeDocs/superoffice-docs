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

[!include[note](../includes/note.md)]

## Steps

[!include[create zap step](../includes/create-zap-intro.md)]

1. [!include[click trigger step](includes/click-trigger-step.md)]

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[click trigger step](includes/click-on-action-step.md)]

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Create Document**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your action -screenshot][img4]

1. [!include[go to conf step](includes/go-to-conf-step.md)]

1. Fill out the mandatory fields **Document**, **Template name** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. [!include[check action works step](includes/check-action-works-step.md)]

1. If the above steps were configured correctly, the response should consist of **Document id**, **Company id**, **Company name**, **Contact id**, **Contact name**, **Project id**, **Project name**, **Sale id**, **Sale title**, **Template id**, **Template name**, **Completed?**, **Date**, **Our ref.**, **Your ref.**, **Title/Subject**, **Description**, **Owner id**, **Owner**, **Filename**, **Created date**, **Created by**, **Updated date**, **Update by**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Update Document Action][1]
* [New Document Trigger][2]
* [Document Changed Trigger][3]
* [Create a Zap with SuperOffice CRM][4]

<!-- Referenced links -->
[1]: update-document-content.md
[2]: ../triggers/new-document.md
[3]: ../triggers/document-changed.md
[4]: ../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../media/new-zap-window.png
[img3]: ../media/search-superoffice-in-zapier.png
[img4]: ../media/create-document-action.png
[img5]: ../media/create-document-window.png
[img6]: ../media/create-document-output.png
