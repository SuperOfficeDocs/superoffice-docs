---
title: crmscript_ref_NSUserAgent_GetAccessToken
description: String GetAccessToken(String appToken, Bool includeCsSession)
intellisense: NSUserAgent.GetAccessToken
keywords: NSUserAgent,GetAccessToken
so.topic: reference
---

Get an access token based on the current user's session.

**Parameters:**
 - **appToken** Application token to get access on behalf of. Optional.
 - **includeCsSession** Initialize CS session for this access token?.

**Returns:** An access token. "8A:xyz123=="

```crmscript
NSUserAgent agent;
String appToken;
Bool includeCsSession;
String res = agent.GetAccessToken(appToken, includeCsSession);
```

