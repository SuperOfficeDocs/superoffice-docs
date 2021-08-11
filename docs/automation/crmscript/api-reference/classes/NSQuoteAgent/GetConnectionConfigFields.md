---
uid: crmscript_class_nsquoteagent_getconnectionconfigfields
title: StringDictionary GetConnectionConfigFields()
description: CRMScript method in the NSQuoteAgent class
intellisense: NSQuoteAgent.GetConnectionConfigFields
keywords: NSQuoteAgent, GetConnectionConfigFields, GetConnectionConfigFields(Integer)
so.topic: reference
---

# GetConnectionConfigFields()

Returns the config fields for the connection.

Returns Config Fields

`StringDictionary GetConnectionConfigFields(Integer quoteConnectionId)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| quoteConnectionId | Integer | Primary key of the connection |

## Examples

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
StringDictionary res = agent.GetConnectionConfigFields(quoteConnectionId);
```
