---
uid: crmscript_ref_NSBLOBAgent_GetPersonImageWithSize
title: NSImage GetPersonImageWithSize(Integer personId, Integer width, Integer height)
intellisense: NSBLOBAgent.GetPersonImageWithSize
keywords: NSBLOBAgent, GetPersonImageWithSize
so.topic: reference
---

Returns the person image that is displayed in the CRM application with a specified maximum size.

**Parameters:**
 - **personId** The person id of the person the image belongs to.
 - **width** The maximum with of the returned image. Specify <= 0 to preserve aspect ratio of existing image
 - **height** The maximum height of the returned image. Specify <= 0 to preserve aspect ratio of existing image

**Returns:** NSImage

```crmscript
NSBLOBAgent agent;
Integer personId;
Integer width;
Integer height;
NSImage res = agent.GetPersonImageWithSize(personId, width, height);
```

