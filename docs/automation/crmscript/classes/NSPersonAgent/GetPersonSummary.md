---
uid: crmscript_ref_NSPersonAgent_GetPersonSummary
title: PersonSummary GetPersonSummary(Integer personId, Integer limit)
intellisense: NSPersonAgent.GetPersonSummary
keywords: NSPersonAgent, GetPersonSummary
so.topic: reference
---

Get summary of person and recent activity.

**Parameters:**
 - **personId** The person id to summarize.
 - **limit** Max number of items to include in summary lists.

**Returns:** Summary of person, with recent requests, sales, follow-ups, chats.

```crmscript
NSPersonAgent agent;
Integer personId;
Integer limit;
PersonSummary res = agent.GetPersonSummary(personId, limit);
```

