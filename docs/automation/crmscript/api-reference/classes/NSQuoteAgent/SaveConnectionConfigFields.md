---
uid: crmscript_class_nsquoteagent_saveconnectionconfigfields
title: StringDictionary SaveConnectionConfigFields()
description: CRMScript method in the NSQuoteAgent class
intellisense: NSQuoteAgent.SaveConnectionConfigFields
keywords: NSQuoteAgent, SaveConnectionConfigFields, SaveConnectionConfigFields(Integer,StringDictionary)
so.topic: reference
---

# SaveConnectionConfigFields()

Saves the connection config fields.

Returns Config Fields

`StringDictionary SaveConnectionConfigFields(Integer quoteConnectionId, StringDictionary connectionConfigFields)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| quoteConnectionId | Integer | Primary key of the connection |
| connectionConfigFields | StringDictionary | ConnectionConfigFields to save. |

## Examples

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
StringDictionary connectionConfigFields;
StringDictionary res = agent.SaveConnectionConfigFields(quoteConnectionId, connectionConfigFields);
```
