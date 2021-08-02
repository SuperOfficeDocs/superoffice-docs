---
uid: crmscript_ref_NSFindAgent_SaveRestrictionsWithContext2
title: Void SaveRestrictionsWithContext2(String storageType, String providerName, String storageKey, String restrictions, String context)
intellisense: NSFindAgent.SaveRestrictionsWithContext2
keywords: NSFindAgent, SaveRestrictionsWithContext2
so.topic: reference
---

Save an array of restrictions for later use as search criteria (including as dynamic selection and Find). 

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is the intended consumer of the restrictions
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
 - **restrictions** String of restrictions. The ColumnInfo member and the DisplayValues members need NOT be populated; it is enough to provide a name, operator and any values the operator may need. The IsActive is also saved. Values should be encoded using the CultureDataFormatter to ensure compatibility across cultures.
 - **context** Optional context that can be used by FindProvider

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
String restrictions;
String context;
agent.SaveRestrictionsWithContext2(storageType, providerName, storageKey, restrictions, context);
```

