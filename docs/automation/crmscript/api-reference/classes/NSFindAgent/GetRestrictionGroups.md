---
uid: crmscript_ref_NSFindAgent_GetRestrictionGroups
title: NSArchiveRestrictionGroup[] GetRestrictionGroups(String storageType, String providerName, String storageKey, String context)
intellisense: NSFindAgent.GetRestrictionGroups
keywords: NSFindAgent, GetRestrictionGroups
so.topic: reference
---

# NSArchiveRestrictionGroup[] GetRestrictionGroups(String storageType, String providerName, String storageKey, String context)

Return all the restriction groups.

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is the intended consumer of the restrictions
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
 - **context** Optional context that can be used by FindProvider

**Returns:** NSArchiveRestrictionGroup[]

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
String context;
NSArchiveRestrictionGroup[] res = agent.GetRestrictionGroups(storageType, providerName, storageKey, context);
```

