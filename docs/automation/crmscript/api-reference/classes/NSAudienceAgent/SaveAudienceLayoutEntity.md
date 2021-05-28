---
uid: crmscript_class_nsaudienceagent_saveaudiencelayoutentity
title: NSAudienceLayoutEntity SaveAudienceLayoutEntity()
description: CRMScript method in the NSAudienceAgent class that creates or updates an NSAudienceLayoutEntity
intellisense: NSAudienceAgent.SaveAudienceLayoutEntity
keywords: NSAudienceAgent, SaveAudienceLayoutEntity, SaveAudienceLayoutEntity(NSAudienceLayoutEntity)
so.topic: reference
---

# SaveAudienceLayoutEntity()

Saves an `NSAudienceLayoutEntity`. If the ID is 0, it creates a new entity. Otherwise, if the NSAudienceLayoutEntity exists, it will be updated.

Returns the new or updated NSAudienceLayoutEntity

`NSAudienceLayoutEntity SaveAudienceLayoutEntity(NSAudienceLayoutEntity audienceLayoutEntity)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| audienceLayoutEntity | NSAudienceLayoutEntity | The entity to save. |

## Examples

```crmscript
NSAudience agent;
NSAudienceLayoutEntity thing = agent.CreateDefaultAudienceLayoutEntity();
thing = agent.SaveAudienceLayoutEntity(thing);
```
