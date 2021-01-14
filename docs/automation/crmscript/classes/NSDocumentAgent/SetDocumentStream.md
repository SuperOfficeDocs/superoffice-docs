---
title: NSDocumentEntity SetDocumentStream(NSDocumentEntity documentEntity, NSStream stream, Bool overwriteExistingData)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSDocumentEntity SetDocumentStream(NSDocumentEntity p_0, NSStream p_1, Bool p_2)
intellisense: 1
classref: 1
sortOrder: 2506
keywords: SetDocumentStream(NSDocumentEntity,NSStream,Bool)
---


Store a document's contents from its stream. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.



* **documentEntity:** The document entity object that the binary data (document) should be stored to. Its file name may be amended by this call, see the return value
* **stream:** The document as a stream.
* **overwriteExistingData:** If true, the stream will overwrite existing data stored for this record in the document archive; this works only for documents that already have a physical document in existence. If false, the call will only work for a document that has no physical document in the archive, and such a physical document will be created.
* **Returns:** Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.


