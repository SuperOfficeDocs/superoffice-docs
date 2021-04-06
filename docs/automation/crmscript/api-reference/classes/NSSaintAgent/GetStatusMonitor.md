---
uid: crmscript_ref_NSSaintAgent_GetStatusMonitor
title: StatusMonitor GetStatusMonitor(Integer id)
intellisense: NSSaintAgent.GetStatusMonitor
keywords: NSSaintAgent, GetStatusMonitor
so.topic: reference
---

Get a single status monitor based on its identity

**Parameters:**
 - **id** Identity of status monitor

**Returns:** The requested status monitor

```crmscript
NSSaintAgent agent;
Integer id;
StatusMonitor res = agent.GetStatusMonitor(id);
```

