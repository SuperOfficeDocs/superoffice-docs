---
uid: crmscript_ref_NSFindAgent_SaveRestrictionsAndGetCriteriaInformation2
title: NSCriteriaInformation SaveRestrictionsAndGetCriteriaInformation2(String storageType, String providerName, String storageKey, String restrictions, String staticColumns)
intellisense: NSFindAgent.SaveRestrictionsAndGetCriteriaInformation2
keywords: NSFindAgent, SaveRestrictionsAndGetCriteriaInformation2
so.topic: reference
---

# NSCriteriaInformation SaveRestrictionsAndGetCriteriaInformation2(String storageType, String providerName, String storageKey, String restrictions, String staticColumns)

Save an array of restrictions for later use as search criteria (including as dynamic selection and Find). Then, return the same result as a call to GetCriteriaInformation would have done. The purpose is to encapsulate saving and updating of a GUI in one round trip.

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is the intended consumer of the restrictions
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
 - **restrictions** String of restrictions. The ColumnInfo member and the DisplayValues members need NOT be populated; it is enough to provide a name, operator and any values the operator may need. The IsActive is also saved. Values should be encoded using the CultureDataFormatter to ensure compatibility across cultures.
 - **staticColumns** Optional string of comma-separated columns that are to be EXCLUDED from the CriteriaArchiveRows part of the result. In the Find dialogs, that corresponds to the 'static' fields, to avoid duplicating them in the 'Match also' criteria list. This array can be null, indicating that all restrictions should be included in the criteria list.

**Returns:** NSCriteriaInformation

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
String restrictions;
String staticColumns;
NSCriteriaInformation res = agent.SaveRestrictionsAndGetCriteriaInformation2(storageType, providerName, storageKey, restrictions, staticColumns);
```

