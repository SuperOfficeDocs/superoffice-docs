---
uid: crmscript_ref_NSPersonAgent_SetPersonRank
title: Bool SetPersonRank(Integer personId, Integer desiredRank)
intellisense: NSPersonAgent.SetPersonRank
keywords: NSPersonAgent, SetPersonRank
so.topic: reference
---

Directly set the rank field of a person record, adjusting all other person records under the same contact as needed.<para/>This call may affect multiple records, potentially all person records belonging to one contact.<para/>You must have write access for to affected records for this method to succeed.

**Parameters:**
 - **personId** Id of person to change
 - **desiredRank** Desired rank to set, legal values are from 1 to the number of person records on this contact. Out of range values will be moved to the closest valid value and processed.

**Returns:** Bool

```crmscript
NSPersonAgent agent;
Integer personId;
Integer desiredRank;
Bool res = agent.SetPersonRank(personId, desiredRank);
```

