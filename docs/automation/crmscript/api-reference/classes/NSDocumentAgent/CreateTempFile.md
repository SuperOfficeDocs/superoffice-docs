---
uid: crmscript_ref_NSDocumentAgent_CreateTempFile
title: String CreateTempFile(String filename, NSStream dataStream)
intellisense: NSDocumentAgent.CreateTempFile
keywords: NSDocumentAgent, CreateTempFile
so.topic: reference
---

# String CreateTempFile(String filename, NSStream dataStream)

Create a new temporary file based on the provided stream.  Specified filename may be overridden, and actual name is returned.

**Parameters:**
 - **filename** Wanted name of file.
 - **dataStream** Data to be added to the file.

**Returns:** String

```crmscript
NSDocumentAgent agent;
String filename;
NSStream dataStream;
String res = agent.CreateTempFile(filename, dataStream);
```

