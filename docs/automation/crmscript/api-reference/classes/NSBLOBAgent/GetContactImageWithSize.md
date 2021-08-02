---
uid: crmscript_ref_NSBLOBAgent_GetContactImageWithSize
title: NSImage GetContactImageWithSize(Integer contactId, Integer width, Integer height)
intellisense: NSBLOBAgent.GetContactImageWithSize
keywords: NSBLOBAgent, GetContactImageWithSize
so.topic: reference
---

Returns the contact image that is displayed in the CRM application with a specified maximum size.

**Parameters:**
 - **contactId** The contact id of the Contact the image belongs to.
 - **width** The maximum with of the returned image. Specify <= 0 to preserve aspect ratio of existing image
 - **height** The maximum height of the returned image. Specify <= 0 to preserve aspect ratio of existing image

**Returns:** NSImage

```crmscript
NSBLOBAgent agent;
Integer contactId;
Integer width;
Integer height;
NSImage res = agent.GetContactImageWithSize(contactId, width, height);
```

