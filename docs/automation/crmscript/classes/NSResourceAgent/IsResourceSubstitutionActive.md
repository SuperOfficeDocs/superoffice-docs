---
title: crmscript_ref_NSResourceAgent_IsResourceSubstitutionActive_String__p_0_String_p_1
description: NSResourceAgent.IsResourceSubstitutionActive(String[] p_0, String p_1)
intellisense: NSResourceAgent.IsResourceSubstitutionActive
keywords: IsResourceSubstitutionActive(String[],String)
so.topic: reference
---


Determine if resource substitution/override is active, globally or for a subset of resources/cultures



* **resourceNames:** Array of names of resources for which overrides are sought; if empty, then get the MASTER on/off
* **culture:** .NET culture string; if empty, then get for all cultures (unless resourceName
* **Returns:** Array of override objects, empty if there are none; the ResourceValue member is not set by this call


