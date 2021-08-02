---
uid: crmscript_ref_NSQuoteAgent_RestoreConnection
title: Void RestoreConnection(Integer quoteConnectionId)
intellisense: NSQuoteAgent.RestoreConnection
keywords: NSQuoteAgent, RestoreConnection
so.topic: reference
---

Restores a connection marked as deleted.

**Parameters:**
 - **quoteConnectionId** Primary key of the connection to restore

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
agent.RestoreConnection(quoteConnectionId);
```

