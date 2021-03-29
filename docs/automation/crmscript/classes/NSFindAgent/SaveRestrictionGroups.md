---
title: crmscript_ref_NSFindAgent_SaveRestrictionGroups_String_p_0_String_p_1_String_p_2_NSArchiveRestrictionGroup__p_3_String_p_4
description: NSFindAgent.SaveRestrictionGroups(String p_0, String p_1, String p_2, NSArchiveRestrictionGroup[] p_3, String p_4)
intellisense: NSFindAgent.SaveRestrictionGroups
sortOrder: 3661
keywords: SaveRestrictionGroups(String,String,String,NSArchiveRestrictionGroup[],String)
so.topic: reference
---


Save and rerank an array of restriction groups, returning the possibly modified array.



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
* **restrictionGroups:** Information about a group of restrictions
* **context:** Optional context that can be used by FindProvider
* **Returns:** The new restriction group.


