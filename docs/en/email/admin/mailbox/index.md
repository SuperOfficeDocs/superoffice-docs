---
uid: help-en-email-service
title: Mailbox administration
description: Mailbox administration
keywords: mailbox, email
author: digitaldiina
date: 11.27.2025
version: 11.6
content_type: concept
category: email
topic: Service mailbox
functional_right:
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: en
redirect_from:
  - /en/email/service/learn/index
  - /en/email/service/learn/screen/tab-inbox-for-email
  - /en/email/service/learn/screen/tab-outbox-for-email
  - /en/email/service/learn/screen/tab-blocked-email
  - /en/email/service/learn/screen/sms-inbox
  - /en/email/service/learn/screen/sms-outbox
  - /en/email/service/learn/email-filters/index
---

# Service emails

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

In the **Email** screen, you control the mechanisms that manage inbound and outbound email. Emails are imported by SuperOffice Service regularly collecting email from one or more mailboxes. These email messages can be scanned by email filters that process emails based on content and generate requests. Outbound email (replies) from the system is placed in the outbox and sent regularly to an email server that forwards the messages. Imported emails that are blocked (by a filter) are displayed in the **Blocked email** tab and must be reviewed manually.

## Mailboxes

The **Mailboxes** tab contains a list of the installed mailboxes. This list contains the following columns:

* **Address**: The mailbox's sending address.
* **Category**: Requests from the mailbox are assigned to this category.
* **Priority**: The priority that new requests are assigned when registered from this mailbox.
* **Forwarding address**: <!-- online -->If you are not using the email functions in SuperOffice, emails are forwarded to this address.
* **Protocol**: <!-- onsite -->The protocol that the mailbox uses.

### <a id="email-in"></a>Inbox for email

In the **Inbox for email** tab is a list of the emails in the queue to be read in. The following options are also available from <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Export**: Used to export the list to a file. You can choose from these formats: Excel, HTML and plain text.

* **Delete**: Used to delete the selected emails.

    > [!NOTE]
    > You cannot undo this operation.

If you click one of the messages in this tab, the **Inbound email** screen appears. This contains information about that message. In the **Last error message** field, you can see what caused the problem, for example, if there is a problem with the email address or the email server. If you get an error from SuperOffice Service, you can click **Import with debug** to display technical information to help user support with troubleshooting.

### <a id="email-out"></a>Outbox for email

In the **Outbox for email** tab is a list of the emails in the queue to be sent out.

Select **Show sent emails** in the lower right corner to display also the last request emails.

The following options are also available from <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Export**: Used to export the list to a file. You can choose from these formats: Excel, HTML and plain text.

* **Send**: Used to resend the selected emails only if there was a fault with the automatic mailing.

* **Delete**: Used to delete the selected emails.

    > [!NOTE]
    > You cannot undo this operation.

If you click one of the messages in this tab, the **Outbound email** screen appears. This contains information about the selected message, such as its size and who created it. Any error messages are also shown.

### <a id="email-blocked"></a>Blocked email

In the **Blocked email** tab is a list of inbound emails blocked by an email filter. Click an email to display its contents. If there is insufficient space for all the emails on one page, you can click <i class="ph ph-arrow-right" aria-label="Arrow right"></i> to navigate to the next page. This list contains the following columns:

* **When**: Specifies when the email was blocked.
* **Mailbox**: Specifies which mailbox imported the email.
* **Email filter**: Specifies which email filter blocked the email.
* **Email subject**: Shows the subject of the message.

The following options are also available from <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Export**: Used to export the list to a file. You can choose from these formats: Excel, HTML and plain text.
* **Import**: Used to import the selected emails. The email filter that blocked the email will then be ignored, but other email filters may be enabled.
* **Delete**: Used to delete the selected blocked emails.

### <a id="sms-in"></a>SMS inbox

> [!NOTE]
> If this tab is not visible, this means that you do not have the SMS module installed or that SMS has not been enabled for the license you are using. Contact your system administrator for more information.

In the **SMS inbox** tab is a list of the SMS messages in the queue to be read in. The following options are also available from the menu button:

* **Export**: Used to export the list to a file. You can choose from these formats: Excel, HTML and plain text.

* **Delete**: Used to delete the selected messages.

    > [!NOTE]
    > You cannot undo this operation.

Click one of the messages in this tab to view information about the selected message.

### <a id="sms-out"></a>SMS outbox

The **SMS outbox** tab contains all outgoing SMS messages that have not yet been sent, or that have produced an error.

> [!NOTE]
> If this tab is not visible, this means that you do not have the SMS module installed or that SMS has not been enabled for the license you are using. Contact your system administrator for more information.

The following options are also available from the menu button:

* **Export**: Used to export the list to a file. You can choose from these formats: Excel, HTML and plain text.

* **Send**: Used to resend the selected messages only if there was a fault with the automatic mailing.

* **Delete**: Used to delete the selected messages.

    > [!NOTE]
    > You cannot undo this operation.

If you click one of the messages in this tab, the **Outbound SMS** screen appears. This contains information about the selected message, such as its size and who created it. Any error messages are also shown.

## <a id="filter"></a>Email filters

An email filter is a tool used to analyze the content of inbound email, and generate a request based on this content.

You can also add advanced rules for handling email from specific senders. Email filters are often used in connection with web forms that the company has published and that generate a fixed format email message that is imported into SuperOffice Service.

### Example related to inbound email from web forms

For example, you can define fixed expressions to extract information that a customer submitted using the form. Based on a defined rule set, data from the form is entered in the customer database. The request generate from the email/form is then placed into a specific category and a request handler is selected. Then the request is closed and the customer receives a customized receipt based on a reply template. In other words, there are many options for automatic handling of inbound email.

* Email received from a web form generally has a default sender address. You can replace this address with the customer's own email address.
* You can compare the customer's phone number with information in the customer database and link the request to the correct customer on this basis.
* You can overwrite address data if there is a change of address.
* You can send a receipt with tailored information if a customer wants more information about a specific product, and assign the request to the right subcategory and request handler.

### Columns in the list of filters

The **Email filters** tab contains a list of existing email filters. This list contains the following columns:

| Column | Description |
|---|---|
| Description | A description of the email filter. |
| Priority | The email filter's priority. Only one filter per email is enabled. If more than one filter contains search criteria that match an inbound email, the highest priority filter is enabled. |
| Email addresses | The addresses of the mailbox the filter applies to. |
| Search string | The search string that the email filter uses. |

## Related content

* [Create mailboxes][1]
* [Delete mailboxes][2]
* [Email filters][3]

<!-- Referenced links -->
[1]: create-mailbox.md
[2]: delete-mailbox.md
[3]: create-email-filter.md

<!-- Referenced images -->
