---
uid: help-en-request-create
title: Create a request
description: Create a request
author: Hanne Gunnarsson
date: 03.22.24
version: 10.3.2
keywords: request, comment, reply
topic: howto
audience: person
audience_tooltip: SuperOffice Service
language: en
---

# Create a request

A request can arrive in the system via an email from the customer, or you can register it manually via the **New request** screen. This would be the case if a customer makes an enquiry by phone.

## Workflow

1. Select **New** > **Request**.

1. In the **Title** field, give the request a descriptive name for the request.

1. Add a contact in the **Search for contact** field.
   Don't want to add a contact? You can create a ticket without adding a contact and add this information later, if you are in a hurry.

1. When you create a new request, the **To** field has the following uses:

    * By default, the contact(s) entered here will also be the contact(s) for the new request.
    * If you enter more than one contact, the first contact is the main contact for the request. You can click and drag the contacts to change the order.

    In the **Contact** (Search for contact) field, start typing the name (or phone number) of the contact. In the list of search results, use the up/down arrow keys on your keyboard to select a contact and press **ENTER**. Or use your mouse cursor to select the contact.

    Optionally, enter an email address to add a recipient without registering them in the system. In this case, they will not be added as contacts for the request.

    > [!NOTE]
    > You can leave this field empty if you do not want to send the message to anyone.

1. Optional: Click the **Cc/Bcc** button on the far right to add contacts as copy or blind copy.

1. Go to the **Properties panel** (on the right side of the screen) and enter information to correctly assign and prioritize the request.

    * In the **Request type** field, choose a type, which will affect default values and available statuses and priorities.

    * In the **Status** list box, choose one of the following:
      * **Open**: Select this option if the request is in progress.
      * **Closed**: Select this option if the request is completed.
      * **Postponed**: To postpone handling of this request, select this option and specify a date and time in the **Specified** field or a preset time in the list below. On this date and time, the request is set back to **Open**.

    * In the **Owner** field, select one of the following options:
      * To assign the request to a specific person, select the name you require. Select your own name to assign the ticket to yourself.
      * **(Automatically assigned)**: If you select this option, the system assigns the request in accordance with the applicable assignment rules.
      * **(Unassigned)**: You can also choose not to assign the request. The members of the relevant category then become responsible for dealing with the request.

    * In the **Category** field, select the category you want from the list that appears.

    * In the **Priority** list box, you can choose between **Low**, **Medium** and **High**, or you can make the system assign the priority automatically. This can be done, for example, on the basis of [escalation levels][3] set for different contacts and companies.

    * In the **Access level for request** list box, select one of the following options:
      * **External**: Select this option if the contact is to have access to the request via SuperOffice Customer Centre.
      * **Internal**: Select this option if the contact is not to have access to the request. The request will be listed in SuperOffice Customer Centre, but the contact cannot view the request details or messages.

    * In the **Tags** list box, [select relevant tags][4] for this request.

    ![Request properties sidebar -screenshot][img7]

1. In the **Messages** tab, enter the actual [message](#message) you want to add to the request.

1. Click **Send** to send and save the request.

## <a id="message"></a>Message

> [!NOTE]
> To send the message to someone, add recipients in the **To** field below the tabs. To make the message available for the contact via SuperOffice Customer Centre, set the access level (for the message) to **External**.

Here you type in the message you want to add to the request. This works in the same way as when entering text into a word processor. You can also add attachments, [reply templates][2] and FAQs to the message.

The section at the bottom contains the following options:

* <i class="ph ph-text-a-underline" aria-label="Show/hide toolbar"></i> – Click here to show or hide the toolbar in the message editor
* <i class="ph ph-paperclip" aria-label="Attachments"></i> – Click here to show the attachments options. Here you can add relevant documents as attachments to the request.
  * Click **Upload files (or drag here)** to browse to and add a file from a disk or server.
  * Drag and drop a file from Windows Explorer to the attachments field.
  * Click **Choose a CRM document** to select a document in SuperOffice CRM.
* **Insert**: Click the list button ![icon][img3], and select what to insert in the message. You can add a reply template, an FAQ entry, a previous message, or an attachment. Optional: You can also [add reply templates in other languages][7]. Select a language in the language list. If available, the text will be inserted in the selected language. Otherwise the default language will be used.
* **Internal/External**: Here you can select **External** if the contact is to have access to the message via SuperOffice Customer Centre, or **Internal** if the contact is not to have access to the message.
* **Time spent**: Here you can record how much time was spent dealing with the message. The clock starts automatically when you create the request. You can stop the clock by clicking <i class="ph ph-stop" aria-label="Stop"></i>, and also re-start the clock by clicking <i class="ph ph-play" aria-label="Play"></i>. Click <i class="ph ph-timer" aria-label="Timer icon"></i> (**Select time span**) register time spent.

> [!NOTE]
> The default request signature will be added to the message. You can edit the signature directly in the message or edit your default [email signature][1].

## <a id="details"></a>Details

The **Details** tab contains further details on the request. Here you will find information like when the request was created, when it was last changed, closed or replied to, when it was read by the owner or contact and extra fields. This information is updated automatically during the lifespan of the request, but there are some fields that can be edited when the request is created:

* **Relation**: Here you can choose to link the request to another request, if the new request is related to another existing one.
* **Access level**: This is another way to set the access level for the request. This can also be done on the **Properties panel**. If you change the access level here, it will change automatically on the **Properties panel** as well.
* **Sale**: Here you can link the request to an existing sale by searching for the sale you want or selecting it from the list.
* **Project**: Here you can link the request to an existing project by searching for the project you want or selecting it from the list.
* **Extra fields**: What is available depends on added [extra tables and fields][6] and customizations in the [screen designer][10].

## Autosave

Whenever you are working on a request and suddenly receive a more urgent request, you will have to leave the request you are working on to solve the prioritised request.

The autosave function will automatically save your changes until you click **Send** or cancel the changes to your request.
Autosaved information is placed in the local storage of your browser, so your data will even survive a browser crash, reboot, logout and login.

The autosave feature is activated by default when you view and edit requests and reply/reply all.

### Limitations

* Autosaved data will not be transferred from one computer to another. This means that you cannot start replying to a request at work, and then continue at home.
* Autosaved data will not be shared between two different browsers.
* The autosave function is a useful feature, but should not replace saving your work the proper way.

## What would you like to do now?

* [Edit message][5]
* [Process requests][8]
* [Edit email signature][1]
* [Escalation levels][3]
* [Using tags in requests][4]
* [Add reply templates to messages][2]
* [Create reply template][9]
* [Create new language version of reply template][7]
* [Reply template variables][11]
* [Extra tables and fields][6]
* [Screen designer][10]

<!-- Referenced links -->
[1]: ../../../learn/getting-started/edit-email-signature.md
[2]: reply.md#reply-templ
[3]: ../priority/escalation-levels.md
[4]: ../tags.md
[5]: edit-message.md
[6]: ../../../custom-objects/admin/create-extra-field.md
[7]: ../../reply-templates/learn/new-language.md
[8]: ../index.md
[9]: ../../reply-templates/learn/index.md
[10]: ../../../ui/screen-designer/learn/index.md
[11]: ../../reply-templates/learn/template-variables.md

<!-- Referenced images -->
[img3]: ../../../../../common/icons/copy-paste-icon.png
[img7]: ../../../../media/loc/en/request/requests-select-request-types.png
