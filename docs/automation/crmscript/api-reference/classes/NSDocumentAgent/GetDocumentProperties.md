---
uid: crmscript_ref_NSDocumentAgent_GetDocumentProperties
title: StringDictionary GetDocumentProperties(Integer documentId, String[] requestedProperties)
intellisense: NSDocumentAgent.GetDocumentProperties
keywords: NSDocumentAgent, GetDocumentProperties
so.topic: reference
---

# StringDictionary GetDocumentProperties(Integer documentId, String[] requestedProperties)

Get plugin-dependent properties for the document. A number of standard properties that should be supported by all plugins are defined in SuperOffice.CRM.Documents.Constants.Properties.

**Parameters:**
 - **documentId** SuperOffice document ID
 - **requestedProperties** Array of property names whose values are being requested.

**Returns:** StringDictionary

```crmscript
NSDocumentAgent agent;
Integer documentId;
String[] requestedProperties;
StringDictionary res = agent.GetDocumentProperties(documentId, requestedProperties);
```

