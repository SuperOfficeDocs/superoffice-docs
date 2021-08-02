---
uid: crmscript_ref_NSUserAgent_GetExternalTokens
title: NSTokenManagementInfo GetExternalTokens(String key)
intellisense: NSUserAgent.GetExternalTokens
keywords: NSUserAgent, GetExternalTokens
so.topic: reference
---

Retrieve the tokens from the DB based on the given key

**Parameters:**
 - **key** Token retrievel key

**Returns:** NSTokenManagementInfo

```crmscript
NSUserAgent agent;
String key;
NSTokenManagementInfo res = agent.GetExternalTokens(key);
```

