---
uid: help-en-webhook-create
title: Create webhook
description: Create a webhook in Settings and maintenance without writing code or calling the API.
keywords: create webhook, edit webhook, notification, event
author: digitaldiina
date: 06.16.2026
version: 12.1
content_type: howto
tier: core
category: automation
topic: webhook
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: en
---

# Create webhook

You can create and manage webhook subscriptions directly in **Settings and maintenance**, without writing code or calling the API.

> [!NOTE]
> To edit an existing webhook, right-click the webhook row in the **Webhooks** list and select **Edit**. The form opens with all current values pre-populated.

## Steps

1. Go to **Settings and maintenance** > **System design** and select the **Webhooks** tab.

1. Click **Add**.

    ![New webhook form in Settings and maintenance -screenshot][img1]

1. Enter a **Webhook name** to identify the webhook (required). Maximum 100 characters.

1. Optionally, add a **Description**. This is shown in the Webhooks panel.

1. **Add events that trigger this webhook** (required).

    Select one or more events from the **Add event** list. Each selected event appears as a tag. To remove an event, select **x** on its tag.

    > [!TIP]
    > You can also type a custom event name directly in the field and press **Enter**.

1. **Set the destination** (required).

    Choose where to deliver the webhook:

    * **External URL:** Enter the endpoint URL. The URL must use HTTPS and have a valid TLS certificate. The endpoint is validated when you save — an unreachable or error-returning URL will prevent saving. Select **Send test** to verify the connection before saving.
    * **CRMScript:** Select a script from the list.

1. **Configure error notification** (required).

    Specify who to alert, how to reach them, and when to send the notification.

    * **Recipients:** Add CRM users or type external email addresses. Recipients appear as tags.
    * **Notify via:** Select the notification channel.
    * **Trigger notification:** Select one or both options:
      * **On first failure:** Sends an alert the first time the webhook fails to deliver.
      * **When disabled:** Sends an alert if the webhook is automatically deactivated after repeated failures.

    ![Webhook form with events, destination, and error notification configured -screenshot][img2]

1. (Optional) Expand **Security and advanced settings**.

    * **Shared secret:** Select **Generate** to create a cryptographically random value for signing each payload. The secret is shown only at creation — copy it immediately. To replace it later, select **Regenerate**.
    * **Custom headers:** Key-value pairs appended to every HTTP POST. Available for external URL webhooks only.
    * **Custom properties:** Additional data injected into every payload.

    ![Security and advanced settings section expanded -screenshot][img3]

1. (Optional) Turn off the **Active** toggle (upper-right corner) to save the webhook in the *Stopped* state.

1. Click **Save**.

    ![Delivery status shown beneath the Active toggle after saving -screenshot][img4]

After saving, delivery status information appears beneath the **Active** toggle. Click **Back to Webhooks** at the top to return to the list.

## Related content

* [Webhooks panel][1]
* [Register a webhook via the API][2]
* [Create a CRMScript][3]

<!-- Referenced links -->
[1]: index.md
[2]: ../dev/register.md
[3]: ../../../customization/macros-and-scripts/admin/create-script.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/automation/new-webhook-required-fields.png
[img2]: ../../../../media/loc/en/automation/create-webhook-in-ui.png
[img3]: ../../../../media/loc/en/automation/webhook-advanced-settings.png
[img4]: ../../../../media/loc/en/automation/webhook-delivery-status.png
