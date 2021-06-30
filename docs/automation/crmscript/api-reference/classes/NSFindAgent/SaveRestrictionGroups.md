---
uid: crmscript_ref_NSFindAgent_SaveRestrictionGroups
title: ArchiveRestrictionGroup[] SaveRestrictionGroups(String storageType, String providerName, String storageKey, ArchiveRestrictionGroup[] restrictionGroups, String context)
intellisense: NSFindAgent.SaveRestrictionGroups
keywords: NSFindAgent, SaveRestrictionGroups
so.topic: reference
---

Save and rerank an array of restriction groups, returning the possibly modified array.

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is the intended consumer of the restrictions
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
 - **restrictionGroups** Information about a group of restrictions
 - **context** Optional context that can be used by FindProvider

**Returns:** The new restriction group.

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
ArchiveRestrictionGroup[] restrictionGroups;
String context;
ArchiveRestrictionGroup[] res = agent.SaveRestrictionGroups(storageType, providerName, storageKey, restrictionGroups, context);
```

