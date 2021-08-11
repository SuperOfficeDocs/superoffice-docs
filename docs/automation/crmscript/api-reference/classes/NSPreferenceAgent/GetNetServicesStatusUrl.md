---
uid: crmscript_ref_NSPreferenceAgent_GetNetServicesStatusUrl
title: String GetNetServicesStatusUrl()
intellisense: NSPreferenceAgent.GetNetServicesStatusUrl
keywords: NSPreferenceAgent, GetNetServicesStatusUrl
so.topic: reference
---

# String GetNetServicesStatusUrl()

Returns URL to status service. e.g. 'https://help.superoffice.com/sodispatcher/v1/status' Returns NULL if status does not need to be checked yet.

**Returns:** String

```crmscript
NSPreferenceAgent agent;
String res = agent.GetNetServicesStatusUrl();
```

