---
uid: crmscript_ref_NSErpSyncAgent_GetErpConnectionConfigFields
title: StringDictionary GetErpConnectionConfigFields()
description: CRMScript method in the NSErpSyncAgent class that returns the config fields for the connection
intellisense: NSErpSyncAgent.GetErpConnectionConfigFields
keywords: NSErpSyncAgent, GetErpConnectionConfigFields, GetErpConnectionConfigFields(Integer)
so.topic: reference
---

# GetErpConnectionConfigFields()

Returns the config fields for the connection.

`StringDictionary GetErpConnectionConfigFields(Integer erpConnectionId)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| erpConnectionId | Integer | Primary key of the ERP connection |

## Examples

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
StringDictionary res = agent.GetErpConnectionConfigFields(erpConnectionId);
```
