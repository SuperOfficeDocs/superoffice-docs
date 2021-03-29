---
title: crmscript_ref_NSFindAgent_CreateRestrictionGroup_String_p_0_String_p_1_String_p_2_String_p_3
description: NSFindAgent.CreateRestrictionGroup(String p_0, String p_1, String p_2, String p_3)
intellisense: NSFindAgent.CreateRestrictionGroup
sortOrder: 3658
keywords: CreateRestrictionGroup(String,String,String,String)
so.topic: reference
---


Create a restriction group, initialized with next rank etc.



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
* **context:** Optional context that can be used by FindProvider
* **Returns:** The new restriction group.


