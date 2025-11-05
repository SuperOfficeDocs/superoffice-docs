---
uid: zapier-create-request-message-attachment-action
title: Set SuperOffice CRM Request Message Attachment create action 
description: How to use SuperOffice create request message attachment action with Zapier
keywords: Create request message attachment, new Zap, Zapier create action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Create a SuperOffice CRM Request Message Attachment action

[!include[note](../../includes/note.md)]

## Steps

[!include[create zap step](../../includes/create-zap-intro.md)]

1. [!include[click trigger step](../includes/click-trigger-step.md)]

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[click trigger step](../includes/click-on-action-step.md)]

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Create Request Message Attachment**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your action -screenshot][img4]
    
1. **Important** to note that this step must be performed **after** the **Create Request Message Action**.

    ![Set up your action -screenshot][img5]

1. [!include[go to conf step](../includes/go-to-conf-step.md)]

1. The value set for **Request Message Id** should be the **Message Id** from previous **Create Request Message Action** step.

    ![Set up your Message Id -screenshot][img6]

1. Fill out the mandatory fields **Request Message ID**, **Attachment** and optionally other fields.

    ![Fill out your action -screenshot][img7]

1. [!include[check action works step](../includes/check-action-works-step.md)]

1. If the above steps were configured correctly, the response should consist of **Attachment ID** and **Attachment Name**.

    ![Zapier: Verify -screenshot][img8]

## Related content

* [Create a Zap with SuperOffice CRM][1]

<!-- Referenced links -->
[1]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../../media/common/new-zap-window.png
[img3]: ../../media/common/search-superoffice-in-zapier.png
[img4]: ../../media/actions/create/create-request-message-attachment/create-request-message-attachment-action.png
[img5]: ../../media/actions/create/create-request-message-attachment/create-request-message-attachment-step-flow.png
[img6]: ../../media/actions/create/create-request-message-attachment/create-request-message-attachment-fetch-id.png
[img7]: ../../media/actions/create/create-request-message-attachment/create-request-message-attachment-window.png
[img8]: ../../media/actions/create/create-request-message-attachment/create-request-message-attachment-output.png
