---
uid: crmscript_ref_NSResourceAgent_SetResourceSubstitution
title: Void SetResourceSubstitution(String resourceName, String resourceValues, String culture, Bool isActive)
intellisense: NSResourceAgent.SetResourceSubstitution
keywords: NSResourceAgent, SetResourceSubstitution
so.topic: reference
---

Create or update a resource substitution

**Parameters:**
 - **resourceName** The name of the resource, without any brackets
 - **resourceValues** The new value of the resource
 - **culture** The .NET culture string
 - **isActive** Is the subsitution now active

**Returns:** This method has no return value

```crmscript
NSResourceAgent agent;
String resourceName;
String resourceValues;
String culture;
Bool isActive;
Void res = agent.SetResourceSubstitution(resourceName, resourceValues, culture, isActive);
```

