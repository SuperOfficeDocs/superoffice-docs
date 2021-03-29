---
title: crmscript_ref_NSDocumentAgent_GetDocumentUrl_Integer_p_0_String_p_1_Bool_p_2
description: NSDocumentAgent.GetDocumentUrl(Integer p_0, String p_1, Bool p_2)
intellisense: NSDocumentAgent.GetDocumentUrl
sortOrder: 2534
keywords: GetDocumentUrl(Integer,String,Bool)
so.topic: reference
---


Get a URL referring to the given document content.\<para/>This URL may be passed to the ultimate client (text editor of some kind?), which is then responsible for all further operations.\<para/>The returned string is a fully qualified URL.\<para/>Not all documents and document plugins support this feature.



* **documentId:** SuperOffice document primary key
* **versionId:** Version ID if applicable/desired; a blank value implies "latest" version and is always acceptable.
* **writeableUrl:** If true, then a URL that supports saving is requested. Som edocument plugins may not support read-only URLs, so there is no guarantee that a False value will actually yield a read-only URL, and vice versa.
* **Returns:** Fully resolved URL referring to the document. May be NULL or blank if plugin does not support URLs.


