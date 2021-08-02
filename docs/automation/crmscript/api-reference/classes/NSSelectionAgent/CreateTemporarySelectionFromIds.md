---
uid: crmscript_ref_NSSelectionAgent_CreateTemporarySelectionFromIds
title: NSSelectionEntity CreateTemporarySelectionFromIds(Integer[] ids, Integer targetTableNumber)
intellisense: NSSelectionAgent.CreateTemporarySelectionFromIds
keywords: NSSelectionAgent, CreateTemporarySelectionFromIds
so.topic: reference
---

Creates a temporary selection with members from a collection of entity id's.

**Parameters:**
 - **ids** A collection of Ids to copy into the temporary selection as members. The ids are primary keys of entities defined by the targetTableNumber parameter.
 - **targetTableNumber** The type of selection to create.

**Returns:** NSSelectionEntity

```crmscript
NSSelectionAgent agent;
Integer[] ids;
Integer targetTableNumber;
NSSelectionEntity res = agent.CreateTemporarySelectionFromIds(ids, targetTableNumber);
```

