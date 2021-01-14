---
title: Void DeleteRestrictionGroup(String storageType, String providerName, String storageKey, Integer rank, String context)
path: /EJScript/Classes/NSFindAgent/Member functions/Void DeleteRestrictionGroup(String p_0, String p_1, String p_2, Integer p_3, String p_4)
intellisense: 1
classref: 1
sortOrder: 3682
keywords: DeleteRestrictionGroup(String,String,String,Integer,String)
---


Create a restriction group, initialized with next rank etc.



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
* **rank:** Rank of the group to be deleted.
* **context:** Optional context that can be used by FindProvider
* **Returns:** This service call just saves the restrictions.


