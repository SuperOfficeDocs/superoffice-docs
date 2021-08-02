---
uid: crmscript_ref_NSSelectionAgent_CreateTemporaryContactSelectionFromSelectionMemberIds
title: NSSelectionEntity CreateTemporaryContactSelectionFromSelectionMemberIds(Integer selectionId, Integer[] selectionMemberIds)
intellisense: NSSelectionAgent.CreateTemporaryContactSelectionFromSelectionMemberIds
keywords: NSSelectionAgent, CreateTemporaryContactSelectionFromSelectionMemberIds
so.topic: reference
---

Creates a temporary selection with members from a collection of selectionmember id's.

**Parameters:**
 - **selectionId** The selectionId the selectionmembers is a part of.
 - **selectionMemberIds** A collection of int ids to copy into the temporary contact selection as members.

**Returns:** NSSelectionEntity

```crmscript
NSSelectionAgent agent;
Integer selectionId;
Integer[] selectionMemberIds;
NSSelectionEntity res = agent.CreateTemporaryContactSelectionFromSelectionMemberIds(selectionId, selectionMemberIds);
```

