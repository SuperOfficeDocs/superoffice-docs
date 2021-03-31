---
title: crmscript_ref_NSContactAgent_Undelete
description: Void Undelete(Integer id)
intellisense: NSContactAgent.Undelete
keywords: NSContactAgent,Undelete
so.topic: reference
---

This entity supports Soft Delete. Call this method to Undelete a previously soft-deleted record

**Parameters:**
 - **id** The primary key of the entity to undelete

**Returns:** This method has no return value

```crmscript
NSContactAgent agent;
Integer id;
Void res = agent.Undelete(id);
```

