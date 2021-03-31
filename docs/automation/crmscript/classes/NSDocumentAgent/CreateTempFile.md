---
uid: crmscript_ref_NSDocumentAgent_CreateTempFile
title: String CreateTempFile(String filename, Stream dataStream)
intellisense: NSDocumentAgent.CreateTempFile
keywords: NSDocumentAgent, CreateTempFile
so.topic: reference
---

Create a new temporary file based on the provided stream.  Specified filename may be overridden, and actual name is returned.

**Parameters:**
 - **filename** Wanted name of file.
 - **dataStream** Data to be added to the file.

**Returns:** Actual used filename.

```crmscript
NSDocumentAgent agent;
String filename;
Stream dataStream;
String res = agent.CreateTempFile(filename, dataStream);
```

