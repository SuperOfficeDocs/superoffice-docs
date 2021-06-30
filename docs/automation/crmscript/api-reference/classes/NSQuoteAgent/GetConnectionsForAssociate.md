---
uid: crmscript_ref_NSQuoteAgent_GetConnectionsForAssociate
title: QuoteConnection[] GetConnectionsForAssociate(Integer associateId)
intellisense: NSQuoteAgent.GetConnectionsForAssociate
keywords: NSQuoteAgent, GetConnectionsForAssociate
so.topic: reference
---

Returns all connections available for the specified user.

**Parameters:**
 - **associateId** Primary key of the user

**Returns:** The connections

```crmscript
NSQuoteAgent agent;
Integer associateId;
QuoteConnection[] res = agent.GetConnectionsForAssociate(associateId);
```

