---
uid: crmscript_ref_NSResourceAgent_IsResourceSubstitutionActive
title: NSResourceOverride[] IsResourceSubstitutionActive(String[] resourceNames, String culture)
intellisense: NSResourceAgent.IsResourceSubstitutionActive
keywords: NSResourceAgent, IsResourceSubstitutionActive
so.topic: reference
---

# NSResourceOverride[] IsResourceSubstitutionActive(String[] resourceNames, String culture)

Determine if resource substitution/override is active, globally or for a subset of resources/cultures

**Parameters:**
 - **resourceNames** Array of names of resources for which overrides are sought; if empty, then get the MASTER on/off
 - **culture** .NET culture string; if empty, then get for all cultures (unless resourceName

**Returns:** NSResourceOverride[]

```crmscript
NSResourceAgent agent;
String[] resourceNames;
String culture;
NSResourceOverride[] res = agent.IsResourceSubstitutionActive(resourceNames, culture);
```

