---
uid: crmscript_ref_NSBLOBAgent_GetBlobStream
title: NSStream GetBlobStream(Integer blobEntityId)
intellisense: NSBLOBAgent.GetBlobStream
keywords: NSBLOBAgent, GetBlobStream
so.topic: reference
---

Get the binary object as a stream

**Parameters:**
 - **blobEntityId** The ID of the BLOB entity object that refers to the binary data

**Returns:** NSStream

```crmscript
NSBLOBAgent agent;
Integer blobEntityId;
NSStream res = agent.GetBlobStream(blobEntityId);
```

