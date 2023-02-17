---
uid: help-en-request-create
title: Create request
description: Create request
author: SuperOffice RnD
so.date: 02.14.2023
keywords: request
so.topic: help
language: en
---

# Create a request

A request can arrive in the system via an email from the customer, or you can register it manually via the **New request** screen. This would be the case if a customer makes an enquiry by phone.

## Workflow

1. Select ![icon][img8] **+New** > **Request**.

1. Add the **Request title** that will explain the content of the request.
1. When you create a new request, the **Contact** field has the following uses:

    * By default, the contact(s) entered here will also be the contact(s) for the new request.
    * If you enter more than one contact, the first contact is the main contact for the request. You can click and drag the contacts to change the order.

    In the **Contact** (Search for contact) field, start typing the name (or phone number) of the contact. In the list of search results, use the up/down arrow keys on your keyboard to select a contact and press **ENTER**. Or use your mouse cursor to select the contact.

    <details><summary>What if the person is not a registered contact?</summary>

    To [create a new contact][10], click ![icon][img8] **+New** and **Contact**.

    Optionally, enter an email address to add a recipient without registering them in the system. In this case, they will not be added as contacts for the request.
    </details>

1. In the **To** field, add the recipient that will receive the message, normally that is the same as the **Contact**.

1. Optional: Click the **Cc/Bcc** button on the far right to add contacts as copy or blind copy.

1. Go to the **Request properties** and enter request information like title, [category][9], priority and status.

1. Go to the **Messages** tab and enter the actual [message](#message) you want to add to the request.

1. Go to the **Details** tab and enter information in any available extra fields.

1. Click **OK/Send** to send the request.

## Request header

* In the **Title** field, enter a descriptive name for the request.

* The **Contacts** field: By default, the current person is entered in the **Contacts** field.
  * You can add additional contacts if you like.
  * Contacts added here will be linked to the request and may view information about the request in SuperOffice Customer Centre.
  * If you enter more than one contact, the first contact is the main contact for the request. You can click and drag the contacts to change the order.

## Request properties in the sidebar

Here you enter information to correctly assign and prioritize the request.

* In the **Status** list box, choose one of the following:
  * **Open**: Select this option if the request is in progress.
  * **Closed**: Select this option if the request is completed.
  * **Postponed**: To postpone handling of this request, select this option and specify a date and time in the **Activate** field. On this date and time, the request is set back to **Open**.

* In the **Owner** field, select one of the following options:
  * To assign the request to a specific person, select the name you require.
  * **(Active user)**: Select this option to assign the request to yourself.
  * **(Automatically assigned)**: If you select this option, the system assigns the request in accordance with the applicable assignment rules.
  * **(Unassigned)**: You can also choose not to assign the request. The members of the relevant category then become responsible for dealing with the request.

* In the **Category** field, and select the category you want from the list that appears.

* In the **Priority** list box, you can choose between **Low**, **Medium** and **High**, or you can make the system assign the priority automatically. This can be done, for example, on the basis of [escalation levels][3] set for different contacts and companies.

* In the **Access level for request** list box, select one of the following options:
  * **External**: Select this option if the contact is to have access to the request via SuperOffice Customer Centre.
  * **Internal**: Select this option if the contact is not to have access to the request. The request will be listed in SuperOffice Customer Centre, but the contact cannot view the request details or messages.

* In the **Tags** list box, [select relevant tags][4] for this request.

## <a id="message" />Messages

> [!NOTE]
> To send the message to someone, add recipients in the **To** field (or Cc and Bcc). To make the message available for the contact via SuperOffice Customer Centre, set the access level (for the message) to **External**.

Here you type in the message you want to add to the request. This works in the same way as when entering text into a word processor. You can also add attachments to the message.

The section at the bottom contains the following options:

* ![icon][img2] – Click here to show or hide the toolbar in the message editor
* ![icon][img3] – Click here to show the attachments options. Here you can add relevant documents as attachments to the request.
  * Click **Upload files (or drag here)** to browse to and add a file from a disk or server.
  * Drag and drop a file from Windows Explorer to the attachments field.
  * Click **Choose a CRM document** to select a document in SuperOffice CRM.
* **Add text**: Click the list button ![icon][img4], and select what to insert in the message. You can add a [reply template or an FAQ entry][5].
* **Internal/External**: Here you can select **External** if the contact is to have access to the message via SuperOffice Customer Centre, or **Internal** if the contact is not to have access to the message.
* **Time spent**: Here you can record how much time was spent dealing with the message. The clock starts automatically when you create the request. You can stop the clock by clicking the stop button ![icon][img5], and also re-start the clock by clicking the start button ![icon][img6]. Click ![icon][img7] (**Select time span**) button to register time spent.

> [!NOTE]
> The default request signature will be added to the message. You can edit the signature directly or edit your default [email signature][1].

## Details

This tab contains any extra fields defined for requests. These will vary from company to company.

## What would you like to do now?

* [Process requests][8]

<!-- Referenced links -->
[1]: ../../../learn/getting-started/edit-email-signature.md
[3]: ../priority/escalation-levels.md
[4]: ../tags.md
[5]: reply.md
[8]: index.md
[9]: ../category/index.md
[10]: ../../../contact/learn/create.md

<!-- Referenced images -->
[img2]: ../../../../media/icons/service/msg-toolbar.png
[img3]: ../../../../media/icons/service/msg-attachment.png
[img4]: ../../../../../common/icons/copy-paste-icon.png
[img5]: ../../../../../common/icons/stop.png
[img6]: ../../../../../common/icons/play.png
[img7]: ../../../../../common/icons/timespan.png
[img8]: ../../../../media/icons/new.png
