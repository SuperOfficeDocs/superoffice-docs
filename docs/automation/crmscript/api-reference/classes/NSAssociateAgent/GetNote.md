---
uid: crmscript_ref_NSAssociateAgent_GetNote
title: String[] GetNote(Integer associateId)
intellisense: NSAssociateAgent.GetNote
keywords: NSAssociateAgent, GetNote
so.topic: reference
---

Returns an array of strings(notepad pages).

**Parameters:**
 - **associateId** The associate id

**Returns:** Returns an array of strings(notepad pages).

```crmscript
NSAssociateAgent agent;
Integer associateId;
String[] res = agent.GetNote(associateId);
```

