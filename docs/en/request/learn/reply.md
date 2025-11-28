---
uid: help-en-request-reply
title: Reply to contact
description: In this guide you will learn how to reply to all incoming requests in SuperOffice.
keywords: reply to request, reply, reply all, add message, add comment, comment, internal, external
author: digitaldiina
date: 11.28.2025
version: 11.7
content_type: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: en
redirect_from:
  - /en/request/learn/howto/reply
  - /en/faq/learn/add-to-request
---

# Reply to contact

In request handling, your most important task is to respond to inquiries. Replies can be sent to a single request or multiple requests at once.

When you open a request and select **Reply**, the [email signature][7] you have set up will automatically appear and you can to add your message to the contact containing the answer to their question or the solution to their problem.

![Replying to a request -screenshot][img4]

> [!TIP]
> Set the *No. of expanded messages* preference (under <i class="ph ph-user-circle" aria-hidden="true"></i> **Personal settings** > **Preferences** > **Request**) to control how many messages are shown when viewing a request.

## Reply to a request

1. [Open the request][1].

1. Click <i class="ph ph-arrow-bend-up-left" aria-label="Reply"></i> or <i class="ph ph-arrow-bend-double-up-left" aria-label="Reply all"></i>.
    * Alternatively, click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **Reply** or **Reply all**.

1. The contact is automatically added as a recipient in the **To** field. You can add or remove recipients as needed.

1. [Type your message][2] in the **Message** tab.
    * Use [reply templates][8] to save time. If the template is available in multiple languages, you can select a language (<i class="ph ph-globe" aria-label="Languages"></i>).
    * Ensure **External** is selected in the **Access level** field if the contact should see the message.

    ![Replying to a request -screenshot][img3]

1. Click <i class="ph ph-paperclip" aria-label="Attachments"></i> to attach relevant documents.

1. Click **Save** to send the message.
    * If the **Anonymise users on reply** [global preference][11] is enabled, your name will be removed from outbound messages.

    ![First image: Message preview showing sender's name. Second image: Same message preview with the sender's name removed, indicating anonymization. -screenshot][img7]

## <a id="reply-templ"></a>Insert reply templates

You can save time by using [reply templates][8] as a starting point for your reply.

1. Place the cursor in the message field where you want to insert the template.
1. In the **Properties** panel, click <i class="ph ph-article" aria-label="Insert"></i> and select **Reply template**.
1. Choose a template from the list. Hover over it to preview before inserting.
1. Edit the text as needed and attach files if required.

![Insert template when replying to a request -screenshot][img1]

## <a id="faq"></a>Add FAQ entries

When you respond to a customer enquiry, you can save time by inserting a link to an [FAQ entry][9] in your reply.

1. Go to the **Message** tab.
1. Position the mouse pointer in the message where you want to insert the link.
1. In the **Properties** panel, click <i class="ph ph-article" aria-label="Insert"></i> and select what to insert in the message.

   > [!TIP]
   > In the **Add text** pop out, you can preview any of the FAQ items by moving your cursor over the different entries.

1. Click on the wanted FAQ entry.
1. A **link** is inserted at your cursor position. The customer can click it to show the relevant FAQ entry in the customer centre.

## <a id="insert-earlier-msg"></a>Insert earlier message

You can insert an earlier message into your current reply.

1. Open the request and place the cursor where you want to insert the message content.

1. In the right-side **Properties** panel, click <i class="ph ph-chats-circle" aria-label="Messages"></i>.

1. Select a message from the list.

    ![Message list in the Properties panel with a selected message ready to be inserted -screenshot][img5]

1. Click **Insert** to insert the message including attachments.

    * Alternatively, click the **chevron** next to **Insert** to choose one of the following:
        * **Insert with attachments:** Inserts the message content and any attached files.
        * **Insert without attachments:** Inserts only the message content.

    ![Insert button with options: Insert with attachments and Insert without attachments -screenshot][img6]

1. Edit the text as needed.

## Add a message to multiple requests

You can reply to several requests simultaneously, for example, if multiple inquiries relate to the same issue.

1. Select the requests you want to reply to:
    * Use a **saved selection** in the Selection screen.
    * Use the **Find requests** screen results.

1. Click the **Task** button and choose **Reply to customers**.

1. In the **Reply to customers** dialog:
    * **Send copy to customers (only external requests):** Check this box to send the message via email.
    * **Close request:** Check this box to close the requests after sending the message.
    * Add your message in the text area. Use [reply templates][8] to save time.

    The message you enter will be added to the selected requests and sent by email to the contacts linked to the selected external requests.

1. Click **Reply** to send the message.

## Add a comment

Comments allow you to add internal notes to a request without sending them to the customer. For example, to include what you have done or discovered so far.

1. [Open the request][1].
1. Click <i class="ph ph-chat-text" aria-hidden="Comment"></i> above the message thread.
1. Add your comment in the text field.
    * Select **Internal** in the toolbar to ensure the comment is visible only to your colleagues.
1. Click **Save**.

> [!TIP]
> Use comments to provide context when [transferring requests][10] to colleagues.

## <a id="time-spent"></a>Keep track of time

When you reply to a request, you can track the time spent on the response.

1. In the toolbar at the bottom of the **Message** tab, check the timer:
    * Click <i class="ph ph-play" aria-label="Play"></i> to start tracking time.
    * Click <i class="ph ph-pause" aria-label="Pause"></i> to stop the timer.
1. Edit the time manually if needed.
1. Save the request to log the time spent.

Time spent is displayed in each message header, and the time to reply is available in the **Change log** tab.

## Related content

* [Forward request][10]
* [Close request][3]
* [Keep track of messages][4]
* [Create reply template][8]
* [Create new language version of reply template][5]
* [Edit email signature][7]

<!-- Referenced links -->
[1]: index.md#open
[2]: create.md#fields
[3]: close.md
[4]: flag-message.md
[5]: ../../knowledge-base/learn/reply-templates/new-language.md
[7]: ../../learn/getting-started/edit-email-signature.md
[8]: ../../knowledge-base/learn/reply-templates/index.md
[9]: ../../knowledge-base/learn/faq/index.md
[10]: forward.md
[11]: ../../admin/preferences/service-settings.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/insert-reply-template.png
[img3]: ../../../media/loc/en/request/message-to-external.png
[img4]: ../../../media/loc/en/request/reply-to-a-customer.png
[img5]: ../../../media/loc/en/request/insert-earlier-message.png
[img6]: ../../../media/loc/en/request/insert-message-with-attachments.png
[img7]: ../../../media/loc/en/request/request-reply-anonymise-user.png
