---
title: crmscript_ref_NSPersonAgent_Undelete
description: Void Undelete(Integer id)
intellisense: NSPersonAgent.Undelete
keywords: NSPersonAgent,Undelete
so.topic: reference
---

This entity supports Soft Delete. Call this method to Undelete a previously soft-deleted record

**Parameters:**
 - **id** The primary key of the entity to undelete

**Returns:** This method has no return value

```crmscript
NSPersonAgent agent;
Integer id;
Void res = agent.Undelete(id);
```

