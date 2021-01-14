---
title: NSDocumentEntity SetDocumentStreamFromId(Integer documentId, NSStream stream)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSDocumentEntity SetDocumentStreamFromId(Integer p_0, NSStream p_1)
intellisense: 1
classref: 1
sortOrder: 2507
keywords: SetDocumentStreamFromId(Integer,NSStream)
---


Store document content from stream. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.



* **documentId:** The document entity object that the binary data (document) should be stored to. Its file name may be amended by this call, see the return value.
* **stream:** The document content as a stream.
* **Returns:** Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.


