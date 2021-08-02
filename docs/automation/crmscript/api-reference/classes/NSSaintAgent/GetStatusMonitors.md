---
uid: crmscript_ref_NSSaintAgent_GetStatusMonitors
title: NSStatusMonitor[] GetStatusMonitors(Integer id, String type)
intellisense: NSSaintAgent.GetStatusMonitors
keywords: NSSaintAgent, GetStatusMonitors
so.topic: reference
---

Get all active status monitors for a specified target

**Parameters:**
 - **id** Identity of target type(contact identity, project identity etc.)
 - **type** Type to get status monitors for("contact", "project", etc.)

**Returns:** NSStatusMonitor[]

```crmscript
NSSaintAgent agent;
Integer id;
String type;
NSStatusMonitor[] res = agent.GetStatusMonitors(id, type);
```

