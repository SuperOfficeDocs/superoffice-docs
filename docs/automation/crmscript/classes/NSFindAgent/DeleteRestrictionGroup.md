---
title: crmscript_ref_NSFindAgent_DeleteRestrictionGroup_String_p_0_String_p_1_String_p_2_Integer_p_3_String_p_4
description: NSFindAgent.DeleteRestrictionGroup(String p_0, String p_1, String p_2, Integer p_3, String p_4)
intellisense: NSFindAgent.DeleteRestrictionGroup
sortOrder: 3682
keywords: DeleteRestrictionGroup(String,String,String,Integer,String)
so.topic: reference
---


Create a restriction group, initialized with next rank etc.



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
* **rank:** Rank of the group to be deleted.
* **context:** Optional context that can be used by FindProvider
* **Returns:** This service call just saves the restrictions.


