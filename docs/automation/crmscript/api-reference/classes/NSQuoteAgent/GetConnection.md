---
uid: crmscript_ref_NSQuoteAgent_GetConnection
title: NSQuoteConnection GetConnection(Integer quoteConnectionId)
intellisense: NSQuoteAgent.GetConnection
keywords: NSQuoteAgent, GetConnection
so.topic: reference
---

# NSQuoteConnection GetConnection(Integer quoteConnectionId)

Returns the specified connection.

**Parameters:**
 - **quoteConnectionId** Primary key of the connection

**Returns:** NSQuoteConnection

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
NSQuoteConnection res = agent.GetConnection(quoteConnectionId);
```

