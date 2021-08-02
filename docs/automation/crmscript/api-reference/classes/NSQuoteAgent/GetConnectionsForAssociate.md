---
uid: crmscript_ref_NSQuoteAgent_GetConnectionsForAssociate
title: NSQuoteConnection[] GetConnectionsForAssociate(Integer associateId)
intellisense: NSQuoteAgent.GetConnectionsForAssociate
keywords: NSQuoteAgent, GetConnectionsForAssociate
so.topic: reference
---

Returns all connections available for the specified user.

**Parameters:**
 - **associateId** Primary key of the user

**Returns:** NSQuoteConnection[]

```crmscript
NSQuoteAgent agent;
Integer associateId;
NSQuoteConnection[] res = agent.GetConnectionsForAssociate(associateId);
```

