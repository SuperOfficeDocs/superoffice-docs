---
uid: help-en-ticket-listticket
title: ticket listTicket
description: ticket listTicket
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Process requests

When you double-click a row in the search results screen (see [View search results for requests][1]), you are taken to the **Request** screen. This screen comprises the following sections:

* At the top of the screen, the request header contains basic information about the request.
* Below the header is a row of buttons for performing tasks associated with requests.
* The **Messages** tab displays the messages related to the request.
* The **Details** tab contains an overview of the data registered for the request.

## Request header

The header of the request contains the properties defined when the request was created (see [Create requests][2]). The header consists of the request title, request ID, contact and deadline. In addition, you can click ![icon][img2] to set the request as a favourite ( ![icon][img4] ). The request will then be accessible via **My favourites** under **Requests** in the Navigator, and in the **My favourites** tile on the dashboard.

## Task buttons for requests

The toolbar contains the following options:

* **Owner**: The name of the request handler who is responsible for the request is given here. You can change the owner here. See [Ask another request handler for help][3].

* **Status**: Shows the status of the request. You can change the status here.
  * **Open**: The request is in progress.
  * **Closed**: The request has been fully answered.
  * **Postponed**: Action on the request has been postponed to a future date.

* **Category**: The category that the request belongs to appears here. You can change the category here.

* Tags:

* **Actions** ( ![icon][img1] ): Click this button to access the following options:

* **Reply** / **Reply to all**: Click here to respond to the customer and/or other people linked to the request. See [Reply to customer][4]. This function is also available at the bottom of the **Messages** tab.
  * **Edit request**: Click here to edit the properties for this request. For example, you can assign the request to another request handler if you need to ask a colleague for advice. See [Ask another request handler for help][3].
  * **Accept request**: Click here to take over the request. You will then be the request's new owner. See [Take responsibility for requests][5].
  * **Split request**: If a single request contains several questions, for example, if the customer first asks a technical question and then uses the opportunity to raise an invoicing query, you can split the request into two using this button. See [Split requests][6].
  * **Merge**: Click here to merge this request with one or more other requests. For example, if multiple contacts in the same company have reported the same technical issue (via phone, web forms and e-mail), you can merge these requests into one request which will be processed. See [Merge requests][7].
  * **Log**: Click here to view the history of this request. The request log shows everything that has happened to this request since it was first registered.
  * **Publish to FAQ**: If the same question comes up time and again, it is a good idea to create an answer that can be reused. You click here to send the customer's question and your answer to the administrator, who can then edit and publish the FAQ entry. See [Create FAQ entries][8].
  * **Print request**: Click here to print the request.

## Messages tab

The **Messages** tab displays the messages related to the request.

You can change how many messages are displayed, in ![icon][img3] **Personal settings**. <!-- Fix reuse ID=a2 -->

1. Select ![icon][img3] **Personal settings &gt; Settings**.
2. Select the **Interface** tab.
3. Specify the number of messages in the **No. of expanded messages** field.
4. Click **OK**.

There are basically three types of messages:

* enquiries from customers or other external parties
* replies to these enquiries, possibly with a request for more details
* internal notes about the request, such as questions to a colleague

> [!TIP]
> Internal messages are marked with ![icon][img5].

Click ![icon][img1] on a message to access additional options for the message:

* **Change**: Click here to edit or delete the message. See [Edit message][9].
* **Forward**: Click here to forward the message. See [Forward messages to external parties][10].
* **E-mail header**: Click here to view the e-mail header.
* **Show**: Click here to view the message in a new window/tab.
* **Split message**: Click here to split the message and create a new request. This is useful if a message contains two issues that should be handled by different departments, for instance a technical question and an invoice question. See [Split message][11].
* **Print message**: Click here to print the message.

At the bottom of the **Messages** tab, you can send replies and forward messages, and you can also add comments as internal messages.

> [!TIP]
> Go to [Efficient handling of requests using AI][12] to read more about language detection, translation, sentiment analysis and automatic categorization.

## Details tab

The **Details** tab contains an overview of the request.

## Related topics

[Efficient handling of requests using AI][12]

[Autosave][13]

<!-- Referenced links -->
[1]: listTickets.showListTickets.md
[2]: newTicket.md
[3]: showListTickets.askForHelp.md
[4]: showListTickets.addMessage.md
[5]: showListTickets.acceptRequest.md
[6]: showListTickets.splitTicket.md
[7]: showListTickets.mergeTickets.md
[8]: ../faq/newKbEntry.md
[9]: showListTickets.editMessage.md
[10]: showListTickets.forward.md
[11]: showListTickets.splitMessage.md
[12]: AI-requests.md
[13]: autosave.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png
[img2]: ../../../../media/icons/favorite-inactive.png
[img3]: ../../../../media/icons/globalmenu-personalsettings-small.png
[img4]: ../../../../media/icons/favorite-inactive.png
[img5]: ../faq/newKbEntry.md
