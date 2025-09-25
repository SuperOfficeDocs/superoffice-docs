---
uid: help-en-chat-respond
title: Respond to a chat
description: When a customer sends a query via the chat widget on the website, it is not only important to respond to it, but also to register it on their Contact card.
keywords: respond to chat, next chat in queue, incoming chat, presence, quick reply
author: Bergfrid Dias
date: 09.25.2025
version: 10.5
content_type: howto
license: cep
category: Service
topic: chat
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from: 
  - /en/chat/learn/send-files
  - /en/chat/learn/send-faq-or-reply-template
  - /en/chat/learn/create-quick-reply.md
---

# Respond to a chat

Incoming chats are indicated in the following ways:

* A number icon on the **Dashboard** tab shows how many incoming chats have not been answered by an agent.
* In the **Incoming chat** list in the **Dashboard** tab. Double-click a row to respond to a chat.
* In the **Chats** tab, the **In queue** field shows how many chats are waiting for a response.
* A warning appears if a chat is not answered within a specified amount of time. This warning is shown only if your status is **Present**.

To make sure that you offer quick and professional answers to your customers' chat queries, SuperOffice Chat offers a number of options to speed up and improve your chat replies.

Save time by using pre-defined texts when answering customer queries through chat. You can create and send a quick reply to a commonly asked question. In other situations, where quick replies aren't sufficient, you can include FAQs, customized reply templates, or files.

## Setting your status (Present/Away)

Set your presence in the upper-right corner of the **Chat** screen.

![icon][img3]

* **Present:** You receive warnings for unanswered chats.
* **Away:** You do not receive warnings but can still respond to chats. If all agents are away, customers see the offline form when they start a chat.

## Steps

1. Click **Chat** in the Navigator.

1. Ensure your status in the upper-right corner is set to **Present**.

1. Click **Get next in queue** to claim the next unanswered chat.

    To respond to a specific customer, go to the **Dashboard** tab, find the chat in the **Incoming chat** list, and double-click the row.

1. In the message field, type your response and press **ENTER** or click **Send** to chat.

    * To personalize your response, try to [locate the customer in SuperOffice][1]. This lets you view relevant information in the side panel.
    * To add emojis or stickers, click <i class="ph ph-smiley" aria-label="Smiley"></i> next to the text field.

1. To send additional information during the chat:
    * [Insert an FAQ, a reply template, or quick reply](#insert)
    * [Send a file](#attach)

1. If you are unable to help the customer, do one of the following:
    * [Transfer the chat][2] to another agent.
    * [Create a request][3] from the chat.

1. When the conversation is over, click <i class="ph ph-list" aria-label="Task menu"></i> and select **End chat**, unless the customer closes the chat window first.
    The chat is moved to **Recent chat sessions**, and a record is also saved in the **Activities** section tab in SuperOffice CRM.

> [!NOTE]
> If the post-chat form is active for this chat channel, the customer may return to the chat. The chat will be reactivated.

## <a id="insert"></a>Insert FAQs, reply templates, or quick replies

To save time, insert predefined text instead of typing full replies.

1. Click <i class="ph ph-article" aria-label="Insert"></i> in the chat panel.
1. Select one of the following:
    * **FAQ:** Inserts a link to a published FAQ in the customer centre.
    * **Reply templates:** Inserts reusable message content.
    * **Quick replies:** Inserts a personal text snippet.

    You can search, browse folders, or use the icons for history and favorites.

1. Press **ENTER** or click **Send** to send the message.

### Create a new quick reply

1. In the **Quick replies** dialog, click <i class="ph ph-pencil-simple" aria-label="Edit"></i>.
1. Click **Add**. A new entry is added to the list.
1. In the **New name** field, enter a title for the quick reply. This is not visible to the customer.
1. In the **New content** field, enter the reply text.
1. Click **Save**. The reply is added to your personal list and can be used during chats.

![From the button for add predefined text, you can choose text from FAQ, Reply templates and Quick replies -screenshot][img6]

## <a id="attach"></a>Send files in chat

You can send documents or files during a chat session.

1. Click <i class="ph ph-paperclip" aria-label="Attachments"></i> in the chat panel.
1. Choose one of the following:
    * Click **Select a CRM document**, search, and select a file from SuperOffice.
    * Click **Upload files**, select the file, and click **Open**.
    * Drag and drop a file directly onto the upload area. Ensure **→Move** appears next to your pointer when you drop the file.

The file is sent immediately.

## Related content

* [Using the chat function from the customer's perspective][6]
* [Create or upload a document][7]

<!-- Referenced links -->
[1]: link-to-person.md
[2]: transfer-to-agent.md
[3]: create-request.md
[6]: as-customer.md
[7]: ../../document/learn/create.md

<!-- Referenced images -->
[img3]: ../../../media/loc/en/chat/chat-status-present.png
[img6]: ../../../media/loc/en/chat/chat-quickreply.png
