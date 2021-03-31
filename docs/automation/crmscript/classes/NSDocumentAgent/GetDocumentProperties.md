---
title: crmscript_ref_NSDocumentAgent_GetDocumentProperties
description: StringDictionary GetDocumentProperties(Integer documentId, StringArray requestedProperties)
intellisense: NSDocumentAgent.GetDocumentProperties
keywords: NSDocumentAgent,GetDocumentProperties
so.topic: reference
---

Get plugin-dependent properties for the document. A number of standard properties that should be supported by all plugins are defined in SuperOffice.CRM.Documents.Constants.Properties.

**Parameters:**
 - **documentId** SuperOffice document ID
 - **requestedProperties** Array of property names whose values are being requested.

**Returns:** Dictionary of name=value pairs, corresponding to the requested properties.

```crmscript
NSDocumentAgent agent;
Integer documentId;
StringArray requestedProperties;
StringDictionary res = agent.GetDocumentProperties(documentId, requestedProperties);
```

