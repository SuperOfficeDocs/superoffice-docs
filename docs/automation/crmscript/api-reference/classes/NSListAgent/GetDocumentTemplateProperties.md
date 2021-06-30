---
uid: crmscript_class_nslistagent_getdocumenttemplateproperties
title: StringDictionary GetDocumentTemplateProperties()
description: CRMScript method in the NSListAgent class that retrieves a list of key-value pairs of document template properties
intellisense: NSListAgent.GetDocumentTemplateProperties
keywords: NSListAgent, GetDocumentTemplateProperties, GetDocumentTemplateProperties(Integer,String[])
so.topic: reference
---

# GetDocumentTemplateProperties()

Gets document template properties.

Returns key-value pairs with the requested properties.

`StringDictionary GetDocumentTemplateProperties(Integer documentTemplateId, String[] requestedProperties)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| documentTemplateId | Integer | The primary key id of the document template |
| requestedProperties | String[] | An array of properties to get the values for |

## Examples

```crmscript
NSListAgent agent;
Integer documentTemplateId;
String[] requestedProperties;
StringDictionary res = agent.GetDocumentTemplateProperties(documentTemplateId, requestedProperties);
```
