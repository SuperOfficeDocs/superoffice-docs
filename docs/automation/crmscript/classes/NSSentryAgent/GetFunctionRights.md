---
uid: crmscript_ref_NSSentryAgent_GetFunctionRights
title: StringArray GetFunctionRights()
intellisense: NSSentryAgent.GetFunctionRights
keywords: NSSentryAgent, GetFunctionRights
so.topic: reference
---

Get a string array of all functions rights for the role of the current associate.


**Returns:** String array with the technical names of assigned function rights

```crmscript
NSSentryAgent agent;
StringArray res = agent.GetFunctionRights();
```

