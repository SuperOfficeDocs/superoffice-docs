---
uid: crmscript_class_nspersonagent_savepersonentity
title: NSPersonEntity SavePersonEntity()
description: CRMScript method in the Attachment class that creates or updates an NSPersonEntity
intellisense: NSPersonAgent.SavePersonEntity
keywords: NSPersonAgent, SavePersonEntity, SavePersonEntity(NSPersonEntity)
so.topic: reference
---

# SavePersonEntity()

Updates the existing NSPersonEntity or creates a new NSPersonEntity if the ID parameter is 0.

Returns the new or updated NSPersonEntity.

`NSPersonEntity SavePersonEntity(NSPersonEntity personEntity)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| personEntity | NSPersonEntity | The entity to save. |

## Examples

```crmscript
NSPerson  agent;
NSPersonEntity thing = agent.CreateDefaultPersonEntity();
thing = agent.SavePersonEntity(thing);
```
