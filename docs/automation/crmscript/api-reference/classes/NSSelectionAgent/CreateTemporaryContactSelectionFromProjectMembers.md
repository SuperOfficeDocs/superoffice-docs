---
uid: crmscript_ref_NSSelectionAgent_CreateTemporaryContactSelectionFromProjectMembers
title: NSSelectionEntity CreateTemporaryContactSelectionFromProjectMembers(Integer projectId)
intellisense: NSSelectionAgent.CreateTemporaryContactSelectionFromProjectMembers
keywords: NSSelectionAgent, CreateTemporaryContactSelectionFromProjectMembers
so.topic: reference
---

Creates a temporary selection with members from an existing project.

**Parameters:**
 - **projectId** The id of the project to add members from.

**Returns:** NSSelectionEntity

```crmscript
NSSelectionAgent agent;
Integer projectId;
NSSelectionEntity res = agent.CreateTemporaryContactSelectionFromProjectMembers(projectId);
```

