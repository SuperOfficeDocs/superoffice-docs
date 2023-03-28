---
uid: help-en-request-screen
title: Request screen
description: Request screen
author: HanneGunnarsson
so.date: 06.29.2022
keywords: request
so.topic: reference
language: en
---

# Request screen

The Request screen has the following sections:

* At the top of the screen, the request header contains basic information about the request.
* Below the header is a row of buttons for performing tasks associated with requests, such as Reply, Reply all, Forward, and Add comment.
* The **Messages** tab displays the messages related to the request.
* The **Details** tab contains an overview of the data registered for the request.
* The **Change log** tab contains the history of this request. The request log shows everything that has happened to this request since it was first registered.

## Task buttons for requests

The toolbar contains the following options:

* **Status**: Shows the status of the request. You can change the status here.
  * **Open**: The request is in progress.
  * **Closed**: The request was fully answered.
  * **Postponed**: Action on the request was postponed to a future date.

* **Owner**: The name of the request handler who is responsible for the request is given here. You [can change the owner][1] here.

* **Category**: The [category][2] that the request belongs to appears here. You can change the category here.

* **Priority**: Choose between **Low**, **Medium**, and **High**, or you can make the system assign the priority automatically. This can be done, for example, on the basis of [escalation levels][3] set for different contacts and companies.

* **Access level**: Select one of the following options:
  * **External**: Select this option if the contact is to have access to the request via the SuperOffice Customer Centre.
  * **Internal**: Select this option if the contact is not to have access to the request. The request will be listed in SuperOffice Customer Centre, but the contact cannot view the request details or messages.

* **Tags**: In the **Tags** list box, [select relevant tags][4] for this request.

* **Task** ![icon][img1]: Click this button to access the following options:

  * **Edit**: Click here to edit the properties for this request. For example, you can assign the request to another request handler if you need to [ask a colleague for advice][1].

  * **Accept**: Click here to [take over the request][5]. You will then be the request's new owner.

  * **Split**: If a single request contains several questions, for example, if the customer first asks a technical question and then uses the opportunity to raise an invoicing query, you can [split the request][6] into two using this button.

  * **Merge**: Click here to merge this request with one or more other requests. For example, if multiple contacts in the same company report the same technical issue (via phone, web forms and email), you can [merge these requests][7] into one request that will be processed.

  * **Print**: Click here to print the request.

  * **Delete**: Click here to delete the request.

## Messages tab

The **Messages** tab displays the messages related to the request.

You can change how many messages are displayed, in ![icon][img3] **Personal settings**:

1. Select ![icon][img3] **Personal settings** > **Settings**.
2. Select the **Interface** tab.
3. Specify the number of messages in the **No. of expanded messages** field.
4. Click **OK**.

### Options

Click ![icon][img1] on a message to access additional options for the message:

* **Change**: Click here to [edit][8] or delete the message.
* **Forward**: Click here to [forward the message][9].
* **Email header**: Click here to view the email header.
* **Show**: Click here to view the message in a new window/tab.
* **Split message**: Click here to [split the message][11] and create a new request. Useful if a message contains two issues that should be handled by different departments, for instance a technical question and an invoice question.
* **Print message**: Click here to print the message.

At the bottom of the **Messages** tab, you can send replies and forward messages, and you can also add comments as internal messages.

## Details tab

The **Details** tab contains an overview of the request.

<!-- Referenced links -->
[1]: ../howto/transfer.md
[2]: ../category/index.md
[3]: ../priority/escalation-levels.md
[4]: ../tags.md
[5]: ../howto/accept.md
[6]: ../howto/split-request.md
[7]: ../howto/merge.md
[8]: ../howto/edit-message.md
[9]: ../howto/forward.md
[11]: ../howto/split-message.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png
[img3]: ../../../../media/icons/personal-settings-small.png
