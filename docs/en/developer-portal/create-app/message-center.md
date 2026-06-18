---
uid: messaging-center
title: Messaging Center
description: Read, filter, and reply to support tickets in the SuperOffice Developer Portal Messaging Center.
keywords: Developer Portal, Messaging Center, support tickets, reply, attachments, mark as answered, return to SuperOffice
author: Anthony Yates, Bergfrid Dias
date: 06.16.2026
version_devportal: 2.14
content_type: concept
platform: web
deployment: online
language: en
---

# Messaging Center

The Messaging Center is the single place in the Developer Portal where you handle support tickets from customers of your apps and follow up on requests related to publishing. From version 2.14, you can read, filter, and reply to tickets — including with attachments — without leaving the portal, and decide whether to close each ticket yourself or hand it back to SuperOffice.

It collects messages from:

* **Request to publish** events for:
  * Application configuration
  * App Store information
  * Partner page information
* Feedback submitted from the App Store **Report a problem** link.
* Support tickets created from the **Failures** details page.
* Your emails sent to `appdev@superoffice.com` or `appstore@superoffice.com`.

  > [!CAUTION]
  > Problems may occur if you use a different email address than the one you sign in to the Developer Portal with, or if the address is a duplicate in SuperOffice.

* Notifications about Developer Portal changes.

> [!NOTE]
> The Messaging Center is not a support channel. For support, contact [SuperOffice Support][1].

## At a glance

The Messaging Center is located in the upper-right corner of the Developer Portal.

![Messaging Center icon -screenshot][img1]

Tickets are grouped into categories in the sidebar so you can see at a glance what needs attention. The count next to each category shows how many tickets it currently contains.

| Category | What it shows |
|---|---|
| **All** | Every ticket associated with you and your apps. |
| **Open** | Tickets where the next action is yours. |
| **Waiting for SuperOffice** | Tickets you have replied to and routed back to SuperOffice. |
| **Closed** | Tickets that have been resolved. |

![Messaging Center inbox with sidebar categories -screenshot][img2]

> [!TIP]
> The [Messaging Center widget][3] on your Home dashboard mirrors these same categories *(new in 2.14)*, so you can spot tickets in the **Open** category at a glance without opening the Messaging Center.

## Filter and find tickets

When the list grows long, narrow it down to what matters. Filters are applied on the server, so paging stays fast even with many tickets:

* **Application** — limit the list to tickets for one of your apps.
* **Partner** — useful if you belong to more than one partner.
* **Status** — combine with the above to focus on, for example, every ticket awaiting your response.

The list is paginated. Use the controls at the bottom of the list to move between pages.

![Filter bar above the ticket list -screenshot][img3]

## Reply to a ticket

Open a ticket to see its full history. You can compose a reply in two places, and the difference is *who gets the reply by default*:

* **Reply All**, at the top of the ticket — pre-fills the editor with the ticket's full recipient list (everyone currently on the conversation).
* **Reply**, at the bottom of an individual message — pre-fills the editor with only the recipients of that specific message. Useful when you want to respond to one branch of a long conversation without including everyone.

In both cases, the recipients are only a starting point. You can adjust the **To**, **Cc**, and **Bcc** fields freely before sending, and the chip behavior is the same in both editors.

1. Click **Reply All** at the top of the ticket, or **Reply** at the bottom of an individual message.
2. (Optional) Expand **Cc** or **Bcc** to add more recipients, or click the X on a chip to drop someone from the reply.
3. Compose your message using the rich-text editor.
4. (Optional) [Add an attachment](#add-an-attachment).
5. Decide what happens to the ticket after you send — see [Mark as answered or Return to SuperOffice](#mark-as-answered-or-return-to-superoffice).
6. Click **Send**.

![Conversation view with Reply All at the top and per-message Reply on each card -screenshot][img4]

### To, Cc, and Bcc addresses

The **To**, **Cc**, and **Bcc** fields accept multiple email addresses, shown as chips:

* Type an address and press **Enter**, or simply click outside the field, to confirm it. When you click **Send**, any address you typed but did not confirm is added automatically — addresses are no longer dropped silently.
* Invalid addresses appear as a red chip. **Send** is disabled until you remove or correct them.

### Add an attachment

You can attach **image files only**, up to **5 MB per file**. Add images one at a time — there is no overall cap on the number of attachments, only the per-file size limit.

To send an image with your reply:

1. Click the attachment icon in the reply editor.
2. Select an image from your computer.
3. The portal validates the file before adding it:

    * If it is not an image, the file is rejected with the message *Only image files are allowed as attachments.*
    * If it is larger than 5 MB, the file is rejected with the message *Attachment exceeds the maximum allowed size of 5 MB.*

4. Repeat to add more images if you need to.
5. Send the reply as usual.

![Attachment picker showing the image-only validation message -screenshot][img5]

### Mark as answered or Return to SuperOffice

Next to the **Send** button there is a toggle that decides what happens to the ticket *after* your reply goes out.

By default, the toggle is set to **Mark as answered**:

![Send toggle set to Mark as answered (default) -screenshot][img6]

Switch it to **Return to SuperOffice** to hand the ticket back. Note that **Send** is disabled until you add at least one recipient:

![Send toggle set to Return to SuperOffice, Send disabled without recipients -screenshot][img7]

| Option | When to use it | What happens to the ticket |
|---|---|---|
| **Mark as answered** *(default)* | You have resolved the customer's question yourself. | The ticket is closed on the partner side and moves to the **Closed** category. You can still open it later from there. |
| **Return to SuperOffice** | You need SuperOffice to take it from here, or the request is outside the partner's scope. | Responsibility for the ticket moves back to SuperOffice. For **app support** tickets the ticket also leaves your Messaging Center entirely — it no longer belongs to the partner. The reply is still emailed to everyone listed in **To**, **Cc**, and **Bcc**. |

> [!IMPORTANT]
> When the toggle is set to **Return to SuperOffice**, the reply must have at least one recipient — **Send** is disabled until you add an address in **To**, **Cc**, or **Bcc**. This prevents you from handing a ticket back without telling the customer.

## Open a ticket in the SuperOffice Customer Center

When you click a ticket ID, a new browser tab opens that ticket in the SuperOffice Customer Center.

> [!WARNING]
> You must be authenticated to see the ticket immediately in the SuperOffice Customer Center. Otherwise you will have to sign in.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/support/
[3]: ../widgets/index.md#messaging-center

<!-- Referenced images -->
[img1]: media/messaging-center-icon.png "Messaging Center"
[img2]: media/messaging-center-layout-user.png "Messaging Center inbox"
[img3]: media/messaging-center-filters.png "Filter bar"
[img4]: media/messaging-center-reply-buttons.png "Reply All and per-message Reply"
[img5]: media/messaging-center-attachment-validation.png "Attachment validation"
[img6]: media/messaging-center-send-toggle-reply.png "Send toggle - Mark as answered"
[img7]: media/messaging-center-send-toggle-return.png "Send toggle - Return to SuperOffice"
