---
title: Event details
uid: webhook_event_details
description: Event details
author: Tony Yates
so.date: 04.06.2018
keywords: automation
so.topic: reference
# so.envir:
# so.client:
---

# Event details

Event name descriptors are a combination of the webhook entity and event type - `contact.created` is one such descriptor.

## Event entities

* [activity][1]
* [associate][2]
* [chat][9]
* [contact][3]
* [CRMScript][10]
* [documents][11]
* [person][4]
* [project][5]
* [projectmember][6]
* [quote][12]
* [sale][7]
* [salestakeholder][8]
* [test][13]
* [ticket][14]

## Event names

Each entity raises an event when created, changed, or deleted. Therefore, all possible event names are:

| Create events | Changed events | Deleted events | Other events |
|---|---|---|---|
| activity.created | activity.changed | activity.deleted | |
| associate.created | associate.changed | associate.deleted | |
| contact.created | contact.changed | contact.deleted | contact.softdeleted |
| chatsession.created | chatsession.changed | | chatsession.message |
| document.created | document.changed | document.deleted | document.edited (v8.3 R04) |
| person.created | person.changed | person.deleted | person.consented (v8.3 R04)<br>person.unconsented (v8.3 R04) |
| project.created | project.changed | project.deleted | |
| projectmember.created | projectmember.changed | projectmember.deleted | |
| | | | quote.approved<br>quote.rejected<br>quote.sent<br>quote.ordered |
| sale.created | sale.changed | sale.deleted | sale.completed (v8.3 R04)<br>sale.lost (v8.3 R04)<br> sale.sold (v8.3 R04) |
| salestakeholder.created | salestakeholder.changed | salestakeholder.deleted | |
| ticket.created (v8.4) | ticket.changed (v8.4) | | |

<!-- Referenced links -->
[1]: reference/activity-events.md
[2]: reference/associate-events.md
[3]: reference/contact-events.md
[4]: reference/person-events.md
[5]: reference/project-events.md
[6]: reference/project-member-events.md
[7]: reference/sale-events.md
[8]: reference/sale-stakeholder-events.md
[9]: reference/chat-events.md
[10]: crmscript-handlers.md
[11]: reference/document-events.md
[12]: reference/quote-events.md
[13]: reference/test-event.md
[14]: reference/ticket-events.md
