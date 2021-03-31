---
uid: crmscript_ref_NSBLOBAgent_GetContactImage
title: Image GetContactImage(Integer contactId)
intellisense: NSBLOBAgent.GetContactImage
keywords: NSBLOBAgent, GetContactImage
so.topic: reference
---

Returns the contact image that is displayed in the CRM application.

**Parameters:**
 - **contactId** The contact id of the contact the image belongs to.

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)

```crmscript
NSBLOBAgent agent;
Integer contactId;
Image res = agent.GetContactImage(contactId);
```

