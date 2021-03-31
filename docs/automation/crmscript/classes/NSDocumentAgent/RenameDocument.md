---
title: crmscript_ref_NSDocumentAgent_RenameDocument
description: String RenameDocument(Integer documentId, String newFilename)
intellisense: NSDocumentAgent.RenameDocument
keywords: NSDocumentAgent,RenameDocument
so.topic: reference
---

Rename the physical document, i.e., change the file name or equivalent concept in the document archive.

**Parameters:**
 - **documentId** SuperOffice document ID
 - **newFilename** Suggested new file name. The document archive may amend this to conform to uniqueness constraints, character range limitations etc.

**Returns:** The actual, new "file" name. This will generally be derived from the suggested name, but may be amended.

```crmscript
NSDocumentAgent agent;
Integer documentId;
String newFilename;
String res = agent.RenameDocument(documentId, newFilename);
```

