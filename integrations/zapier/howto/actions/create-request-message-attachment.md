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

## Steps

1. [!include[ALT](includes/initial-steps-new-action.md)]

1. Click on the **Action** step to set up app, event, and account:

    * In the **Action event** section, select **Create Request Message Attachment**

    ![Set up an action -screenshot][img4]

1. **Important** to note that this step must be performed **after** the **Create Request Message Action**.

    ![Set up your action -screenshot][img5]

1. Click **Continue**.

1. The value set for **Request Message Id** should be the **Message Id** from previous **Create Request Message Action** step.

    ![Set up your Message Id -screenshot][img6]

1. Fill out the mandatory fields **Request Message ID**, **Attachment** and optionally other fields.

    ![Fill out your action -screenshot][img7]

1. Click **Test step** to check that the action works.

    If the above steps were configured correctly, the response should consist of **Attachment ID** and **Attachment Name**.

    ![Zapier: Verify -screenshot][img8]

## Related content

* [Create a SuperOffice CRM action - detailed steps][1]

<!-- Referenced links -->
[1]: index.md

<!-- Referenced images -->
[img4]: media/create-request-message-attachment-action.png
[img5]: media/create-request-message-attachment-step-flow.png
[img6]: media/create-request-message-attachment-fetch-id.png
[img7]: media/create-request-message-attachment-window.png
[img8]: media/create-request-message-attachment-output.png
