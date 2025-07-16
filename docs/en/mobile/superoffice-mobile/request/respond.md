---
uid: help-en-request-respond
title: Respond to requests on your mobile device
description: In this how-to guide, you will learn how to reply to, forward, and comment on a request in Mobile CRM.
keywords: reply to request, answer request, respond to customer, reply, message, comment, forward, request, ticket,
author: Bergfrid Dias
date: 06.10.2025
version: 11.1
content_type: howto
platform: mobile
language: en
redirect_from:
  - /de/mobile/superoffice-mobile/reply-to-request
  - /da/mobile/superoffice-mobile/reply-to-request
  - /no/mobile/superoffice-mobile/reply-to-request
  - /sv/mobile/superoffice-mobile/reply-to-request
  - /nl/mobile/superoffice-mobile/reply-to-request
---

# Respond to requests on your mobile device

Response time is often a key metric for teams handling incoming requests.

> [!NOTE]
> A [Service user plan][6] is required to take action on a request.

## Accept

For a request to be your responsibility, your name must appear in the **Owner** field.

If the request is unassigned, self-assign it to prevent others from responding at the same time.

## <a id="reply"></a>Reply / reply all <i class="ph ph-arrow-bend-up-left" aria-hidden="true"></i>

A reply is an external message sent to the customer.

1. Tap **Reply** on the action bar.

    ![Mobile CRM: request header with action bar -app-screen][img4]

1. The customer's email address is prefilled in the **To** field. Optionally, add more recipients.

    ![Mobile CRM: reply screen -app-screen][img3]

1. Update request properties as needed (owner, status, category).

1. [Compose your message.](#message)

    > [!NOTE]
    > Your signature is automatically included if available. See [how to add a signature](#add-signature).

1. Tap **Send**.

## <a id="comment"></a>Add comment (internal)

Comments are internal messages used to collaborate before responding to the customer.

They are shown with a red background, are not visible to the customer, and are excluded when forwarding a request.

1. Tap **Comment** on the action bar.
1. Update request properties as needed.
1. Write your comment.
1. Tap **Save**.

![Mobile CRM: add comment screen -app-screen][img1]![Mobile CRM: request with internal comment -app-screen][img2]

## <a id="forward"></a>Forward <i class="ph ph-arrow-bend-up-right" aria-label="Forward"></i>

Use **Forward** when you need to share the request with someone outside the organization.

[Forwarding a request][1] compiles all external messages along with your own message into a single email.

1. Tap <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu icon"></i> and select **Forward**.
1. Add one or more recipients in the **To** field.
1. Update request properties as needed.
1. Compose your message.
1. Tap **Send**.

## <a id="call"></a>Call customer <i class="ph ph-phone" aria-hidden="true"></i>

Use the **Call** button to contact the customer directly from the request screen.

1. Tap **Call** in the action bar.

1. Select the number to dial.

1. Use the toggle to decide whether to log the call in SuperOffice.

    * When enabled, the call is logged as a phone activity under the request.

![Mobile CRM: call menu in request -app-screen][img5]

## <a id="message"></a>Working with messages

While composing a reply or comment, you can add images, insert a reply template, or include a link to a FAQ from the **Task** menu.

> [!TIP]
> To discard your draft, tap the **Task** icon and select **Remove text**.

When your message is finished (you might insert multiple items):

* For replies and forwards, tap **Send** to deliver the message.
* For internal comments, tap **Save** to store the comment.

### Add image

1. Tap <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu icon"></i> and select **Add image**.

1. Take a photo or select images from your gallery.
    * You can select multiple images at once.
    * If images do not appear, check the image permissions for SuperOffice on your device.

1. The images are added as attachments.
    * Maximum total size: 25 MB per message.

### Insert reply template

A [reply template][3] can help you respond faster with predefined content.

1. Tap <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu icon"></i> and select **Insert reply template**.
1. Search for a template and tap to select.
1. The template is inserted at the cursor. Edit as needed.

### Insert link to FAQ

[Frequently Asked Questions][4] help reduce response time for recurring issues.

1. Tap <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu icon"></i> and select **Insert link to FAQ**.
1. Search for and select a relevant FAQ.
    * The link is inserted at the cursor position in your message.

### Add signature

1. Go to **Settings** > **Email settings** > **Add signature**.
1. Tap to edit the signature line.
1. Tap **Save**.

## Related content

* [Update request][7]
* [Create reply template][2] (in SuperOffice CRM)
* [Create FAQ entry][5] (in SuperOffice CRM)

<!-- Referenced links -->
[1]: ../../../request/learn/forward.md
[2]: ../../../knowledge-base/learn/reply-templates/create.md
[3]: ../../../knowledge-base/learn/reply-templates/index.md
[4]: ../../../knowledge-base/learn/faq/index.md
[5]: ../../../knowledge-base/learn/faq/create.md
[6]: ../../../../en/admin/license/user-plans.md
[7]: update.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/mobile/request-add-comment.png
[img2]: ../../../../media/loc/en/mobile/request-with-comment.png
[img3]: ../../../../media/loc/en/mobile/reply-to-request.png
[img4]: ../../../../media/loc/en/mobile/request-header.png
[img5]: ../../../../media/loc/en/mobile/request-call-customer.png
