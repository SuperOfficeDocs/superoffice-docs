---
uid: crmscript_ref_NSDocumentAgent_CreateNewPhysicalDocumentFromTemplateWithCustomTags
title: DocumentEntity CreateNewPhysicalDocumentFromTemplateWithCustomTags(Integer contactId, Integer personId, Integer appointmentId, Integer documentId, Integer saleId, Integer selectionId, Integer projectId, String[] customTags, String[] customValues, String uiCulture)
intellisense: NSDocumentAgent.CreateNewPhysicalDocumentFromTemplateWithCustomTags
keywords: NSDocumentAgent, CreateNewPhysicalDocumentFromTemplateWithCustomTags
so.topic: reference
---

Create a new physical document based on a document template and store it in the document archive.  Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document content. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.

**Parameters:**
 - **contactId** Identifier for a contact. Defaults to document's contact if 0
 - **personId** Identifier for a person. Defaults to document's person if 0
 - **appointmentId** identifier for an appointment. Defaults to document if 0
 - **documentId** Identifier for the document
 - **saleId** Identifier for sale. Defaults to document's sale if 0.
 - **selectionId** identifier for selection.
 - **projectId** identifier for project. Defaults to document's project if 0
 - **customTags** Array of custom tag names. Each name should have exactly four characters. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.
 - **customValues** Array of values for custom tags. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.
 - **uiCulture** Language variation of template to use when creating document. (ISO code - "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".

**Returns:** The document object with updated info after creating the document

```crmscript
NSDocumentAgent agent;
Integer contactId;
Integer personId;
Integer appointmentId;
Integer documentId;
Integer saleId;
Integer selectionId;
Integer projectId;
String[] customTags;
String[] customValues;
String uiCulture;
DocumentEntity res = agent.CreateNewPhysicalDocumentFromTemplateWithCustomTags(contactId, personId, appointmentId, documentId, saleId, selectionId, projectId, customTags, customValues, uiCulture);
```

