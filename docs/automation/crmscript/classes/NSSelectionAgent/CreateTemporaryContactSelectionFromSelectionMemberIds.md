---
uid: crmscript_ref_NSSelectionAgent_CreateTemporaryContactSelectionFromSelectionMemberIds
title: SelectionEntity CreateTemporaryContactSelectionFromSelectionMemberIds(Integer selectionId, IntegerArray selectionMemberIds)
intellisense: NSSelectionAgent.CreateTemporaryContactSelectionFromSelectionMemberIds
keywords: NSSelectionAgent, CreateTemporaryContactSelectionFromSelectionMemberIds
so.topic: reference
---

Creates a temporary selection with members from a collection of selectionmember id's.

**Parameters:**
 - **selectionId** The selectionId the selectionmembers is a part of.
 - **selectionMemberIds** A collection of int ids to copy into the temporary contact selection as members.

**Returns:** Returns the newly created SelectionEntity.

```crmscript
NSSelectionAgent agent;
Integer selectionId;
IntegerArray selectionMemberIds;
SelectionEntity res = agent.CreateTemporaryContactSelectionFromSelectionMemberIds(selectionId, selectionMemberIds);
```

