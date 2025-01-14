---
uid: request-overview
title: Requests
description: How to manage requests and enquiries in SuperOffice - create internal and external requests; respond to incoming enquiries; obtain an overview of the statuses of all requests in the CRM system.
author: Bergfrid Dias
date: 05.31.2023
keywords: Service, ticket, request, inquiry, tag, category, priority, escalation
topic: concept
---

# Requests

![Request screen -screenshot][img1]

[!include[License requirement](../../../common/includes/req-service-essentials.md)]

* Manage requests and inquiries already in the system
* Create internal and external requests
* Respond to incoming inquiries
* Obtain an overview of the statuses of all requests in the system

## Terminology

A **request** is a form of communication where a (potential) customer, client, or business partner seeks information or assistance. For example, support issues, questions about the product and services, questions about invoices, or feedback regarding their experience with interaction with the company.

The terms *request* and *ticket* are often used interchangeably in SuperOffice. For example, you'll see the **Request** screen in the SuperOffice user interface, the `ticket` database table, and the `Ticket` CRMScript class. In the context of CRM, not to be confused with API requests (such as GET, POST, PUT, DELETE) or authorization credentials (such as system user ticket).

## Request handling

Requests can be linked to [contacts][2], who in turn can belong to a [company][3]. This means that requests cannot be linked directly to companies (only indirectly via contacts).

Companies employ varying procedures for handling requests and may utilize SuperOffice in diverse manners. Here are two common scenarios:

### Scenario 1: The customer submits the request by email

1. The customer emails `support@company.com` or fills out a form in a user-support portal.
1. The customer gets an **automatic reply** letting them know the inquiry is received.
1. The system automatically **turns the inquiry into a request** in SuperOffice.
1. The request goes to a request handler, who reads through it.
1. The request handler sends a response to the customer.
1. The request handler closes the request and proceeds to deal with other requests.

### Scenario 2: The customer calls the request handler

1. The customer has a problem with a product and calls user-support.
1. The request handler who answers the call **registers the request**.
1. The request handler sends a response to the customer.
1. The request handler closes the request and proceeds to deal with other requests.

In both scenarios, if the request handler is unable to fulfill the request on their own, they can either:

* Ask a colleague.
* Or, get help from outside the organization, for example for a sub-contractor or supplier.

## Status

A request has one of the following statuses:

* Active
* Closed
* Postponed
* Deleted
* Merged

The status will change as the request flows through the support system. You can [create additional request statuses][4].

## Request category

All requests belong to a category, and each category has its own rules that define how requests are processed in the system. The request categories are arranged in a tree structure. Users can be added as members in the categories individually or via the user groups they belong to. You can [create additional request categories][5].

[Tags][6] are a more flexible alternative to request categories. You can create tags on the fly and tag any request with as many tags as you want.

## Priority

The priority of a request reflects the importance of the enquiry, such as high, medium, or low. After a request is assigned a priority, the priority can be used to control any escalation of the request.

Priority is tied to:

* Deadline
* Read status
* Actions and escalation chain

You can [add new priorities][7] and edit the settings of existing priorities.

## Escalation

The escalation chain has multiple levels. Each level has its own settings, such as:

* Priority
* Alert level (strictly ascending number)
* Time (in minutes) before the ticket is escalated to the next level
* Action (what should be done when escalating to this level)
* If and who the ticket should be delegated to on escalation
* The ID of a [CRMScript][1] to run when the ticket alert goes off

[!include[License requirement](../../../common/includes/req-service-prem.md)]

You can [define additional escalation levels][8] for each priority.

## Response time and time spent

`ticket.replied_at` is set (if empty) based on the time of action (selecting **Reply/Reply all**).

All other calculations run in the background. We use `time_counter` to mark which field in the ticket to count time spent on (queue, internal, external).

<!-- Referenced links -->
[1]: ../automation/crmscript/overview/index.md
[2]: ../contact/reference/index.md
[3]: ../company/reference/index.md
[4]: admin/status/create.md
[5]: admin/category/create.md
[6]: learn/tags.md
[7]: admin/priority/create.md
[8]: admin/priority/escalation-levels.md

<!-- Referenced images -->
[img1]: ../../media/loc/en/request/request-screen.png
