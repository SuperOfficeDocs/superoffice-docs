---
uid: crmscript_class_nscontactagent_savecontactentity
title: NSContactEntity SaveContactEntity()
description: CRMScript method in the NSContactAgent class that creates or updates an NSContactEntity
intellisense: NSContactAgent.SaveContactEntity
keywords: NSContactAgent, SaveContactEntity, SaveContactEntity(NSContactEntity)
so.topic: reference
---

# SaveContactEntity()

Updates the existing NSContactEntity or creates a new NSContactEntity if the ID parameter is 0.

Returns the new or updated NSContactEntity

`NSContactEntity SaveContactEntity(NSContactEntity contactEntity)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| contactEntity | NSContactEntity | The entity to save. |

## Examples

```crmscript
NSContact  agent;
NSContactEntity thing = agent.CreateDefaultContactEntity();
thing = agent.SaveContactEntity(thing);
```
