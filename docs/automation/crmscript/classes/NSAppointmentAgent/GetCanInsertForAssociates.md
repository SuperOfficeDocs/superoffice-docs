---
title: crmscript_ref_NSAppointmentAgent_GetCanInsertForAssociates
description: BooleanArray GetCanInsertForAssociates(IntegerArray associateIds)
intellisense: NSAppointmentAgent.GetCanInsertForAssociates
keywords: NSAppointmentAgent,GetCanInsertForAssociates
so.topic: reference
---

Check if current associate can create appointments in the diary of other associates.

**Parameters:**
 - **associateIds** Array of associate ids to check for.

**Returns:** Returns an array of bool corresponding to the associate array input parameter.

```crmscript
NSAppointmentAgent agent;
IntegerArray associateIds;
BooleanArray res = agent.GetCanInsertForAssociates(associateIds);
```

