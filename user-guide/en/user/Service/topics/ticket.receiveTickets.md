---
uid: help-en-ticket-receivetickets
title: ticket receiveTickets
description: ticket receiveTickets
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Receive requests

In order for a request to be your responsibility, your name must appear in the request's **Owner** field (see [Process requests](ticket.listTicket.md)). This can be set manually, for example when the request is created (see [Create requests](ticket.newTicket.md)). But it may also be the result of automatic assignment of requests. Such assignment depends on the category the request belongs to, and the assignment method specified for this category. <!-- Fix reuse ID=a1 -->

A request handler with category administration rights can specify the assignment method for categories:

1. Select ![icon](../media/globalmenu-settings-small.png)**System settings &gt; Categories**.
2. Select the required category.
3. Select the **Assignment method** tab.
4. Select the appropriate options.
5. Click **OK**.

There are various assignment methods available:

* **Even assignment**: Assigns requests evenly among the members of the category.
* **Weighted assignment**: Assigns requests based on the [weightings](admin.listCategories.newCategory.md) specified for members of the category.
* **To user with fewest open requests**: Assigns new requests to the category members who has the fewest active requests.
* **Do not assign**: Does not assign requests to specific request handlers, but puts all requests in a queue as **Unassigned**.

[!include[Get next request in queue](../../includes/howto-get-next-request.md)]

## Example

An example will clarify this feature. Imagine that your company has created a category for each department in the company: User support, Sales, Accounts, etc. And you have also specified that all e-mails sent to support@company.com should be automatically assigned to the "User support" category. All the staff in the user support department are members of this category. For this category they have set the **Even assignment** rule. This means that all the members of the category will get the same number of requests, and each of the members will continuously receive new requests in their **Own open requests** screen. If, alternatively, they had selected the **Do not assign** rule, the members would have had to go into the **Unassigned requests** screen themselves in order to take ownership of new requests (see [Take responsibility for requests](ticket.showListTickets.acceptRequest.md)).

## What would you like to do now?

* [Process requests](ticket.listTicket.md)
* [Create requests](ticket.newTicket.md)
* [Efficient handling of requests using AI](AI-requests.md)
