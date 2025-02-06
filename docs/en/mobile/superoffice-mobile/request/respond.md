---
uid: help-en-request-respond
title: Respond to requests on your mobile device
description: In this how-to guide, you will learn how to reply to, forward, and comment on a request in Mobile CRM.
author: Bergfrid Dias
date: 08.03.2023
keywords: request, ticket, mobile, reply, message, comment
topic: howto
client: mobile
language: en
---

# Respond to requests on your mobile device

Time to respond is often a key metric for teams that handles incoming requests​.

You need a Service or complete license to take action on a request. For details, see the [list of user plans][6].

## Accept

For a request to be your responsibility, your name must appear in the request's Owner field.

If the request is unclaimed, self-assign to avoid others answering the request at the same time.

## <a id="reply"></a>Reply / reply all ![icon][img1]

A reply is an external message to the customer.

1. Select **Reply** (all) from the **Task** menu.
1. The email address of involved customers automatically appear in the **To** field. Optionally, add other recipients.
1. Update request properties as needed (owner, status, category).
1. Compose a message.

    > [!NOTE]
    > Your signature is automatically appended if available. [How to add signature](#add-signature)

1. Tap **Send**.

## <a id="comment"></a>Add comment (internal) ![icon][img3]

Comments are used to discuss the request internally before replying to the customer. They are shown on a red background, cannot be viewed by the customer, and are not included if you forward the request.

1. Select **Add comment** from the **Task** menu.
1. Update request properties as needed (owner, status, category).

    ![Mobile CRM: Add comment -app-screen][img5]

1. Compose a message.
1. Tap **Send**.

    ![Mobile CRM: Request with internal message -app-screen][img6]

## <a id="forward"></a>Forward ![icon][img4]

Sometimes, internal comments or reassigning the request is not enough to solve a problem, and you need to involve others.

[When you forward a request][1], the app combines all external messages on that request plus your own message into a single email.

1. Select **Forward** from the **Task** menu (when viewing the request).
1. Add one or more recipients in the **To** field.
1. Update request properties as needed (owner, status, category).
1. Compose a message.
1. Tap **Send**.

## <a id="message"></a>Working with messages

While composing a message, you can add images, insert a request reply template, and include a link to a FAQ - all from the **Task** menu.

> [!TIP]
> If you change your mind, simply tap the **Task** icon and select **Remove text** to empty the content in the message.

### Add image

1. Tap the **Task** icon.
2. Select **Add image**.
3. Take a photo with the camera or choose an image from the gallery.

    > [!NOTE]
    > You can select multiple images at once. If you do not see a particular image, check the image permissions for SuperOffice on your device.

4. Confirm and save your comment. The selected images are added as attachments.

    ![Add multiple images to a request -app-screen][img2]

### Insert reply template

A [reply template][3] provides the basis for a customized response to a customer and can save you time when responding.

1. Tap the **Task** icon.
2. Select **Insert reply template**.
3. Search for a template by name. Tap to select.
4. The selected template is inserted in the message at the cursor. Review the text and make adjustments to tailored it to the precise situation.
5. Continue working on the message. Tap **Save** when you are done.

### Insert link to FAQ

Many customer inquiries repeat over time, and [Frequently Asked Questions][4] (FAQs) are an important part of request handling.

1. Tap the **Task** icon.
2. Select **Insert link to FAQ**.
3. Search for and select a relevant FAQ page.
4. The link is inserted in the message at the cursor.

### Add signature

1. Tap the **Task** icon and select **Settings**.
1. Choose **Email settings** > **Add signature**.
1. Select the signature line to edit your signature.

## Related content

* [Update request][7]
* [Create reply template][2] (in SuperOffice CRM)
* [Create FAQ entry][5] (in SuperOffice CRM)

<!-- Referenced links -->
[1]: ../../../request/learn/forward.md
[2]: ../../../request/reply-templates/learn/create.md
[3]: ../../../request/reply-templates/learn/index.md
[4]: ../../../faq/learn/index.md
[5]: ../../../faq/learn/create.md
[6]: ../../../../en/admin/license/user-plans.md
[7]: update.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/mobile/request-reply.png
[img3]: ../../../../../common/icons/mobile/addcomment.png
[img4]: ../../../../../common/icons/forward-icon.png
[img2]: ../../../../../release-notes/mobile/media/save-request.png
[img5]: media/add-comment.png
[img6]: media/internal-message.png
