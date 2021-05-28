---
uid: crmscript_class_nsprojectagent_saveprojectevententity
title: NSProjectEventEntity SaveProjectEventEntity()
description: CRMScript method in the Attachment class that creates or updates an NSProjectEventEntity
intellisense: NSProjectAgent.SaveProjectEventEntity
keywords: NSProjectAgent, SaveProjectEventEntity, SaveProjectEventEntity(NSProjectEventEntity)
so.topic: reference
---

# SaveProjectEventEntity()

Updates the existing NSProjectEventEntity or creates a new NSProjectEventEntity if the ID parameter is 0.

Returns the new or updated NSProjectEventEntity.

`NSProjectEventEntity SaveProjectEventEntity(NSProjectEventEntity projectEventEntity)`

## Parameter

| Parameter | Type | Description |
|---|---|---|
| projectEventEntity | NSProjectEventEntity | The entity to save. |

## Examples

```crmscript
NSProject  agent;
NSProjectEventEntity thing = agent.CreateDefaultProjectEventEntity();
thing = agent.SaveProjectEventEntity(thing);
```
