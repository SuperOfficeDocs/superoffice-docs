---
uid: help-en-request-priority
title: Request priorities
description: Request priorities
keywords: request priority, priority, escalation, request
author: Hanne Gunnarsson
date: 01.15.2025
version: 10.5
topic: concept
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Request priorities

All requests registered in SuperOffice are assigned a priority that reflects the importance of the enquiry.

The default priorities included with the system are **High**, **Medium** and **Low**. But you can both add new priorities and edit the settings of existing priorities.

The priority assigned to a case can be determined by, for example:

* The contact
* The company
* The mailbox
* An email filter

After a request is assigned a priority, the priority can be used to control any escalation of the request.

For example: You can specify that requests from a specific company should have VIP priority and that you should be notified by email if the request has not been read by a specified deadline.

## Override order

Priorities override other priorities in this order:

1. Priority specified for an email filter
1. Priority specified for a contact
1. Priority specified for a company
1. Priority specified for an email box
1. Standard priorities

Because of this order, a request from a contact with high priority gets a high priority even though the mailbox the person sends it to has a low priority.

## Escalation

For requests, you can define as many priorities as you want. For each priority you can define escalation levels, so that the system forwards the enquiry further through the organization if it has not been read or dealt with within a specified time.

For example, user-support and SLA agreements specify that the supplier must begin troubleshooting within, say, 2 hours. You can then define operations that cause the request to be escalated and assigned to new request handlers if it has not been read or processed within this time. You can define as many operations as you want, and also be notified by mobile phone.

## Accessibility

Each priority has an accessibility property associated with it. If the request's priority is set to **External**, the priority will be accessible via the SuperOffice Customer Centre.

If more than two priorities are accessible externally, the customer can select which priority should apply to the request. This may cause the request to be given a higher priority than necessary, because the customer will want to get a reply as quickly as possible and is likely to select the highest available priority. The highest priorities should therefore be set to **Internal**, while **Medium** and **Low** priorities are made accessible externally.

## What do you want to do now?

* [Create priority][1]
* [Delete priorities][2]
* [Create escalation levels][3]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: escalation-levels.md

<!-- Referenced images -->
