---
title: crmscript_ref_NSSelectionAgent_CreateContactSelectionFromShadowSelection
description: SelectionEntity CreateContactSelectionFromShadowSelection(Integer selectionId, String name)
intellisense: NSSelectionAgent.CreateContactSelectionFromShadowSelection
keywords: NSSelectionAgent,CreateContactSelectionFromShadowSelection
so.topic: reference
---

Creates a new contact selection based on contact selection members from an existing shadow sale, appointment, project or document selection. The new selection will always be static even if the original selection is dynamic.

**Parameters:**
 - **selectionId** The id of the selection to copy members from.
 - **name** The name of the new selection.

**Returns:** Returns the newly created SelectionEntity.

```crmscript
NSSelectionAgent agent;
Integer selectionId;
String name;
SelectionEntity res = agent.CreateContactSelectionFromShadowSelection(selectionId, name);
```

