---
uid: crmscript_ref_NSBLOBAgent_GetContactImage
title: NSImage GetContactImage(Integer contactId)
intellisense: NSBLOBAgent.GetContactImage
keywords: NSBLOBAgent, GetContactImage
so.topic: reference
---

# NSImage GetContactImage(Integer contactId)

Returns the contact image that is displayed in the CRM application.

**Parameters:**
 - **contactId** The contact id of the contact the image belongs to.

**Returns:** NSImage

```crmscript
NSBLOBAgent agent;
Integer contactId;
NSImage res = agent.GetContactImage(contactId);
```

