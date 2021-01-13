---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: webhook_event_details       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Event details # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates
so.date: 04.06.2018
keywords: automation
so.topic: reference         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Event details

Event name descriptors are a combination the webhook entity and event type, i.e. "contact.created" is one such descriptor.

Available event entities are:

* activity
* associate
* contact
* person
* project
* projectmember
* sale
* salestakeholder

Each entity raises an event when created, changed or deleted. Therefore, all possible event names are:

| Create Events | Changed Events | Deleted Events | Other Events |
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
