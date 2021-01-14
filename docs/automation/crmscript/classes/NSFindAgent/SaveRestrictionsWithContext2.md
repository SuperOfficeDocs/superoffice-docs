---
title: Void SaveRestrictionsWithContext2(String storageType, String providerName, String storageKey, String restrictions, String context)
path: /EJScript/Classes/NSFindAgent/Member functions/Void SaveRestrictionsWithContext2(String p_0, String p_1, String p_2, String p_3, String p_4)
intellisense: 1
classref: 1
sortOrder: 3687
keywords: SaveRestrictionsWithContext2(String,String,String,String,String)
---


Save an array of restrictions for later use as search criteria (including as dynamic selection and Find).



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
* **restrictions:** String of restrictions. The ColumnInfo member and the DisplayValues members need NOT be populated; it is enough to provide a name, operator and any values the operator may need. The IsActive is also saved. Values should be encoded using the CultureDataFormatter to ensure compatibility across cultures.
* **context:** Optional context that can be used by FindProvider
* **Returns:** This service call just saves the restrictions. See SaveRestrictionsAndGetCriteriaInformation if you would like the restrictions returned as criteria immediately, in one roundtrip


