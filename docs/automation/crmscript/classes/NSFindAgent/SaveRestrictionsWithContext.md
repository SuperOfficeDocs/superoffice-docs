---
title: crmscript_ref_NSFindAgent_SaveRestrictionsWithContext_String_p_0_String_p_1_String_p_2_NSArchiveRestrictionInfo__p_3_String_p_4
description: NSFindAgent.SaveRestrictionsWithContext(String p_0, String p_1, String p_2, NSArchiveRestrictionInfo[] p_3, String p_4)
intellisense: NSFindAgent.SaveRestrictionsWithContext
sortOrder: 3686
keywords: SaveRestrictionsWithContext(String,String,String,NSArchiveRestrictionInfo[],String)
so.topic: reference
---


Save an array of restrictions for later use as search criteria (including as dynamic selection and Find).



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
* **restrictions:** Array of restrictions. The ColumnInfo member and the DisplayValues members need NOT be populated; it is enough to provide a name, operator and any values the operator may need. The IsActive is also saved. Values should be encoded using the CultureDataFormatter to ensure compatibility across cultures.
* **context:** Optional context that can be used by FindProvider
* **Returns:** This service call just saves the restrictions. See SaveRestrictionsAndGetCriteriaInformation if you would like the restrictions returned as criteria immediately, in one roundtrip


