---
uid: help-en-request-create
title: Create a request
description: Create a request
keywords: create request, add request, new request, request properties, request details, message, request, ticket
author: Bergfrid Dias
date: 03.11.2025
version: 10.5.3
topic: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: en
---

# Create a request

A request can arrive in the system via an email from the customer, or you can register it manually via the **New request** screen. This would be the case if a customer makes an enquiry by phone.

## Steps

1. Click **New** on the top bar and select **Request**.

    Alternatively, if you are in the **Requests** section tab on a contact, click **Add** to create a request with the contact prefilled.

1. In the **Title** field, give the request a descriptive name.

1. Add a contact in the **Search for contact** field (if not prefilled). Start typing the name (or phone number) and choose from the results.
    * Optionally, you can skip this step and add the contact later.

1. Use the **Request properties** panel on the right to assign and prioritize the request.

    * Select **Request type**, **Status**, **Owner**, **Category**, **Priority**, and other properties.

    > [!NOTE]
    > The request type affects default values and available statuses and priorities.

1. Go to the **Messages** tab to compose the request message:

    * In the **To** field, add the recipient(s). Start typing the contact's name or email and select them from the list.
    * Optional: Click **Cc/Bcc** to add recipients as a copy or blind copy.
    * Enter the message text, attach files, or insert reply templates.

    > [!NOTE]
    > The default request signature will be added to the message. You can edit the signature directly in the message or edit your default [email signature][11].

1. Go to the **Details** tab to optionally link the request to an existing sale or project.

1. Click **Send** to save and send the request.

![Request properties and message of a new request -screenshot][img1]

## <a id="fields"></a>Key fields explained

<a id="message"></a><a id="details"></a>
The following fields are available in the Request screen. Some fields are filled automatically, while others require input.

> [!NOTE]
> Fields and layout may vary based on [Screen designer][10] configurations and other UI customizations.

<!-- markdownlint-disable-file MD051 -->
### [Messages tab](#tab/messages)

This tab is where you compose and manage the request message.

* Add recipients in the **To** field.
  * Recipients are automatically added as request contacts. The first recipient becomes the main contact.
  * Add multiple recipients, and reorder them by clicking and dragging.
  * To include a recipient without registering them as a contact, enter their email address. They will receive the message but will not appear as a request contact.
  * Leave the field empty if you do not want to send the message.
* Click **Cc/Bcc** to add additional recipients as a copy or blind copy.
* Include a message body, attachments, [reply templates][2], or FAQ entries.
* Use **Internal/External** to determine whether the contact can see the message in the Customer Centre.
* Use the timer to track time spent on handling the request.

The message editor functions like a word processor, allowing you to compose, format, and enhance your messages. Below are the key tools and their purposes:

| Icon | Action | Description |
|:-:|---|---|
| <i class="ph ph-text-a-underline" aria-label="Show/hide toolbar"></i> | Toolbar | Show or hide text formatting options. |
| <i class="ph ph-paperclip" aria-label="Attachments"></i> | Attachments | Add files or CRM documents to the message. |
| <i class="ph ph-article" aria-label="Insert"></i> | Insert | [Insert a reply template][2], FAQ entry, previous message, or attachment. |

#### Attachments

To attach files or CRM documents:

1. Click <i class="ph ph-paperclip" aria-label="Attachments"></i>. An **Attachments** field appears below the **To** field.
1. Add attachments using one of these methods:
    * Click **Upload files (or drag here)** to select a file from your computer.
    * Drag and drop files into the **Attachments** field.
    * Click **Choose a CRM document** to select a file stored in SuperOffice CRM.

#### Insert

To enhance your message with additional content:

1. Click <i class="ph ph-article" aria-label="Insert"></i>.
1. Choose what to add:
    * **Reply template:** Insert pre-written text.
    * **FAQ entry:** Add a knowledge base article.
    * **Previous message:** Reuse text from earlier communication.
    * **Attachment:** Attach a file directly.
1. If reply templates are available in multiple languages, you can select a language.

#### Time spent

The clock starts automatically when you create the request. You can stop the clock by clicking <i class="ph ph-pause" aria-label="Pause"></i>, and also re-start the clock by clicking <i class="ph ph-play" aria-label="Play"></i>. For details on registering time spent, see [Record time spent][3].

### [Details tab](#tab/details)

The **Details** tab contains additional information on the request. Here you will find information like when the request was created, when it was last changed, closed or replied to, when it was read by the owner or contact and extra fields. This information is updated automatically during the lifespan of the request, but there are some fields that can be edited when the request is created:

* **Relation:** Link this request to another related request.
* **Access level:** An alternative way to adjust the visibility of the request. Changes made here are reflected automatically in the **Request properties** panel.
* **Sale/Project:** Connect the request to an existing sale or project.
* **Extra fields:** Additional [custom fields][16] based on your organization's setup.

### [Properties panel](#tab/properties)

The **Properties panel** allows you to categorize and assign the request.

* **Request type:** Determines default values and status options.
* **Status:** Set to **Open** (in progress), **Closed** (completed), or **Postponed** with a specified follow-up time (at which the request is set back to Open).
* **Owner:** Assign the request to yourself, another user, or leave it unassigned.
  * **(Automatically assigned):** The system assigns the request based on assignment rules.
  * **(Unassigned):** The category members share responsibility for the request.
* **Category:** Choose the relevant category for the request.
* **Priority:** Assign as **Low**, **Medium**, or **High**, or let the system determine it (for example, based on [escalation levels][9]).
* **Access level:** Set as **External** (visible to the contact) or **Internal** (hidden from the contact).
* **Tags:** [Add relevant tags][4] to help organize and search for the request later.

***

## Autosave

Whenever you are working on a request and suddenly receive a more urgent request, you will have to leave the request you are working on to solve the prioritized request.

The autosave function will automatically save your changes until you click **Send** or cancel the changes to your request.
Autosaved information is placed in the local storage of your browser, so your data will even survive a browser crash, reboot, logout and login.

The autosave feature is activated by default when you view and edit requests and reply/reply all.

### Limitations

* Autosaved data will not be transferred from one computer to another. This means that you cannot start replying to a request at work, and then continue at home.
* Autosaved data will not be shared between two different browsers.
* The autosave function is a useful feature, but should not replace saving your work the proper way.

## Related content

* [Edit email signature][11]
* [Using tags in requests][4]
* [Reply template variables][18]
* [Create reply template][19]

<!-- Referenced links -->
[2]: reply.md#reply-templ
[3]: reply.md#time-spent
[4]: tags.md
[9]: ../admin/priority/escalation-levels.md
[10]: ../../ui/screen-designer/learn/index.md
[11]: ../../learn/getting-started/edit-email-signature.md
[16]: ../../custom-objects/admin/create-extra-field.md
[18]: ../reply-templates/learn/template-variables.md
[19]: ../reply-templates/learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/create-request.png
