---
uid: crmscript_ref_NSContactAgent_GetContactSummary
title: ContactSummary GetContactSummary(Integer contactId, Integer limit)
intellisense: NSContactAgent.GetContactSummary
keywords: NSContactAgent, GetContactSummary
so.topic: reference
---

Get summary of contact and its recent activity.

**Parameters:**
 - **contactId** The contact id to summarize.
 - **limit** Max number of items to include in summary lists.

**Returns:** Summary of contact, with recent requests, sales, follow-ups, chats.

```crmscript
NSContactAgent agent;
Integer contactId;
Integer limit;
ContactSummary res = agent.GetContactSummary(contactId, limit);
```

