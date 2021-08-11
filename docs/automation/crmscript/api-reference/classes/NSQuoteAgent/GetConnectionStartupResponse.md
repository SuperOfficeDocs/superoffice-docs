---
uid: crmscript_ref_NSQuoteAgent_GetConnectionStartupResponse
title: NSPluginResponse GetConnectionStartupResponse(Integer quoteConnectionId)
intellisense: NSQuoteAgent.GetConnectionStartupResponse
keywords: NSQuoteAgent, GetConnectionStartupResponse
so.topic: reference
---

# NSPluginResponse GetConnectionStartupResponse(Integer quoteConnectionId)

Returns the PluginResponseInfo for the connection initialization. Does not initialize the connection, just returns what happened when initialize was called.

**Parameters:**
 - **quoteConnectionId** Primary key of the connection

**Returns:** NSPluginResponse[]

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
NSPluginResponse res = agent.GetConnectionStartupResponse(quoteConnectionId);
```

