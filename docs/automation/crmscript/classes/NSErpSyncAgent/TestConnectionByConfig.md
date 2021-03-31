---
uid: crmscript_ref_NSErpSyncAgent_TestConnectionByConfig
title: Bool TestConnectionByConfig(Integer erpConnectionId, StringDictionary configFields)
intellisense: NSErpSyncAgent.TestConnectionByConfig
keywords: NSErpSyncAgent, TestConnectionByConfig
so.topic: reference
---

Tests to see if the given connection has a valid connection to its connector

**Parameters:**
 - **erpConnectionId** The id of the connector we try to connect to
 - **configFields** The config fields used to test connection

**Returns:** Returns true if success

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
StringDictionary configFields;
Bool res = agent.TestConnectionByConfig(erpConnectionId, configFields);
```

