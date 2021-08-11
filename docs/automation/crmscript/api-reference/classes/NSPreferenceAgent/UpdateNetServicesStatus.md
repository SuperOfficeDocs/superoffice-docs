---
uid: crmscript_ref_NSPreferenceAgent_UpdateNetServicesStatus
title: Void UpdateNetServicesStatus(String xmlOrJson)
intellisense: NSPreferenceAgent.UpdateNetServicesStatus
keywords: NSPreferenceAgent, UpdateNetServicesStatus
so.topic: reference
---

# Void UpdateNetServicesStatus(String xmlOrJson)

Update the NetServices preferences with values contained in the content from the Status URL

**Parameters:**
 - **xmlOrJson** The text that was returned by getting the Status URL

```crmscript
NSPreferenceAgent agent;
String xmlOrJson;
agent.UpdateNetServicesStatus(xmlOrJson);
```

