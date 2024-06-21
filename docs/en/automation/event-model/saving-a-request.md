---
title: Saving a request
uid: event_model_saving_a_request
description: CRMScript event model - Saving a request
author:
date:
keywords:
topic: reference
---

# Saving a request

Every time a ticket is saved, a system script called **Saving a request** will be executed.

You can get the ticket ID by running `getVariable`

## Accessible variables

* ticketId
* activeUser

Furthermore, you can use `getParserVariable` to get out more information regarding the changes done.

The syntax is:

```crmscript
getParserVariable("ticket.new.value");

getParserVariable("ticket.old.value");
```

For example, to see if the category has been changed:

```crmscript
if (getParserVariable("ticket.new.category") != getParserVariable("ticket.old.category")) {}
```

## Accessible parser variables

* id
* title
* createdAt
* lastChanged
* readByOwner
* readByCustomer
* firstReadByUser
* firstReadByOwner
* activate
* closedAt
* deadline
* timeToClose
* realTimeToClose
* timeToReply
* m_realTimeToReply
* createdBy
* author
* ownedBy
* category
* slevel
* priority
* status
* ticketStatus
* customer
* alertLevel
* alertTimeout
* connectId
* filterId
* readStatus
* hasAttachment
* displayFilter
* alertStop
* repliedAt
* filterAddress
* dbiAgentId
* dbiKey
* dbiLastModified
* dbiLastSyncronized
