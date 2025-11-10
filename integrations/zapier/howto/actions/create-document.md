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

## Steps

1. [!include[ALT](includes/initial-steps-new-action.md)]

1. Click on the **Action** step to set up app, event, and account:

    * In the **Action event** section, select **Create Document**

    ![Set up an action -screenshot][img4]

1. Click **Continue**.

1. Fill out the mandatory fields **Document**, **Template name** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. Click **Test step** to check that the action works.

    If the above steps were configured correctly, the response should consist of **Document id**, **Company id**, **Company name**, **Contact id**, **Contact name**, **Project id**, **Project name**, **Sale id**, **Sale title**, **Template id**, **Template name**, **Completed?**, **Date**, **Our ref.**, **Your ref.**, **Title/Subject**, **Description**, **Owner id**, **Owner**, **Filename**, **Created date**, **Created by**, **Updated date**, **Update by**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Update Document Action][1]
* [New Document Trigger][2]
* [Document Changed Trigger][3]
* [Create a SuperOffice CRM action - detailed steps][4]

<!-- Referenced links -->
[1]: update-document-content.md
[2]: ../triggers/new.md
[3]: ../triggers/changed.md
[4]: index.md

<!-- Referenced images -->
[img4]: media/create-document-action.png
[img5]: media/create-document-window.png
[img6]: media/create-document-output.png
