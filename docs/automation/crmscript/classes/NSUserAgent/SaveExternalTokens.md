---
uid: crmscript_ref_NSUserAgent_SaveExternalTokens
title: String SaveExternalTokens(TokenManagementInfo tokenManagementInfo)
intellisense: NSUserAgent.SaveExternalTokens
keywords: NSUserAgent, SaveExternalTokens
so.topic: reference
---

Saves the external tokens to the DB and returns a key that can be used to retrieve them

**Parameters:**
 - **tokenManagementInfo** Token information.

**Returns:** Key that can be used to retrieve the tokens

```crmscript
NSUserAgent agent;
TokenManagementInfo tokenManagementInfo;
String res = agent.SaveExternalTokens(tokenManagementInfo);
```

