---
uid: crmscript_ref_NSListAgent_GetDocumentTemplateExtension
title: String GetDocumentTemplateExtension(Integer documentTemplateId)
intellisense: NSListAgent.GetDocumentTemplateExtension
keywords: NSListAgent, GetDocumentTemplateExtension
so.topic: reference
---

Get the file extension for the document template

**Parameters:**
 - **documentTemplateId** The primary key of the document template

**Returns:** File name extension including '.': '.doc' or '.xlsx'

```crmscript
NSListAgent agent;
Integer documentTemplateId;
String res = agent.GetDocumentTemplateExtension(documentTemplateId);
```

