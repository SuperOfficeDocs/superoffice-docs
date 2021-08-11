---
uid: crmscript_ref_NSErpSyncAgent_ToggleErpConnectionActive
title: String[] ToggleErpConnectionActive(Integer erpConnectionId)
intellisense: NSErpSyncAgent.ToggleErpConnectionActive
keywords: NSErpSyncAgent, ToggleErpConnectionActive
so.topic: reference
---

# String[] ToggleErpConnectionActive(Integer erpConnectionId)

Toggles the Active state of the connection

**Parameters:**
 - **erpConnectionId** Primary key of the erp connection

**Returns:** String[]

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
String[] res = agent.ToggleErpConnectionActive(erpConnectionId);
```

