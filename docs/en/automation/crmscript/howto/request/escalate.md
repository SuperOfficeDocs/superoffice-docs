---
uid: crmscript-request-escalate
title: Priority and escalation
description: Priority and escalation of requests in CRMScript
keywords: Service, ticket, request, CRMScript , escalation, priority
author: Bergfrid Skaara Dias
date: 05.26.2023
version: 10
topic: howto
---

# Priority and escalation

## Void checkEscalating(Integer action)

Runs a check according to the ticket's priority and the given action. Based on the result, 1 of the following happens:

* Escalation stops
* Escalation restarts
* Escalation continues

You can specify the following actions:

| Value | Action |
|:-:|:--|
| 0 | ActionRead |
| 1 | ActionChangedOwner |
| 2 | ActionNewInfo |
| 3 | ActionClosed |
| 4 | ActionChangedPriority |
| 5 | ActionNew |

```crmscript
Ticket t;
t.load(8);
t.checkEscalating(4);
```
