---
title: crmscript_ref_NSResourceAgent_GetResourceSubstitutions_String__p_0_String_p_1_Bool_p_2
description: NSResourceAgent.GetResourceSubstitutions(String[] p_0, String p_1, Bool p_2)
intellisense: NSResourceAgent.GetResourceSubstitutions
keywords: GetResourceSubstitutions(String[],String,Bool)
so.topic: reference
---


Get substitutions for some or all resources for one culture



* **resourceNames:** Array of names of resources for which overrides are sought; if empty, then get all
* **culture:** .NET culture string; if empty, then get all
* **activeOnly:** If true, then only resources with active substitutions will be returned; if false then ALL existing overrides will be returned
* **Returns:** Array of override objects, empty if there are none


