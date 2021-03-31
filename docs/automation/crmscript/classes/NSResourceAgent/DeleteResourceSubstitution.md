---
title: crmscript_ref_NSResourceAgent_DeleteResourceSubstitution
description: Void DeleteResourceSubstitution(String resourceName, String culture)
intellisense: NSResourceAgent.DeleteResourceSubstitution
keywords: NSResourceAgent,DeleteResourceSubstitution
so.topic: reference
---

Permanentely delete a resource substitution for one or more cultures

**Parameters:**
 - **resourceName** The name of the resource, without any brackets
 - **culture** The .NET culture string; if blank, then ALL substitutions for this resource will be dropped

**Returns:** This method has no return value

```crmscript
NSResourceAgent agent;
String resourceName;
String culture;
Void res = agent.DeleteResourceSubstitution(resourceName, culture);
```

