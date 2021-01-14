---
title: Void SaveRestrictionGroup(String storageType, String providerName, String storageKey, NSArchiveRestrictionGroup restrictionGroup, String context)
path: /EJScript/Classes/NSFindAgent/Member functions/Void SaveRestrictionGroup(String p_0, String p_1, String p_2, NSArchiveRestrictionGroup p_3, String p_4)
intellisense: 1
classref: 1
sortOrder: 3683
keywords: SaveRestrictionGroup(String,String,String,NSArchiveRestrictionGroup,String)
---


Save an array of restrictions as a restriction group for later use as search criteria (including as dynamic selection and Find).



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
* **restrictionGroup:** Information about a group of restrictions
* **context:** Optional context that can be used by FindProvider
* **Returns:** This service call just saves the restrictions.


