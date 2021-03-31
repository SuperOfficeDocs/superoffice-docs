---
title: crmscript_ref_NSQuoteAgent_GetConnectionStartupResponse
description: PluginResponse GetConnectionStartupResponse(Integer quoteConnectionId)
intellisense: NSQuoteAgent.GetConnectionStartupResponse
keywords: NSQuoteAgent,GetConnectionStartupResponse
so.topic: reference
---

Returns the PluginResponseInfo for the connection initialization. Does not initialize the connection, just returns what happened when initialize was called.

**Parameters:**
 - **quoteConnectionId** Primary key of the connection

**Returns:** PluginResponseInfo for the connection initialization.

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
PluginResponse res = agent.GetConnectionStartupResponse(quoteConnectionId);
```

