---
title: crmscript_ref_NSBLOBAgent_GetBlobStream
description: Stream GetBlobStream(Integer blobEntityId)
intellisense: NSBLOBAgent.GetBlobStream
keywords: NSBLOBAgent,GetBlobStream
so.topic: reference
---

Get the binary object as a stream

**Parameters:**
 - **blobEntityId** The ID of the BLOB entity object that refers to the binary data

**Returns:** The binary object as a Stream

```crmscript
NSBLOBAgent agent;
Integer blobEntityId;
Stream res = agent.GetBlobStream(blobEntityId);
```

