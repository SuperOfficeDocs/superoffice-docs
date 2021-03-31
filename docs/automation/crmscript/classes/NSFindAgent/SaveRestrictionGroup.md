---
title: crmscript_ref_NSFindAgent_SaveRestrictionGroup
description: Void SaveRestrictionGroup(String storageType, String providerName, String storageKey, ArchiveRestrictionGroup restrictionGroup, String context)
intellisense: NSFindAgent.SaveRestrictionGroup
keywords: NSFindAgent,SaveRestrictionGroup
so.topic: reference
---

Save an array of restrictions as a restriction group for later use as search criteria (including as dynamic selection and Find). 

**Parameters:**
 - **storageType** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
 - **providerName** Name of archive provider that is the intended consumer of the restrictions
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
 - **restrictionGroup** Information about a group of restrictions
 - **context** Optional context that can be used by FindProvider

**Returns:** This service call just saves the restrictions.

```crmscript
NSFindAgent agent;
String storageType;
String providerName;
String storageKey;
ArchiveRestrictionGroup restrictionGroup;
String context;
Void res = agent.SaveRestrictionGroup(storageType, providerName, storageKey, restrictionGroup, context);
```

