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

[!include[note](../../includes/note.md)]

## Steps

[!include[create zap step](../../includes/create-zap-intro.md)]

1. [!include[click trigger step](../includes/click-trigger-step.md)]

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[click trigger step](../includes/click-on-action-step.md)]

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Find request**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your action -screenshot][img4]

1. [!include[go to conf step](../includes/go-to-conf-step.md)]

    ![Fill out your action -screenshot][img5]

1. Choose your **Search Criteria** from the available options.

    ![Choose your search criteria -screenshot][img6]

1. Set your **Search Value**.

    ![Set your search value -screenshot][img7]

1. [!include[check action works step](../includes/check-action-works-step.md)]

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
[img2]: ../../media/new-zap-window.png
[img3]: ../../media/search-superoffice-in-zapier.png
[img4]: ../../media/search-request-action.png
[img5]: ../../media/search-request-window.png
[img6]: ../../media/search-criteria-request-window.png
[img7]: ../../media/search-value-request-window.png
[img8]: ../../media/search-request-output.png
