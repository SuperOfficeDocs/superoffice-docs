---
uid: requests-overview
title: Requests
description: Request handling in SuperOffice
author: HanneGunnarsson
so.date: 02.04.2022
keywords: Service, ticket, request
so.topic: concept
---

# Requests

[!include[License requirement](../../../common/includes/req-service-essentials.md)]

(Some features need premium.)

**Requests** are the core of SuperOffice CRM. You:

* manage requests and inquiries already in the system
* create internal and external requests
* respond to incoming inquiries
* obtain an overview of the statuses of all requests in the system

## Request handling

Different companies have different routines for request handling and may use SuperOffice Requests in different ways. Here are two common scenarios:

### Scenario 1: The customer submits the request by email

1. The customer emails `support@company.com` or fills out a form in a user-support portal.
1. The customer gets an **automatic reply** letting them know the inquiry is received.
1. The system automatically **turns the inquiry into a request** in SuperOffice CRM.
1. The request goes to a request handler, who reads through it.
1. The request handler sends a response to the customer.
1. The request handler closes the request and proceeds to deal with other requests.

### Scenario 2: The customer calls the request handler

1. The customer has a problem with a product and calls user-support.
1. The request handler who answers the call **registers the request**.
1. The request handler sends a response to the customer.
1. The request handler closes the request and proceeds to deal with other requests.

In both scenarios, if the request handler is unable to fulfill the request on their own, they can either:

* Ask a colleague
* Get help from outside the organisation, for example for a sub-contractor or supplier

## Status

A ticket has one of the following statuses. It will change as the request flows through the support system.

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

[!include[License requirement](../../../common/includes/req-service-prem.md)]

## Priority

Priority is tied to:

* deadline
* read status
* actions and escalation chain

[Database reference][1]

## Response time and time spent

`ticket.replied_at` is set (if empty) based on the time of action (selecting **Reply/Reply all** in Requests)

All other calculations are happening in the background. We use `time_counter` to mark which field in the ticket to count time spent on (queue, internal, external).

<!-- Referenced links -->
[1]: ../database/tables/ticket-priority.md
