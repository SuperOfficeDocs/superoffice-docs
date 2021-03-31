---
title: crmscript_ref_NSListAgent_DeleteWebPanel
description: Void DeleteWebPanel(Integer id)
intellisense: NSListAgent.DeleteWebPanel
keywords: NSListAgent,DeleteWebPanel
so.topic: reference
---

Hard-delete (real, permanent DELETE in the database) the given web panel. Use with care!

**Parameters:**
 - **id** Database id of web panel to delete

**Returns:** This method has no return value

```crmscript
NSListAgent agent;
Integer id;
Void res = agent.DeleteWebPanel(id);
```

