---
title: crmscript_ref_NSConfigurationAgent_GetWwwUrl
description: String GetWwwUrl(String client)
intellisense: NSConfigurationAgent.GetWwwUrl
keywords: NSConfigurationAgent,GetWwwUrl
so.topic: reference
---

Will get the default URL used for the logo, from the [NetServices] PageUrl preferencec, with tags substituted.

**Parameters:**
 - **client** The name for the client application, like 'CS' or 'SM.web', used for the <clie> variable

**Returns:** URL to be used when clicking the logo

```crmscript
NSConfigurationAgent agent;
String client;
String res = agent.GetWwwUrl(client);
```

