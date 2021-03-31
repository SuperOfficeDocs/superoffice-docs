---
uid: crmscript_ref_NSFindAgent_GetRestrictionGroup
title: ArchiveRestrictionGroup GetRestrictionGroup(String storageType, String providerName, String storageKey, Integer rank, String context)
intellisense: NSFindAgent.GetRestrictionGroup
keywords: NSFindAgent, GetRestrictionGroup
so.topic: reference
---

Return the restriction group with given rank or a blank carrier.

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is the intended consumer of the restrictions
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
 - **rank** Rank of the group to be deleted.
 - **context** Optional context that can be used by FindProvider

**Returns:** The new restriction group.

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
Integer rank;
String context;
ArchiveRestrictionGroup res = agent.GetRestrictionGroup(storageType, providerName, storageKey, rank, context);
```

