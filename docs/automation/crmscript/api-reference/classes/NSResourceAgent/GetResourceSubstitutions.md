---
uid: crmscript_ref_NSResourceAgent_GetResourceSubstitutions
title: ResourceOverride[] GetResourceSubstitutions(String[] resourceNames, String culture, Bool activeOnly)
intellisense: NSResourceAgent.GetResourceSubstitutions
keywords: NSResourceAgent, GetResourceSubstitutions
so.topic: reference
---

Get substitutions for some or all resources for one culture

**Parameters:**
 - **resourceNames** Array of names of resources for which overrides are sought; if empty, then get all
 - **culture** .NET culture string; if empty, then get all
 - **activeOnly** If true, then only resources with active substitutions will be returned; if false then ALL existing overrides will be returned

**Returns:** Array of override objects, empty if there are none

```crmscript
NSResourceAgent agent;
String[] resourceNames;
String culture;
Bool activeOnly;
ResourceOverride[] res = agent.GetResourceSubstitutions(resourceNames, culture, activeOnly);
```

