---
uid: crmscript_ref_NSDocumentAgent_CreateNewPhysicalDocumentFromTemplate
title: DocumentEntity CreateNewPhysicalDocumentFromTemplate(Integer contactId, Integer personId, Integer appointmentId, Integer documentId, Integer saleId, Integer selectionId, Integer projectId, String uiCulture)
intellisense: NSDocumentAgent.CreateNewPhysicalDocumentFromTemplate
keywords: NSDocumentAgent, CreateNewPhysicalDocumentFromTemplate
so.topic: reference
---

Create a new document content based on a document template and store it in the document archive.  Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.

**Parameters:**
 - **contactId** Identifier for a contact. Defaults to document's contact if 0
 - **personId** Identifier for a person. Defaults to document's person if 0
 - **appointmentId** identifier for an appointment. Defaults to document if 0
 - **documentId** Identifier for a document. The document defines the template to use.
 - **saleId** Identifier for sale. Defaults to document's sale if 0.
 - **selectionId** identifier for selection.
 - **projectId** identifier for project. Defaults to document's project if 0
 - **uiCulture** Language variation of template to use when creating document content. (ISO code "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".

**Returns:** The updated document entity, after creating the document content from the template.

```crmscript
NSDocumentAgent agent;
Integer contactId;
Integer personId;
Integer appointmentId;
Integer documentId;
Integer saleId;
Integer selectionId;
Integer projectId;
String uiCulture;
DocumentEntity res = agent.CreateNewPhysicalDocumentFromTemplate(contactId, personId, appointmentId, documentId, saleId, selectionId, projectId, uiCulture);
```

