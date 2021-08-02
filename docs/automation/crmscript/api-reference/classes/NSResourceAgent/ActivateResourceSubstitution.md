---
uid: crmscript_ref_NSResourceAgent_ActivateResourceSubstitution
title: Void ActivateResourceSubstitution(String resourceName, String culture, Bool isActive)
intellisense: NSResourceAgent.ActivateResourceSubstitution
keywords: NSResourceAgent, ActivateResourceSubstitution
so.topic: reference
---

Activate or deactive a resource substitution for one or more cultures

**Parameters:**
 - **resourceName** The name of the resource, without any brackets; if blank then this is the MASTER SWITCH for the override system
 - **culture** The .NET culture string; if blank, then ALL substitutions for this resource will be affected
 - **isActive** New status of override

```crmscript
NSResourceAgent agent;
String resourceName;
String culture;
Bool isActive;
agent.ActivateResourceSubstitution(resourceName, culture, isActive);
```

