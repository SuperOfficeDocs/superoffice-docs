---
uid: crmscript_class_nsprojectagent_saveprojectentity
title: NSProjectEntity SaveProjectEntity()
description: CRMScript method in the Attachment class that creates or updates an NSProjectEntity
intellisense: NSProjectAgent.SaveProjectEntity
keywords: NSProjectAgent, SaveProjectEntity
so.topic: reference
---

# SaveProjectEntity()

Updates the existing NSProjectEntity or creates a new NSProjectEntity if the  ID parameter is 0.

**Returns:** New or updated NSProjectEntity

`NSProjectEntity SaveProjectEntity(NSProjectEntity projectEntity)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| projectEntity | NSProjectEntity | The entity to save. |

## Examples

```crmscript
NSProject  agent;
NSProjectEntity thing = agent.CreateDefaultProjectEntity();
thing = agent.SaveProjectEntity(thing);
```
