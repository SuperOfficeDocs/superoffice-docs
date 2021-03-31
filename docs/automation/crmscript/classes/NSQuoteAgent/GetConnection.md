---
title: crmscript_ref_NSQuoteAgent_GetConnection
description: QuoteConnection GetConnection(Integer quoteConnectionId)
intellisense: NSQuoteAgent.GetConnection
keywords: NSQuoteAgent,GetConnection
so.topic: reference
---

Returns the specified connection.

**Parameters:**
 - **quoteConnectionId** Primary key of the connection

**Returns:** The connection

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
QuoteConnection res = agent.GetConnection(quoteConnectionId);
```

