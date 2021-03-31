---
title: crmscript_ref_NSUserAgent_GetExternalTokens
description: TokenManagementInfo GetExternalTokens(String key)
intellisense: NSUserAgent.GetExternalTokens
keywords: NSUserAgent,GetExternalTokens
so.topic: reference
---

Retrieve the tokens from the DB based on the given key

**Parameters:**
 - **key** Token retrievel key

**Returns:** Key to retrieve tokens

```crmscript
NSUserAgent agent;
String key;
TokenManagementInfo res = agent.GetExternalTokens(key);
```

