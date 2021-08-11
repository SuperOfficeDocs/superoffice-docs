---
uid: crmscript_ref_NSFindAgent_DeleteRestrictionGroup
title: Void DeleteRestrictionGroup(String storageType, String providerName, String storageKey, Integer rank, String context)
intellisense: NSFindAgent.DeleteRestrictionGroup
keywords: NSFindAgent, DeleteRestrictionGroup
so.topic: reference
---

# Void DeleteRestrictionGroup(String storageType, String providerName, String storageKey, Integer rank, String context)

Create a restriction group, initialized with next rank etc.

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is the intended consumer of the restrictions
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
 - **rank** Rank of the group to be deleted.
 - **context** Optional context that can be used by FindProvider

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
Integer rank;
String context;
agent.DeleteRestrictionGroup(storageType, providerName, storageKey, rank, context);
```

