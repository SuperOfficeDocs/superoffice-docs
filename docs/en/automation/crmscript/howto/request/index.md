---
uid: crmscript-request
title: Working with requests in CRMScript
description: In CRMScript, how to create and update requests; get ticket info; accept ticket; add message to ticket; reply; priority and escalation; delegate; postpone; split and merge; close; delete
keywords: request, ticket, CRMScript
author: Bergfrid Dias
date: 05.26.2023
version: 10
topic: howto
---

# Working with requests in CRMScript

* [Create ticket][1]
* [Get ticket info][9]
* [Add a message][2]
* [Get message info][9]
* [Accept request][8]
* [Reply to customer][6]
* [Delegate a request][5]
* [Priority and escalation][11]
* [Split and merge tickets][10]
* [Samples][4]
* [Request logs][3]

## A word of caution

### Edit message

For obvious reasons, you should not alter the text in a message after the fact.

However, you might need to edit some properties for bookkeeping or compliance. For example:

* Time spent (accumulates)
* Invoicing info
* Access level (internal/external)
* Attachments (removal might be required)

### Delete tickets

> [!WARNING]
> In general, we don't recommend deleting requests. It is usually preferable to add a comment and/or tag and mark it as closed.

Deleting a ticket will also delete all messages and attachments linked to it!

However, you may be required to delete a request to comply with your company's privacy policy. Proceed with caution! Use the same statements as for closing a ticket, just change the status code from 2 to 4.

## Reference

### Status

| Status | Description |
|---|---|
| 0 | Unknown/uninitialized |
| 1 | Active |
| 2 | Closed |
| 3 | Postponed |
| 4 | Deleted |
| 5 | Merged/Linked |

### Timestamp values - ticket

| Parameter | Db field | Description |
|:--|:--|:--|
| activate       | activate | When to activate a postponed ticket |
| createdAt      | created_at | When the ticket was created |
| repliedAt      | replied_at | When the 1st external message was added |
| stopEscalation | stop_escalation | |
| readStatus     | read_status | Has the owner has read the ticket? (red, yellow, green) |
| deadline       | deadline | The deadline of the ticket |
| timeToClose    | time_to_close | Minutes between create and close |

For a complete list of fields, see the [database reference][16].

### Timestamp values - message

| Parameter | Db field | Description |
|:--|:--|:--|
| createdAt | created_at | When the message was posted |
| timeSpent | time_spent | Minutes used on this message |
| timeCharge | time_charge | Minutes to be invoiced for this message |

<!-- Referenced links -->
[1]: create.md
[2]: add-message.md
[3]: request-logs.md
[4]: samples.md
[5]: delegate.md
[6]: reply.md
[8]: accept.md
[9]: get-ticket-info.md
[10]: split-merge.md
[11]: escalate.md
[16]: ../../../../database/tables/ticket.md
