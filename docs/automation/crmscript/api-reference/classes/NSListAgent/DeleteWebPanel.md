---
uid: crmscript_ref_NSListAgent_DeleteWebPanel
title: Void DeleteWebPanel(Integer id)
intellisense: NSListAgent.DeleteWebPanel
keywords: NSListAgent, DeleteWebPanel
so.topic: reference
---

# Void DeleteWebPanel(Integer id)

Hard-delete (real, permanent DELETE in the database) the given web panel. Use with care!

**Parameters:**
 - **id** Database id of web panel to delete

```crmscript
NSListAgent agent;
Integer id;
agent.DeleteWebPanel(id);
```

