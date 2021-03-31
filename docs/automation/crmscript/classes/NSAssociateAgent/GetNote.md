---
title: crmscript_ref_NSAssociateAgent_GetNote
description: StringArray GetNote(Integer associateId)
intellisense: NSAssociateAgent.GetNote
keywords: NSAssociateAgent,GetNote
so.topic: reference
---

Returns an array of strings(notepad pages).

**Parameters:**
 - **associateId** The associate id

**Returns:** Returns an array of strings(notepad pages).

```crmscript
NSAssociateAgent agent;
Integer associateId;
StringArray res = agent.GetNote(associateId);
```

