---
uid: crmscript_ref_NSContactAgent_GetContactSummary
title: NSContactSummary GetContactSummary(Integer contactId, Integer limit)
intellisense: NSContactAgent.GetContactSummary
keywords: NSContactAgent, GetContactSummary
so.topic: reference
---

Get summary of contact and its recent activity.

**Parameters:**
 - **contactId** The contact id to summarize.
 - **limit** Max number of items to include in summary lists.

**Returns:** NSContactSummary

```crmscript
NSContactAgent agent;
Integer contactId;
Integer limit;
NSContactSummary res = agent.GetContactSummary(contactId, limit);
```

