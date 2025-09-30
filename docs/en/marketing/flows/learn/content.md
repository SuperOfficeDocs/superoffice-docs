---
uid: help-en-flow-content
title: Flow content
description: Flow content
keywords: Marketing, flow, flow content, flow asset, content creation
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# Flow content

Flow content is emails (and forms) used in a flow.

It does not matter if you prepare the content first, or after designing the flow. Also, whether separate users work with content and flow configuration - or if the same user prepares it all - is up to you.

## Steps

To view the prepared content for a specific flow:

1. Go to **Marketing** > **Flows**.
1. Double-click to select a flow.
1. Select the **Flow contents** tab.

![Contents of Welcome email flow -screenshot][img1]

## Create new content

### Create email - as a flow editor

1. On the **Flow contents** tab, in the lower-left corner, enter a name for the new email and click **Create**. This opens the Mailing wizard at the **Template** step.

    ![Flow contents - create new email -screenshot][img3]

1. Choose a template and and click **Next**.

    ![Flow contents - choose template -screenshot][img4]

1. Compose the email (as you would a classic mailing).

    ![Flow contents - compose -screenshot][img5]

    * [Add content][3], [Edit a paragraph][4]
    * [Insert customer-specific information][5]
    * [Insert tracking link][6]
    * [Add subscription links][8] to be GDPR compliant
    * [Add images to the message][2]

    > [!NOTE]
    > If you want to act based on link clicks (for example, as a trigger, split, or wait condition), the link must be tracked.

1. Close the email step and click **Save**.

### Create email - as a flow administrator

1. Open the Flow editor and go to the email step.

    ![Flow step - create new email -screenshot][img6]

1. Choose a template and compose the email as described above (starting on step 2).

> [!NOTE]
> You cannot click **Edit** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) if the flow is running. If you do not wish to pause the flow while you prepare more content, you can create and prepare a new piece of content from the **Flow contents** tab.

### Create form

Go to **Marketing** > **Forms**. For details, see [Create form][1].

## Add flow content to email step

1. Open the Flow editor.
1. Click to select the email step where you wish to add content.
1. Choose **Select existing email for this step**. Click to select a prepared email.
1. Optionally, click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and select **Edit** in the email preview to update the content.
1. Close the email step and click **Save**.

![Send email step with content, subject, and attachment -screenshot][img2]

## Edit prepared content

> [!NOTE]
> You cannot edit flow content that is included in a step without pausing the flow.

**As a flow editor:**

1. On the **Flow contents** tab, click <i class="ph ph-list" aria-label="Task menu"></i> on the email you wish to update and select **Edit**.

**As a flow administrator:**

1. Open the Flow editor and go to the email step.
1. In the email preview:
    * Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **Edit** to modify the content.
    * Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **Rename** to change the email's name.
    * Click the red X to delete the email (so you can replace it with a different one).

<!-- Referenced links -->
[1]: ../../forms/learn/create.md
[2]: ../../editor/learn/insert-images-in-message.md
[3]: ../../editor/learn/add-content.md
[4]: ../../editor/learn/edit-paragraph.md
[5]: ../../editor/learn/add-merge-tag.md
[6]: ../../editor/learn/add-tracked-link-to-msg.md
[8]: ../../editor/learn/add-unsubscribe-link.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/view-flow-contents.png
[img2]: ../../../../media/loc/en/marketing/send-email-welcome-with-attachment.png
[img3]: ../../../../media/loc/en/marketing/create-new-email-in-flow.png
[img4]: ../../../../media/loc/en/marketing/choose-flow-email-template.png
[img5]: ../../../../media/loc/en/marketing/flow-email-content-compose.png
[img6]: ../../../../media/loc/en/marketing/flow-send-email-new.png
