---
title: crmscript_ref_NSPreferenceAgent_UpdateNetServicesStatus
description: Void UpdateNetServicesStatus(String xmlOrJson)
intellisense: NSPreferenceAgent.UpdateNetServicesStatus
keywords: NSPreferenceAgent,UpdateNetServicesStatus
so.topic: reference
---

Update the NetServices preferences with values contained in the content from the Status URL

**Parameters:**
 - **xmlOrJson** The text that was returned by getting the Status URL

**Returns:** This method has no return value

```crmscript
NSPreferenceAgent agent;
String xmlOrJson;
Void res = agent.UpdateNetServicesStatus(xmlOrJson);
```

