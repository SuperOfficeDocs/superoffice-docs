---
uid: zapier-create-request-message-action
title: Set SuperOffice CRM Request Message create action
description: How to use SuperOffice request message action with Zapier
keywords: Create request message, new Zap, Zapier create action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Create SuperOffice CRM Request Message action

[!include[note](../../includes/note.md)]

## Steps

[!include[create zap step](../../includes/create-zap-intro.md)]

1. [!include[click trigger step](../includes/click-trigger-step.md)]

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[click trigger step](../includes/click-on-action-step.md)]

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Create Request Message**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your action -screenshot][img4]

1. [!include[go to conf step](../includes/go-to-conf-step.md)]

1. Fill out the mandatory fields **Title**, **Responsible**, **Type** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. [!include[check action works step](../includes/check-action-works-step.md)]

1. If the above steps were configured correctly, the response should consist of **Request id**, **Message Id**, **Body**, **Created at**, **Created by id**, **Created by name**, **Author**, **Security level**, **Contact id**, **Contact name**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Create a Zap with SuperOffice CRM][1]

<!-- Referenced links -->
[1]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../../media/common/new-zap-window.png
[img3]: ../../media/common/search-superoffice-in-zapier.png
[img4]: ../../media/actions/create/create-request-message/create-request-message-action.png
[img5]: ../../media/actions/create/create-request-message/create-request-message-window.png
[img6]: ../../media/actions/create/create-request-message/create-request-message-output.png
