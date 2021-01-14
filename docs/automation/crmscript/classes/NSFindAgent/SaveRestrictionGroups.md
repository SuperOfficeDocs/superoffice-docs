---
title: NSArchiveRestrictionGroup[] SaveRestrictionGroups(String storageType, String providerName, String storageKey, NSArchiveRestrictionGroup[] restrictionGroups, String context)
path: /EJScript/Classes/NSFindAgent/Member functions/NSArchiveRestrictionGroup[] SaveRestrictionGroups(String p_0, String p_1, String p_2, NSArchiveRestrictionGroup[] p_3, String p_4)
intellisense: 1
classref: 1
sortOrder: 3661
keywords: SaveRestrictionGroups(String,String,String,NSArchiveRestrictionGroup[],String)
---


Save and rerank an array of restriction groups, returning the possibly modified array.



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
* **restrictionGroups:** Information about a group of restrictions
* **context:** Optional context that can be used by FindProvider
* **Returns:** The new restriction group.


