---
title: crmscript_ref_NSListAgent_GetDocumentTemplateProperties
description: StringDictionary GetDocumentTemplateProperties(Integer documentTemplateId, StringArray requestedProperties)
intellisense: NSListAgent.GetDocumentTemplateProperties
keywords: NSListAgent,GetDocumentTemplateProperties
so.topic: reference
---

Get document template properties

**Parameters:**
 - **documentTemplateId** The primary key id of the document template
 - **requestedProperties** An array of properties to get the values for

**Returns:** Dictionary of key=value pairs of requested properties

```crmscript
NSListAgent agent;
Integer documentTemplateId;
StringArray requestedProperties;
StringDictionary res = agent.GetDocumentTemplateProperties(documentTemplateId, requestedProperties);
```

