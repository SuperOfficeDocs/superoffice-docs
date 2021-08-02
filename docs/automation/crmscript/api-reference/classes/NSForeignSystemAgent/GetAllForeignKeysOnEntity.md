---
uid: crmscript_ref_NSForeignSystemAgent_GetAllForeignKeysOnEntity
title: StringDictionary GetAllForeignKeysOnEntity(String entityType, Integer entityId)
intellisense: NSForeignSystemAgent.GetAllForeignKeysOnEntity
keywords: NSForeignSystemAgent, GetAllForeignKeysOnEntity
so.topic: reference
---

Get a list of foreignkeys ('app.device.key') and their values ('123') that belong to the specified entity.

**Parameters:**
 - **entityType** Entity type (table name): 'contact', 'project' etc.
 - **entityId** Primary key of Entity

**Returns:** StringDictionary

```crmscript
NSForeignSystemAgent agent;
String entityType;
Integer entityId;
StringDictionary res = agent.GetAllForeignKeysOnEntity(entityType, entityId);
```

