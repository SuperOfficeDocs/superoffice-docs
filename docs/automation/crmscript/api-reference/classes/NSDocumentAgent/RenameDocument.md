---
uid: crmscript_ref_NSDocumentAgent_RenameDocument
title: String RenameDocument(Integer documentId, String newFilename)
intellisense: NSDocumentAgent.RenameDocument
keywords: NSDocumentAgent, RenameDocument
so.topic: reference
---

# String RenameDocument(Integer documentId, String newFilename)

Rename the physical document, i.e., change the file name or equivalent concept in the document archive.

**Parameters:**
 - **documentId** SuperOffice document ID
 - **newFilename** Suggested new file name. The document archive may amend this to conform to uniqueness constraints, character range limitations etc.

**Returns:** String

```crmscript
NSDocumentAgent agent;
Integer documentId;
String newFilename;
String res = agent.RenameDocument(documentId, newFilename);
```

