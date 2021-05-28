---
uid: crmscript_class_nsquoteagent_getconfigurationfields
title: FieldMetadataDictionary GetConfigurationFields()
description: CRMScript method in the NSQuoteAgent class
intellisense: NSQuoteAgent.GetConfigurationFields
keywords: NSQuoteAgent, GetConfigurationFields, GetConfigurationFields(Integer,String)
so.topic: reference
---

# GetConfigurationFields()

Used by ADMIN. Asks for metadata needed to populate admin dialog that takes in the information needed to create a connection to an ERP system. The values entered in the dialog are stored in the SuperOffice database and used when InitializeConnector is called by the client.

Returns carriers

`FieldMetadataDictionary GetConfigurationFields(Integer connectionId, String connectorName)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| connectionId | Integer | ID of an existing connection, if any. Initializes connection with current config values if non-zero. |
| connectorName | String | Name of the connector. Ignored if `connectionId` is non-zero. |

## Examples

```crmscript
NSQuoteAgent agent;
Integer connectionId;
String connectorName;
FieldMetadataDictionary res = agent.GetConfigurationFields(connectionId, connectorName);
```
