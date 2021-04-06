---
uid: crmscript_ref_NSFindAgent_SaveRestrictions
title: Void SaveRestrictions(String storageType, String providerName, String storageKey, ArchiveRestrictionInfoArray restrictions)
intellisense: NSFindAgent.SaveRestrictions
keywords: NSFindAgent, SaveRestrictions
so.topic: reference
---

Save an array of restrictions for later use as search criteria (including as dynamic selection and Find). 

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is the intended consumer of the restrictions
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
 - **restrictions** Array of restrictions. The ColumnInfo member and the DisplayValues members need NOT be populated; it is enough to provide a name, operator and any values the operator may need. The IsActive is also saved. Values should be encoded using the CultureDataFormatter to ensure compatibility across cultures.

**Returns:** This service call just saves the restrictions. See SaveRestrictionsAndGetCriteriaInformation if you would like the restrictions returned as criteria immediately, in one roundtrip

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
ArchiveRestrictionInfoArray restrictions;
Void res = agent.SaveRestrictions(storageType, providerName, storageKey, restrictions);
```

