---
uid: crmscript_class_nssaleagent_savesaleentity
title: NSSaleEntity SaveSaleEntity()
description: CRMScript method in the NSSaleAgent class that creates or updates an NSSaleEntity
intellisense: NSSaleAgent.SaveSaleEntity
keywords: NSSaleAgent, SaveSaleEntity, SaveSaleEntity(NSSaleEntity)
so.topic: reference
---

# SaveSaleEntity()

Updates the existing NSSaleEntity or creates a new NSSaleEntity if the ID parameter is 0.

Returns the new or updated NSSaleEntity

`NSSaleEntity SaveSaleEntity(NSSaleEntity saleEntity)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| saleEntity | NSSaleEntity | The entity to save. |

## Examples

```crmscript
NSSale  agent;
NSSaleEntity thing = agent.CreateDefaultSaleEntity();
thing = agent.SaveSaleEntity(thing);
```
