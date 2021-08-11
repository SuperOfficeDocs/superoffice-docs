---
uid: crmscript_class_nserpsyncagent_testconnectionbyconfig
title: Bool TestConnectionByConfig()
description: CRMScript method in the NSErpSyncAgent class that tests to see if the given connection has a valid connection to its connector.
intellisense: NSErpSyncAgent.TestConnectionByConfig
keywords: NSErpSyncAgent, TestConnectionByConfig, TestConnectionByConfig(Integer,StringDictionary)
so.topic: reference
---

# TestConnectionByConfig()

Tests to see if the given connection has a valid connection to its connector.

Returns true if the test was a success.

`Bool TestConnectionByConfig(Integer erpConnectionId, StringDictionary configFields)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| erpConnectionId | Integer | The ID of the connector we try to connect to |
| configFields | StringDictionary | The config fields used to test connection |

## Examples

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
StringDictionary configFields;
Bool res = agent.TestConnectionByConfig(erpConnectionId, configFields);
```
