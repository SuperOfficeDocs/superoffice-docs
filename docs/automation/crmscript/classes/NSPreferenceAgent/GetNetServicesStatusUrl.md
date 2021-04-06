---
uid: crmscript_ref_NSPreferenceAgent_GetNetServicesStatusUrl
title: String GetNetServicesStatusUrl()
intellisense: NSPreferenceAgent.GetNetServicesStatusUrl
keywords: NSPreferenceAgent, GetNetServicesStatusUrl
so.topic: reference
---

Returns URL to status service. e.g. 'https://help.superoffice.com/sodispatcher/v1/status' Returns NULL if status does not need to be checked yet.


**Returns:** NULL or URL of the status service that returns an XML or JSON block.

```crmscript
NSPreferenceAgent agent;
String res = agent.GetNetServicesStatusUrl();
```

