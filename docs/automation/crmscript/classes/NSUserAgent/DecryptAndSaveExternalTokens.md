---
uid: crmscript_ref_NSUserAgent_DecryptAndSaveExternalTokens
title: String DecryptAndSaveExternalTokens(TokenManagementInfo tokenManagementInfo)
intellisense: NSUserAgent.DecryptAndSaveExternalTokens
keywords: NSUserAgent, DecryptAndSaveExternalTokens
so.topic: reference
---

First asks AccessGateway to decrypt the tokens, then saves the external tokens to the DB and returns a key that can be used to retrieve them

**Parameters:**
 - **tokenManagementInfo** Token information.

**Returns:** Key that can be used to retrieve the tokens

```crmscript
NSUserAgent agent;
TokenManagementInfo tokenManagementInfo;
String res = agent.DecryptAndSaveExternalTokens(tokenManagementInfo);
```

