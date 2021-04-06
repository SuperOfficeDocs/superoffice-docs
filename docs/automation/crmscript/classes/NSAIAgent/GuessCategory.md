---
uid: crmscript_ref_NSAIAgent_GuessCategory
title: Integer GuessCategory(Integer ticketId)
intellisense: NSAIAgent.GuessCategory
keywords: NSAIAgent, GuessCategory
so.topic: reference
---

Given a ticket's id, guess the ticket category it should be placed in. Currently this is based on the first message in the ticket

**Parameters:**
 - **ticketId** Id of ticket to guess category for

**Returns:** Suggested ticket category ID

```crmscript
NSAIAgent agent;
Integer ticketId;
Integer res = agent.GuessCategory(ticketId);
```

