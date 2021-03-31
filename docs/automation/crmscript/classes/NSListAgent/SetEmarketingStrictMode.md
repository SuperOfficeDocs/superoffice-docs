---
uid: crmscript_ref_NSListAgent_SetEmarketingStrictMode
title: Void SetEmarketingStrictMode(Bool enable)
intellisense: NSListAgent.SetEmarketingStrictMode
keywords: NSListAgent, SetEmarketingStrictMode
so.topic: reference
---

Turn on the Emarketing strict mode, which will enable full GDPR rules concerning Emarketing consents and subscriptions

**Parameters:**
 - **enable** Set to true to enable strict mode

**Returns:** A void return

```crmscript
NSListAgent agent;
Bool enable;
Void res = agent.SetEmarketingStrictMode(enable);
```

