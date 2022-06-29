---
uid: help-en-ticket-showlisttickets-splitticket
title: ticket showListTickets splitTicket
description: ticket showListTickets splitTicket
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Split requests

If a single request contains several questions, for example, if the customer first asks a technical question and then uses the opportunity to raise an invoicing query, you can split the request into two.

> [!TIP]
> You can also [split a message](ticket.showListTickets.splitMessage.md).

To split a request:

1. Open the request. (See [Process requests](ticket.listTicket.md).)
2. Click the ![icon](../media/btn-Menu.png)**Actions** button and select **Split request**. This takes you to the **Split request** screen. This is where you specify information about the new request.
3. In the **Title** field, enter a descriptive name for the request.
4. In the **Category** field, select a category for the request.
5. In the **Owner** field, choose one of the following:
    * If you want to assign the request to a specific person, select the name you require.
    * **(Automatically assigned)**: If you select this option, the system assigns the request in accordance with the applicable assignment rules.
    * **(Unassigned)**: You can also choose not to assign the request. The members of the relevant category then become responsible for dealing with the request.
6. In the **Priority** list box, you can choose between **Low**, **Medium** and **High**, or you can make the system assign the priority automatically. This can be done, for example, on the basis of [escalation levels](admin.listPriorities.editAlert.md) set for different contacts and companies.
7. In the **Access level** list box, select one of the following options:
    * **External**: Select this option if the contact is to have access to the request via SuperOffice Customer Centre.
    * **Internal**: Select this option if the contact is not to have access to the request.
8. In the **Status** list box, choose one of the following:
    * **Open**: Select this option if the request is in progress.
    * **Closed**: Select this option if the request has been completed.
    * **Postponed**: If there is a need to postpone handling of this request, select this option and specify a date in the date field to the right. On this date, the request is set back to **Open**.
9. Under **Properties of the original request** specify whether the original request is **Open**, **Closed** or **Postponed**.
10. At the bottom of the screen is a list of messages involved in the request. Here you select the messages you want to move to the new request.
11. Click **OK**. The request is split.

## What would you like to do now?

[Reply to customer](ticket.showListTickets.addMessage.md)

[Ask another request handler for help.](ticket.showListTickets.askForHelp.md)

[Forward messages to external parties](ticket.showListTickets.forward.md)

[Split message](ticket.showListTickets.splitMessage.md)
