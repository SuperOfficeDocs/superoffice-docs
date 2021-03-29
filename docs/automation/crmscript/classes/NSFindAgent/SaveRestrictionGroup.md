---
title: crmscript_ref_NSFindAgent_SaveRestrictionGroup_String_p_0_String_p_1_String_p_2_NSArchiveRestrictionGroup_p_3_String_p_4
description: NSFindAgent.SaveRestrictionGroup(String p_0, String p_1, String p_2, NSArchiveRestrictionGroup p_3, String p_4)
intellisense: NSFindAgent.SaveRestrictionGroup
sortOrder: 3683
keywords: SaveRestrictionGroup(String,String,String,NSArchiveRestrictionGroup,String)
so.topic: reference
---


Save an array of restrictions as a restriction group for later use as search criteria (including as dynamic selection and Find).



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
* **restrictionGroup:** Information about a group of restrictions
* **context:** Optional context that can be used by FindProvider
* **Returns:** This service call just saves the restrictions.


