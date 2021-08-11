---
uid: crmscript_ref_NSUserAgent_DecryptAndSaveExternalTokens
title: String DecryptAndSaveExternalTokens(NSTokenManagementInfo tokenManagementInfo)
intellisense: NSUserAgent.DecryptAndSaveExternalTokens
keywords: NSUserAgent, DecryptAndSaveExternalTokens
so.topic: reference
---

# String DecryptAndSaveExternalTokens(NSTokenManagementInfo tokenManagementInfo)

First asks AccessGateway to decrypt the tokens, then saves the external tokens to the DB and returns a key that can be used to retrieve them

**Parameters:**
 - **tokenManagementInfo** Token information.

**Returns:** String

```crmscript
NSUserAgent agent;
NSTokenManagementInfo tokenManagementInfo;
String res = agent.DecryptAndSaveExternalTokens(tokenManagementInfo);
```

