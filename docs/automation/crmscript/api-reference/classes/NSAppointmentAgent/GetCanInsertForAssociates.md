---
uid: crmscript_class_nsappointmentagent_getcaninsertforassociates
title: Bool[] GetCanInsertForAssociates()
intellisense: NSAppointmentAgent.GetCanInsertForAssociates
keywords: NSAppointmentAgent, GetCanInsertForAssociates, GetCanInsertForAssociates(Integer[])
so.topic: reference
---

# GetCanInsertForAssociates()

Checks if the current associate can create appointments in the diary of other associates.

Returns an array of Bool corresponding to the associate array input parameter.

`Bool[] GetCanInsertForAssociates(Integer[] associateIds)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| associateIds | Integer[] | Array of associate IDs to check for |

## Example

```crmscript
NSAppointmentAgent agent;
Integer[] associateIds;
Bool[] res = agent.GetCanInsertForAssociates(associateIds);
```
