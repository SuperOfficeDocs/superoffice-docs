---
uid: crmscript_ref_NSFindAgent_SaveRestrictions2
title: Void SaveRestrictions2(String storageType, String providerName, String storageKey, String restrictions)
intellisense: NSFindAgent.SaveRestrictions2
keywords: NSFindAgent, SaveRestrictions2
so.topic: reference
---

Save an array of restrictions for later use as search criteria (including as dynamic selection and Find). 

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is the intended consumer of the restrictions
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
 - **restrictions** String of restrictions. "name = 'SuperOffice'" The ColumnInfo member and the DisplayValues members need NOT be populated; it is enough to provide a name, operator and any values the operator may need. The IsActive is also saved. Values should be encoded using the CultureDataFormatter to ensure compatibility across cultures.


```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
String restrictions;
agent.SaveRestrictions2(storageType, providerName, storageKey, restrictions);
```

