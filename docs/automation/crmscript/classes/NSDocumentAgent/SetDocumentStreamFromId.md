---
title: crmscript_ref_NSDocumentAgent_SetDocumentStreamFromId_Integer_p_0_NSStream_p_1
description: NSDocumentAgent.SetDocumentStreamFromId(Integer p_0, NSStream p_1)
intellisense: NSDocumentAgent.SetDocumentStreamFromId
sortOrder: 2507
keywords: SetDocumentStreamFromId(Integer,NSStream)
so.topic: reference
---


Store document content from stream. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.



* **documentId:** The document entity object that the binary data (document) should be stored to. Its file name may be amended by this call, see the return value.
* **stream:** The document content as a stream.
* **Returns:** Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.


