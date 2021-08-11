---
uid: crmscript_ref_NSDocumentAgent_CreateNewPhysicalMailMergeDocumentFromTemplate
title: NSDocumentEntity CreateNewPhysicalMailMergeDocumentFromTemplate(Integer documentId, String uiCulture)
intellisense: NSDocumentAgent.CreateNewPhysicalMailMergeDocumentFromTemplate
keywords: NSDocumentAgent, CreateNewPhysicalMailMergeDocumentFromTemplate
so.topic: reference
---

# NSDocumentEntity CreateNewPhysicalMailMergeDocumentFromTemplate(Integer documentId, String uiCulture)

Create a new physical document based on the documents template. Do not replace template tags, as the document is going to be used as a mail merge source. Use GetDocumentStream to obtain the created documents. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.

**Parameters:**
 - **documentId** Identifier for a document. The template to use is stored in the document entity.
 - **uiCulture** Language variation of template to use. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".

**Returns:** NSDocumentEntity

```crmscript
NSDocumentAgent agent;
Integer documentId;
String uiCulture;
NSDocumentEntity res = agent.CreateNewPhysicalMailMergeDocumentFromTemplate(documentId, uiCulture);
```

