---
uid: crmscript_ref_NSResourceAgent_IsResourceSubstitutionActive
title: ResourceOverride[] IsResourceSubstitutionActive(String[] resourceNames, String culture)
intellisense: NSResourceAgent.IsResourceSubstitutionActive
keywords: NSResourceAgent, IsResourceSubstitutionActive
so.topic: reference
---

Determine if resource substitution/override is active, globally or for a subset of resources/cultures

**Parameters:**
 - **resourceNames** Array of names of resources for which overrides are sought; if empty, then get the MASTER on/off
 - **culture** .NET culture string; if empty, then get for all cultures (unless resourceName

**Returns:** Array of override objects, empty if there are none; the ResourceValue member is not set by this call

```crmscript
NSResourceAgent agent;
String[] resourceNames;
String culture;
ResourceOverride[] res = agent.IsResourceSubstitutionActive(resourceNames, culture);
```

