---
title: crmscript_ref_NSErpSyncAgent_TestConnectorUrl
description: Integer TestConnectorUrl(String url)
intellisense: NSErpSyncAgent.TestConnectorUrl
keywords: NSErpSyncAgent,TestConnectorUrl
so.topic: reference
---

Test if connector urls anwers

**Parameters:**
 - **url** The url to test connection on

**Returns:** Enum response says ok or what is wrong

```crmscript
NSErpSyncAgent agent;
String url;
Integer res = agent.TestConnectorUrl(url);
```

