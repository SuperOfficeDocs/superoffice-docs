---
uid: crmscript_ref_NSDocumentAgent_GetTempFile
title: NSStream GetTempFile(String filename)
intellisense: NSDocumentAgent.GetTempFile
keywords: NSDocumentAgent, GetTempFile
so.topic: reference
---

# NSStream GetTempFile(String filename)

Get data stream for temporary file created with CreateTempFile.

**Parameters:**
 - **filename** Name of temporary file to retrieve.

**Returns:** NSStream

```crmscript
NSDocumentAgent agent;
String filename;
NSStream res = agent.GetTempFile(filename);
```

