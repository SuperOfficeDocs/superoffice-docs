---
uid: help-en-request-create
title: ticket newTicket
description: ticket newTicket
author: SuperOffice RnD
so.date: 06.29.2022
keywords: request
so.topic: help
language: en
---

# Create a request

A request can arrive in the system via an email from the customer, or you can register it manually via the **New request** screen. This would be the case if a customer makes an enquiry by phone.

## Workflow

1. Select **Requests** > **New request**.

2. When you create a new request, the **To** field has the following uses:

    * By default, the contact(s) entered here will also be the contact(s) for the new request.
    * Contact(s) entered here will receive the message (in the **Message** tab) by email (even if the access level of the message is set to **Internal**).
    * If you enter more than one contact, the first contact will be the main contact for the request. You can click and drag the contacts to change the order.

    In the **To** field, start typing the name (or phone number) of the contact. In the list of search results, use the up/down arrow keys on your keyboard to select a contact and press **ENTER**.

    <details><summary>What if the person is not a registered contact?</summary>

    You can register new contacts by clicking ![icon][img1] in the **Contacts** field in the **Properties** tab.

    Optionally, you can enter an email address if you want to add a recipient without registering them in the system. In this case, they will not be added as contacts for the request.
    </details>

    > [!NOTE]
    > You can leave this field empty if you do not want to send the message to anyone, but then you must enter the contact in the **Contacts** field in the **Properties** tab.

3. Optional: Click the **Cc/Bcc** button on the far right to add contacts as copy or blindcopy.

4. Go to the **Properties** tab and enter request information like title, [category][10], priority and status. See [Properties](#properties).

5. Go to the **Message** tab and enter the actual [message](#message) you want to add to the request.

6. Go to the **Invoice information** tab and [enter any invoice lines](#invoice-information).

7. Go to the **Extra fields** tab and enter information in any available [extra fields](#extra-fields).

8. Click **OK** to save the request. See also [Autosave](#autosave).

## Properties

Here you enter information to correctly assign and prioritize the request.

* In the **Title** field, enter a descriptive name for the request.
* In the **Category** field, and select the category you want from the list that appears.
* In the **Owner** field, select one of the following options:
  * If you want to assign the request to a specific person, select the name you require.
  * **(Active user)**: Select this option to assign the request to yourself.
  * **(Automatically assigned)**: If you select this option, the system assigns the request in accordance with the applicable assignment rules.
  * **(Unassigned)**: You can also choose not to assign the request. The members of the relevant category then become responsible for dealing with the request.
* In the **Priority** list box, you can choose between **Low**, **Medium** and **High**, or you can make the system assign the priority automatically. This can be done, for example, on the basis of [escalation levels][3] set for different contacts and companies.
* In the **Access level for request** list box, select one of the following options:
  * **External**: Select this option if the contact is to have access to the request viaSuperOffice Customer Centre.
  * **Internal**: Select this option if the contact is not to have access to the request. The request will be listed in SuperOffice Customer Centre, but the contact cannot view the request details or messages.
* In the **Status** list box, choose one of the following:
  * **Open**: Select this option if the request is in progress.
  * **Closed**: Select this option if the request has been completed.
  * **Postponed**: If there is a need to postpone handling of this request, select this option and specify a date and time in the **Activate** field. On this date and time, the request is set back to **Open**.
* In the **Tags** list box, [select relevant tags][4] for this request.
* The **Contacts** field: By default, the person you entered in the **To** field is also added as a contact for the request (after you click **OK**).
  * You can add additional contacts if you like.
  * Contacts added here will be linked to the request and may view information about the request in SuperOffice Customer Centre.
  * If you enter more than one contact, the first contact will be the main contact for the request. You can click and drag the contacts to change the order.
  * Click ![icon][img1] to [create a new contact][5].
* Automatically add message recipients as request contacts: This checkbox is selected by default for new requests, so any recipients you add in the **To** field when creating the request, will also be added as contacts for the request. The contacts are added when you click **OK**.

## Message

> [!NOTE]
> If you want to send the message to someone, you need to add recipients in the **To** field above the tabs. To make the message available for the contact via SuperOffice Customer Centre, you must set the access level (for the message) to **External**.

Here you type in the message you want to add to the request. This works in the same way as when entering text into a word processor. You can also add attachments to the message.

The section at the bottom contains the following options:

* ![icon][img2] – Click here to show or hide the toolbar in the message editor
* ![icon][img3] – Click here to show the attachments options. Here you can add relevant documents as attachments to the request.
  * Click **Upload files (or drag here)** to browse to and add a file from a disk or server.
  * Drag and drop a file from Windows Explorer to the attachments field.
  * Click **Choose a CRM document** to select a document in SuperOffice CRM.
* **Insert**: Click the list button ![icon][img4], and select what to insert in the message. You can add a reply template, an FAQ entry, a previous message, or an attachment. Optional: You can also [add reply templates in other languages][7]. Select a language in the language list. If available, the text will be inserted in the selected language. Otherwise the default language will be used.
* **Internal/External**: Here you can select **External** if the contact is to have access to the message via SuperOffice Customer Centre, or **Internal** if the contact is not to have access to the message.
* **Time spent**: Here you can record how much time was spent dealing with the message. The clock starts automatically when you create the request. You can stop the clock by clicking the stop button ![icon][img5], and also re-start the clock by clicking the start button ![icon][img6]. Click ![icon][img7] (**Select time span**) button to register time spent.

> [!NOTE]
> The default request signature will be added to the message. You can edit the signature directly or

## Invoice information

> [!NOTE]
> The invoice feature is only available if you have registered [invoice types][8] and have the required feature toggle.

Here you can add invoice lines as internal information for the request.

1. In the list box at the top left, select the type of invoice. The price is updated in accordance with the invoice you select.
2. In the **Description** field, enter a more detailed description of what the invoice line relates to.
3. In the next fields, enter the unit price, quantity, any discount (percent or amount) and the date.
4. Click ![icon][img1] to add the invoice line.

## Extra fields

This tab contains any extra fields defined for requests. These will vary from company to company.

## Autosave

Whenever you are working on a request and suddenly receive a more urgent request, you’ll have to leave the request you are working on to solve the prioritized request.

The autosave function will automatically save your changes until you click **OK** to send or cancel the changes to your request.

Autosaved information is placed in the local storage of your browser, so your data will even survive a browser crash, reboot, logout and login.

The autosave feature is activated by default when you view and edit requests and reply/reply all).

### Limitations

* Autosaved data will not be transferred from one computer to another. This means that you cannot start replying to a request at work, and then continue at home.
* Autosaved data will not be shared between two different browsers.
* The autosave function is a useful feature, but should not replace saving your work the proper way.

> [!TIP]
> If you are using custom screens, you can [activate or deactivate autosave][6].

## What would you like to do now?

* [Process requests][9]

<!-- Referenced links -->
[3]: ../priority/escalation-levels.md
[4]: ../tags.md
[5]: ../../person/in-service/create.md
[6]: ../../ui/in-service/screen-properties.md
[7]: ../reply-templates/new-language.md
[8]: ../invoice/index.md
[9]: index.md
[10]: ../category/index.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-add.png
[img2]: ../../../media/icons/service/msg-toolbar.png
[img3]: ../../../media/icons/service/msg-attachment.png
[img4]: ../../../../common/icons/dropdown-arrow.png
[img5]: ../../../../common/icons/stop.png
[img6]: ../../../../common/icons/play.png
[img7]: ../../../../common/icons/timespan.png
