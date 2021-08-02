---
uid: crmscript_ref_NSListAgent_CreateDefaultDocumentTemplateLanguage
title: Void CreateDefaultDocumentTemplateLanguage(Integer documentTemplateId, String languageCode)
intellisense: NSListAgent.CreateDefaultDocumentTemplateLanguage
keywords: NSListAgent, CreateDefaultDocumentTemplateLanguage
so.topic: reference
---

Create a new document template language based on an existing template

**Parameters:**
 - **documentTemplateId** The id of the document template
 - **languageCode** The language code ('en-US, 'nb-NO', etc)

```crmscript
NSListAgent agent;
Integer documentTemplateId;
String languageCode;
agent.CreateDefaultDocumentTemplateLanguage(documentTemplateId, languageCode);
```

