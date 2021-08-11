---
uid: crmscript_ref_NSResourceAgent_GetResourceSubstitutions
title: NSResourceOverride[] GetResourceSubstitutions(String[] resourceNames, String culture, Bool activeOnly)
intellisense: NSResourceAgent.GetResourceSubstitutions
keywords: NSResourceAgent, GetResourceSubstitutions
so.topic: reference
---

# NSResourceOverride[] GetResourceSubstitutions(String[] resourceNames, String culture, Bool activeOnly)

Get substitutions for some or all resources for one culture

**Parameters:**
 - **resourceNames** Array of names of resources for which overrides are sought; if empty, then get all
 - **culture** .NET culture string; if empty, then get all
 - **activeOnly** If true, then only resources with active substitutions will be returned; if false then ALL existing overrides will be returned

**Returns:** NSResourceOverride[]

```crmscript
NSResourceAgent agent;
String[] resourceNames;
String culture;
Bool activeOnly;
NSResourceOverride[] res = agent.GetResourceSubstitutions(resourceNames, culture, activeOnly);
```

