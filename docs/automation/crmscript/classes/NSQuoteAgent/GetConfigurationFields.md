---
title: crmscript_ref_NSQuoteAgent_GetConfigurationFields
description: FieldMetadataDictionary GetConfigurationFields(Integer connectionId, String connectorName)
intellisense: NSQuoteAgent.GetConfigurationFields
keywords: NSQuoteAgent,GetConfigurationFields
so.topic: reference
---

Used by ADMIN. Asks for metadata needed to populate admin dialog that takes in the information needed to create a connection to an ERP system. The values entered in the dialog are stored in SuperOffice db and used when InitializeConnector is called by the client.

**Parameters:**
 - **connectionId** Id of an existing connection, if any. Initializes connection with current config values if non-zero.
 - **connectorName** Name of the connector. Ignored if connectionId is non-zero.

**Returns:** carriers

```crmscript
NSQuoteAgent agent;
Integer connectionId;
String connectorName;
FieldMetadataDictionary res = agent.GetConfigurationFields(connectionId, connectorName);
```

