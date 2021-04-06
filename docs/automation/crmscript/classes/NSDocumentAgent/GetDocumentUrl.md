---
uid: crmscript_ref_NSDocumentAgent_GetDocumentUrl
title: String GetDocumentUrl(Integer documentId, String versionId, Bool writeableUrl)
intellisense: NSDocumentAgent.GetDocumentUrl
keywords: NSDocumentAgent, GetDocumentUrl
so.topic: reference
---

Get a URL referring to the given document content.<para/>This URL may be passed to the ultimate client (text editor of some kind?), which is then responsible for all further operations.<para/>The returned string is a fully qualified URL.<para/>Not all documents and document plugins support this feature.

**Parameters:**
 - **documentId** SuperOffice document primary key
 - **versionId** Version ID if applicable/desired; a blank value implies "latest" version and is always acceptable.
 - **writeableUrl** If true, then a URL that supports saving is requested. Som edocument plugins may not support read-only URLs, so there is no guarantee that a False value will actually yield a read-only URL, and vice versa.

**Returns:** Fully resolved URL referring to the document. May be NULL or blank if plugin does not support URLs.

```crmscript
NSDocumentAgent agent;
Integer documentId;
String versionId;
Bool writeableUrl;
String res = agent.GetDocumentUrl(documentId, versionId, writeableUrl);
```

