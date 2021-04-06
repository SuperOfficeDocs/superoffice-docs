---
uid: crmscript_requests
title: Requests
author:
so.date:
keywords:
so.topic:
---

# Requests

**Requests** are the core of SuperOffice Service. You:

* manage requests and inquiries already in the system
* create internal and external requests
* respond to incoming inquiries
* obtain an overview of the statuses of all requests in the system

## Request handling

Different companies have different routines for request handling and may use SuperOffice Service in different ways. Here are 2 common scenarios:

### Scenario 1: The customer submits the request by email

1. The customer emails `support@company.com` or fills out a form in a user-support portal.
2. The customer gets an **automatic reply** letting them know the inquiry is received.
3. The system automatically **turns the inquiry into a request** in SuperOffice Service.
4. The request goes to a request handler, who reads through it.
5. The request handler sends a response to the customer.
6. The request handler closes the request and proceeds to deal with other requests.

### Scenario 2: The customer calls the request handler

1. The customer has a problem with a product and calls user-support.
2. The request handler who answers the call **registers the request**.
3. The request handler sends a response to the customer.
4. The request handler closes the request and proceeds to deal with other requests.

In both scenarios, if the request handler is unable to fulfil the request on their own, they can either:

* Ask a colleague
* Get help from outside the organization, for example for a sub-contractor or supplier

## Status

A ticket has 1 of the following statuses. It will change as the request flows through the support system.

* active
* closed
* postponed
* deleted
* merged

## Escalation

The escalation chain has multiple levels. Each level has its own settings, such as:

* priority
* alert level (strictly ascending number)
* time (in minutes) before the ticket is escalated to the next level
* action (what should be done when escalating to this level)
* if and who the ticket should be delegated to on escalation
* the ID of a **CRMScript** to run when the ticket alert goes off

## Priority

Priority is tied to:

* deadline
* read status
* actions and escalation chain

[Database reference][1]

## Response time and time spent

`ticket.replied_at` is set (if empty) based on the time of action (selecting **Reply/Reply all** in Service)

All other calculations are happening in the background. We use `time_counter` to mark which field in the ticket to count time spent on (queue, internal, external).

## Topics

1. autolist

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-ticket_priority.htm
