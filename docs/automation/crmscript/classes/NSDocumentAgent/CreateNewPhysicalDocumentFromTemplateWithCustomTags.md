---
title: crmscript_ref_NSDocumentAgent_CreateNewPhysicalDocumentFromTemplateWithCustomTags_Integer_p_0_Integer_p_1_Integer_p_2_Integer_p_3_Integer_p_4_Integer_p_5_Integer_p_6_String__p_7_String__p_8_String_p_9
description: NSDocumentAgent.CreateNewPhysicalDocumentFromTemplateWithCustomTags(Integer p_0, Integer p_1, Integer p_2, Integer p_3, Integer p_4, Integer p_5, Integer p_6, String[] p_7, String[] p_8, String p_9)
intellisense: NSDocumentAgent.CreateNewPhysicalDocumentFromTemplateWithCustomTags
sortOrder: 2501
keywords: CreateNewPhysicalDocumentFromTemplateWithCustomTags(Integer,Integer,Integer,Integer,Integer,Integer,Integer,String[],String[],String)
so.topic: reference
---


Create a new physical document based on a document template and store it in the document archive.  Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document content. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.



* **contactId:** Identifier for a contact. Defaults to document's contact if 0
* **personId:** Identifier for a person. Defaults to document's person if 0
* **appointmentId:** identifier for an appointment. Defaults to document if 0
* **documentId:** Identifier for the document
* **saleId:** Identifier for sale. Defaults to document's sale if 0.
* **selectionId:** identifier for selection.
* **projectId:** identifier for project. Defaults to document's project if 0
* **customTags:** Array of custom tag names. Each name should have exactly four characters. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.
* **customValues:** Array of values for custom tags. There should be exactly one value for each tag, i.e., the lengths of the customTags and customValues arrays should be the same.
* **uiCulture:** Language variation of template to use when creating document. (ISO code - "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".
* **Returns:** The document object with updated info after creating the document


