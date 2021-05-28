---
uid: crmscript_class_nsblobagent_saveblobentity
title: NSBlobEntity SaveBlobEntity()
description: CRMScript method in the NSBLOBAgent class that creates or updates an NSBlobEntity
intellisense: NSBLOBAgent.SaveBlobEntity
keywords: NSBLOBAgent, SaveBlobEntity, SaveBlobEntity(NSBlobEntity)
so.topic: reference
---

# SaveBlobEntity()

Updates the existing NSBlobEntity or creates a new NSBlobEntity if the ID parameter is 0.

Returns the new or updated NSBlobEntity.

`NSBlobEntity SaveBlobEntity(NSBlobEntity blobEntity)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| blobEntity | NSBlobEntity | The entity to save. |

## Examples

```crmscript
NSBLOB agent;
NSBlobEntity thing = agent.CreateDefaultBlobEntity();
thing = agent.SaveBlobEntity(thing);
```
