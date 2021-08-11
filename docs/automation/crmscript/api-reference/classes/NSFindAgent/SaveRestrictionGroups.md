---
uid: crmscript_ref_NSFindAgent_SaveRestrictionGroups
title: NSArchiveRestrictionGroup[] SaveRestrictionGroups(String storageType, String providerName, String storageKey, NSArchiveRestrictionGroup[] restrictionGroups, String context)
intellisense: NSFindAgent.SaveRestrictionGroups
keywords: NSFindAgent, SaveRestrictionGroups
so.topic: reference
---

# NSArchiveRestrictionGroup[] SaveRestrictionGroups(String storageType, String providerName, String storageKey, NSArchiveRestrictionGroup[] restrictionGroups, String context)

Save and rerank an array of restriction groups, returning the possibly modified array.

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is the intended consumer of the restrictions
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
 - **restrictionGroups** Information about a group of restrictions
 - **context** Optional context that can be used by FindProvider

**Returns:** NSArchiveRestrictionGroup[]

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
NSArchiveRestrictionGroup[] restrictionGroups;
String context;
NSArchiveRestrictionGroup[] res = agent.SaveRestrictionGroups(storageType, providerName, storageKey, restrictionGroups, context);
```

