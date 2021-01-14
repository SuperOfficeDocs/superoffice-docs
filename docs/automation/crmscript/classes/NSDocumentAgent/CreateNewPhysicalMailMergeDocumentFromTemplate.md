---
title: NSDocumentEntity CreateNewPhysicalMailMergeDocumentFromTemplate(Integer documentId, String uiCulture)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSDocumentEntity CreateNewPhysicalMailMergeDocumentFromTemplate(Integer p_0, String p_1)
intellisense: 1
classref: 1
sortOrder: 2503
keywords: CreateNewPhysicalMailMergeDocumentFromTemplate(Integer,String)
---


Create a new physical document based on the documents template. Do not replace template tags, as the document is going to be used as a mail merge source. Use GetDocumentStream to obtain the created documents. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.



* **documentId:** Identifier for a document. The template to use is stored in the document entity.
* **uiCulture:** Language variation of template to use. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".
* **Returns:** The document object with updated info after creating the document.


