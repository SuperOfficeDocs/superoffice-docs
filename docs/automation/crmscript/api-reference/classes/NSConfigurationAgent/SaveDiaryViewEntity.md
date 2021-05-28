---
uid: crmscript_class_nsconfigurationagent_savediaryviewentity
title: NSDiaryViewEntity SaveDiaryViewEntity()
description: CRMScript method in the NSConfigurationAgent class that creates or updates an NSDiaryViewEntity
intellisense: NSConfigurationAgent.SaveDiaryViewEntity
keywords: NSConfigurationAgent, SaveDiaryViewEntity, SaveDiaryViewEntity(NSDiaryViewEntity)
so.topic: reference
---

# SaveDiaryViewEntity()

Updates the existing NSDiaryViewEntity or creates a new NSDiaryViewEntity if the ID parameter is 0.

Returns the new or updated NSDiaryViewEntity.

`NSDiaryViewEntity SaveDiaryViewEntity(NSDiaryViewEntity diaryViewEntity)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| diaryViewEntity | NSDiaryViewEntity | The entity to save. |

## Examples

```crmscript
NSConfiguration  agent;
NSDiaryViewEntity thing = agent.CreateDefaultDiaryViewEntity();
thing = agent.SaveDiaryViewEntity(thing);
```
