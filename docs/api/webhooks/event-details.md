---
# Mandatory fields.
title: webhook_event_details
description: Event details
author: Tony Yates
so.date: 04.06.2018
keywords: automation
so.topic: reference         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Event details

Event name descriptors are a combination of the webhook entity and event type - `contact.created` is one such descriptor.

## Event entities

* activity
* associate
* contact
* person
* project
* projectmember
* sale
* salestakeholder

## Event names

Each entity raises an event when created, changed, or deleted. Therefore, all possible event names are:

| Create events | Changed events | Deleted events | Other events |
|---|---|---|---|
| activity.created | activity.changed | activity.deleted | |
| associate.created | associate.changed | associate.deleted | |
| contact.created | contact.changed | contact.deleted | |
| document.created | document.changed | document.deleted | document.edited\* |
| person.created | person.changed | person.deleted | person.consented\*<br>person.unconsented\* |
| project.created | project.changed | project.deleted | |
| projectmember.created | projectmember.changed | projectmember.deleted | |
| sale.created | sale.changed | sale.deleted | sale.completed\*<br>sale.lost\*<br> sale.sold\* |
| salestakeholder.created | salestakeholder.changed | salestakeholder.deleted | |
| ticket.created\*\* | ticket.changed\*\* | | |

**Key:**
\* Added in v8.3 R04
\*\* Added in v8.4
