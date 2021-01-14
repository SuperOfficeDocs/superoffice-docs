---
title: String RenameDocument(Integer documentId, String newFilename)
path: /EJScript/Classes/NSDocumentAgent/Member functions/String RenameDocument(Integer p_0, String p_1)
intellisense: 1
classref: 1
sortOrder: 2535
keywords: RenameDocument(Integer,String)
---


Rename the physical document, i.e., change the file name or equivalent concept in the document archive.



* **documentId:** SuperOffice document ID
* **newFilename:** Suggested new file name. The document archive may amend this to conform to uniqueness constraints, character range limitations etc.
* **Returns:** The actual, new "file" name. This will generally be derived from the suggested name, but may be amended.


