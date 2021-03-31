---
uid: crmscript_ref_NSFindAgent_SaveRestrictionsAndGetCriteriaInformation
title: CriteriaInformation SaveRestrictionsAndGetCriteriaInformation(String storageType, String providerName, String storageKey, ArchiveRestrictionInfoArray restrictions, StringArray staticColumns)
intellisense: NSFindAgent.SaveRestrictionsAndGetCriteriaInformation
keywords: NSFindAgent, SaveRestrictionsAndGetCriteriaInformation
so.topic: reference
---

Save an array of restrictions for later use as search criteria (including as dynamic selection and Find). Then, return the same result as a call to GetCriteriaInformation would have done. The purpose is to encapsulate saving and updating of a GUI in one round trip.

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is the intended consumer of the restrictions
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
 - **restrictions** Array of restrictions. The ColumnInfo member and the DisplayValues members need NOT be populated; it is enough to provide a name, operator and any values the operator may need. The IsActive is also saved. Values should be encoded using the CultureDataFormatter to ensure compatibility across cultures.
 - **staticColumns** Optional array of restrictions that are to be EXCLUDED from the CriteriaArchiveRows part of the result. In the Find dialogs, that corresponds to the 'static' fields, to avoid duplicating them in the 'Match also' criteria list. This array can be null, indicating that all restrictions should be included in the criteria list.

**Returns:** The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
ArchiveRestrictionInfoArray restrictions;
StringArray staticColumns;
CriteriaInformation res = agent.SaveRestrictionsAndGetCriteriaInformation(storageType, providerName, storageKey, restrictions, staticColumns);
```

