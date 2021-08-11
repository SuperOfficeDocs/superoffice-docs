---
uid: crmscript_ref_NSMarketingAgent_VerifyGoogleRecaptcha
title: Bool VerifyGoogleRecaptcha(String token, String optionalSecretKey)
intellisense: NSMarketingAgent.VerifyGoogleRecaptcha
keywords: NSMarketingAgent, VerifyGoogleRecaptcha
so.topic: reference
---

# Bool VerifyGoogleRecaptcha(String token, String optionalSecretKey)

This method will try to verify a Google recaptcha token. The token is gained from the recaptcha frontend component

**Parameters:**
 - **token** The token to be verified
 - **optionalSecretKey** Use an optional secret key instead of the system wide

**Returns:** Bool

```crmscript
NSMarketingAgent agent;
String token;
String optionalSecretKey;
Bool res = agent.VerifyGoogleRecaptcha(token, optionalSecretKey);
```

