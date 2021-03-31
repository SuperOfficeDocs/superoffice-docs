---
title: crmscript_ref_NSDocumentAgent_GetTempFile
description: Stream GetTempFile(String filename)
intellisense: NSDocumentAgent.GetTempFile
keywords: NSDocumentAgent,GetTempFile
so.topic: reference
---

Get data stream for temporary file created with CreateTempFile.

**Parameters:**
 - **filename** Name of temporary file to retrieve.

**Returns:** The document as a Stream

```crmscript
NSDocumentAgent agent;
String filename;
Stream res = agent.GetTempFile(filename);
```

