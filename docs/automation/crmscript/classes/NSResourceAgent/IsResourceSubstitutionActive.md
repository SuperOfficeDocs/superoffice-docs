---
title: NSResourceOverride[] IsResourceSubstitutionActive(String[] resourceNames, String culture)
path: /EJScript/Classes/NSResourceAgent/Member functions/NSResourceOverride[] IsResourceSubstitutionActive(String[] p_0, String p_1)
intellisense: 1
classref: 1
keywords: IsResourceSubstitutionActive(String[],String)
---


Determine if resource substitution/override is active, globally or for a subset of resources/cultures



* **resourceNames:** Array of names of resources for which overrides are sought; if empty, then get the MASTER on/off
* **culture:** .NET culture string; if empty, then get for all cultures (unless resourceName
* **Returns:** Array of override objects, empty if there are none; the ResourceValue member is not set by this call


