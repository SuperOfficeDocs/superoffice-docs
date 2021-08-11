---
uid: crmscript_class_nsforeignsystemagent_saveforeignappentity
title: NSForeignAppEntity SaveForeignAppEntity()
description: CRMScript method in the NSForeignSystemAgent class that creates or updates an NSForeignAppEntity
intellisense: NSForeignSystemAgent.SaveForeignAppEntity
keywords: NSForeignSystemAgent, SaveForeignAppEntity, SaveForeignAppEntity(NSForeignAppEntity)
so.topic: reference
---

# SaveForeignAppEntity()

Updates the existing NSForeignAppEntity or creates a new NSForeignAppEntity if the ID parameter is 0.

Returns the new or updated NSForeignAppEntity.

`NSForeignAppEntity SaveForeignAppEntity(NSForeignAppEntity foreignAppEntity)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| foreignAppEntity | NSForeignAppEntity | The entity to save. |

## Examples

```crmscript
NSForeignSystem  agent;
NSForeignAppEntity thing = agent.CreateDefaultForeignAppEntity();
thing = agent.SaveForeignAppEntity(thing);
```
