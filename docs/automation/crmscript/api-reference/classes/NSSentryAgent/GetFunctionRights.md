---
uid: crmscript_ref_NSSentryAgent_GetFunctionRights
title: String[] GetFunctionRights()
intellisense: NSSentryAgent.GetFunctionRights
keywords: NSSentryAgent, GetFunctionRights
so.topic: reference
---

Get a string array of all functions rights for the role of the current associate.


**Returns:** String array with the technical names of assigned function rights

```crmscript
NSSentryAgent agent;
String[] res = agent.GetFunctionRights();
```

