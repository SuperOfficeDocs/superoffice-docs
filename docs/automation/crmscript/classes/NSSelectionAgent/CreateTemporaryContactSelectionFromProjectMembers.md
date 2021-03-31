---
title: crmscript_ref_NSSelectionAgent_CreateTemporaryContactSelectionFromProjectMembers
description: SelectionEntity CreateTemporaryContactSelectionFromProjectMembers(Integer projectId)
intellisense: NSSelectionAgent.CreateTemporaryContactSelectionFromProjectMembers
keywords: NSSelectionAgent,CreateTemporaryContactSelectionFromProjectMembers
so.topic: reference
---

Creates a temporary selection with members from an existing project.

**Parameters:**
 - **projectId** The id of the project to add members from.

**Returns:** Returns the newly created SelectionEntity.

```crmscript
NSSelectionAgent agent;
Integer projectId;
SelectionEntity res = agent.CreateTemporaryContactSelectionFromProjectMembers(projectId);
```

