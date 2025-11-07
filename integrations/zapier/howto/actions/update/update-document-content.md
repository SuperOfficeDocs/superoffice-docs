---
uid: zapier-update-document-content-action
title: Set SuperOffice CRM Document Content update action
description: How to use SuperOffice update document content action with Zapier
keywords: Update document content, new Zap, Zapier update action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Update a SuperOffice CRM Document Content action

[!include[note](../../includes/note.md)]

## Steps

[!include[create zap step](../../includes/create-zap-intro.md)]

1. [!include[click trigger step](../includes/click-trigger-step.md)]

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[click trigger step](../includes/click-on-action-step.md)]

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Update Document Content**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your action -screenshot][img4]

1. [!include[go to conf step](../includes/go-to-conf-step.md)]

1. Fill out the mandatory fields **Document id** and **Document**.

    ![Fill out your action -screenshot][img5]

1. [!include[check action works step](../includes/check-action-works-step.md)]

1. If the above steps were configured correctly, the response should consist of **Document id**, **Company id**, **Company name**, **Contact id**, **Contact name**, **Project id**, **Project name**, **Sale id**, **Sale title**, **Template id**, **Template name**, **Completed?**, **Date**, **Our ref.**, **Your ref.**, **Title/Subject**, **Description**, **Owner id**, **Owner**, **Filename**, **Created date**, **Created by**, **Updated date**, **Update by**, **File**

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Create a Zap with SuperOffice CRM][1]

<!-- Referenced links -->
[1]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../../media/new-zap-window.png
[img3]: ../../media/search-superoffice-in-zapier.png
[img4]: ../../media/update-document-content-action.png
[img5]: ../../media/update-document-content-window.png
[img6]: ../../media/update-document-content-output.png
