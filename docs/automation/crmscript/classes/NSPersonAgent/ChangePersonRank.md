---
title: crmscript_ref_NSPersonAgent_ChangePersonRank
description: Integer ChangePersonRank(Integer personId, Bool moveUp)
intellisense: NSPersonAgent.ChangePersonRank
keywords: NSPersonAgent,ChangePersonRank
so.topic: reference
---

Move one person up or down in the ranking in the Person Archive, if possible.<para/>The person record that has rank = 1 is the primary contact for a company, and is the one used in situations where no person has been explicitly chosen (such as in selections).<para/>This method corresponds to the move up/move down functions in the person archive in the contact panel.<para/>This method always affects two records.

**Parameters:**
 - **personId** Primary key of person record to move up or down. You must have write access both to this record AND to whatever record is adjacent in the direction you want to move.
 - **moveUp** If true, the given person is moved to an earlier rank (lower numeric rank value, down to a limit of 1; up in the GUI if sorted by ascending rank). If false, movement is to later priority (higher numeric rank value).

**Returns:** If movement occurred, the return value will be the ID of the OTHER person that got moved. A GUI should switch the positions of the original person ID and this return value.<para/>If no movement occurred, for any reason,  0 is returned.

```crmscript
NSPersonAgent agent;
Integer personId;
Bool moveUp;
Integer res = agent.ChangePersonRank(personId, moveUp);
```

