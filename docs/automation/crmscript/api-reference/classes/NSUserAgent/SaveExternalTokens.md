---
uid: crmscript_ref_NSUserAgent_SaveExternalTokens
title: String SaveExternalTokens(NSTokenManagementInfo tokenManagementInfo)
intellisense: NSUserAgent.SaveExternalTokens
keywords: NSUserAgent, SaveExternalTokens
so.topic: reference
---

# String SaveExternalTokens(NSTokenManagementInfo tokenManagementInfo)

Saves the external tokens to the DB and returns a key that can be used to retrieve them

**Parameters:**
 - **tokenManagementInfo** Token information.

**Returns:** String

```crmscript
NSUserAgent agent;
NSTokenManagementInfo tokenManagementInfo;
String res = agent.SaveExternalTokens(tokenManagementInfo);
```

