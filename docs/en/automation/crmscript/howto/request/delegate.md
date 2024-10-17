---
uid: crmscript-request-delegate
title: Delegate request
description: How to delegate a request with CRMScript
keywords: Service, ticket, request, CRMScript
author: Bergfrid Skaara Dias
date: 05.26.2023
version: 10
topic: howto
---

# Delegate request

If a request handler is unable to resolve the issue, they can:

* Pass the ticket to a colleague
* Forward the ticket to an external party
* Delegate and let the system pick the next owner

## Ask a colleague for help

1. Reassign the ticket.
2. Add an internal message with your question.
3. Update the last modified timestamps.
4. Optionally add the ticket to the previous owner's favorites list, as a reminder to follow up.

## Forward to an external party

A common scenario when you need to get advice from a sub-supplier.

> [!TIP]
> Use the contact's (customer's) email address as the sender so that any answer from the recipient will be sent directly to the contact and not back to SuperOffice Service.

<!-- markdownlint-disable-next-line MD013 -->
### Bool sendMessages(String subject, StringMatrix recipients, Bool fromCust, String messages, Integer msgId, String comment)

Forwards the listed messages. In the generated email, the comment is inserted at the top and followed by the messages, each separated by a line.

| Parameter  | Description                             |
|------------|-----------------------------------------|
| subject    | ticket.title or similar                 |
| recipients | Format: to / pipesign / name / email    |
| fromCust   | The sender's email address              |
| messages   | A comma-separated list of message IDs   |
| msgId      | ID of added "forward" message or -1     |
| comment    | A note preceding the forwarded messages |

**Recipients example:**
<!-- markdownlint-disable-next-line MD034 -->
To \| John Doe \<john.doe@john.doe> Cc \| Jane Doe \<jane.doe@jane.doe>

## Void delegate()

Delegates a ticket to a user according to the rules of the ticket's category.

> [!NOTE]
> You must call `save()` to do the action.

```crmscript
Ticket t;
t.load(2);
t.delegate();
t.save();
```

## Void delegate(Integer notUser)

A variant of `delegate()` that lets you exclude a user from the pool of possible assignees.
For example, if the 2nd owner also passes on the ticket and you want to avoid re-assigning to the original owner.

```crmscript
Ticket t;
t.load(2);
t.delegate(4);
t.save();
```
