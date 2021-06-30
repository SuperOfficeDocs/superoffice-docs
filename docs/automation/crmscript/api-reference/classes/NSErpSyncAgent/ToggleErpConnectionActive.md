---
uid: crmscript_ref_NSErpSyncAgent_ToggleErpConnectionActive
title: String[] ToggleErpConnectionActive(Integer erpConnectionId)
intellisense: NSErpSyncAgent.ToggleErpConnectionActive
keywords: NSErpSyncAgent, ToggleErpConnectionActive
so.topic: reference
---

Toggles the Active state of the connection

**Parameters:**
 - **erpConnectionId** Primary key of the erp connection

**Returns:** Contains the reason for why the toggle failed. Empty if operation was successful

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
String[] res = agent.ToggleErpConnectionActive(erpConnectionId);
```

