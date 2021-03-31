---
title: crmscript_ref_NSListAgent_DeleteDocumentTemplateLanguage
description: Void DeleteDocumentTemplateLanguage(Integer documentTemplateId, String languageCode)
intellisense: NSListAgent.DeleteDocumentTemplateLanguage
keywords: NSListAgent,DeleteDocumentTemplateLanguage
so.topic: reference
---

Deletes language variant of the document template

**Parameters:**
 - **documentTemplateId** The id of the document template
 - **languageCode** The language code ('en-US, 'nb-NO', etc)

**Returns:** This method has no return value

```crmscript
NSListAgent agent;
Integer documentTemplateId;
String languageCode;
Void res = agent.DeleteDocumentTemplateLanguage(documentTemplateId, languageCode);
```

