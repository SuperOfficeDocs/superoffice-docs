---
uid: crmscript_class_nsselectionagent_saveselectionentity
title: NSSelectionEntity SaveSelectionEntity()
description: CRMScript method in the NSSelectionAgent class that creates or updates an NSSelectionEntity
intellisense: NSSelectionAgent.SaveSelectionEntity
keywords: NSSelectionAgent, SaveSelectionEntity, SaveSelectionEntity(NSSelectionEntity)
so.topic: reference
---

# SaveSelectionEntity()

Updates the existing NSSelectionEntity or creates a new NSSelectionEntity if the ID parameter is 0.

Returns the new or updated NSSelectionEntity

`NSSelectionEntity SaveSelectionEntity(NSSelectionEntity selectionEntity)`

## Parameters

| selectionEntity | NSSelectionEntity | The entity to save. |

## Examples

```crmscript
NSSelection  agent;
NSSelectionEntity thing = agent.CreateDefaultSelectionEntity();
thing = agent.SaveSelectionEntity(thing);
```
