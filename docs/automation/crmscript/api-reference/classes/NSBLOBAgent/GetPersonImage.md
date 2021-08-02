---
uid: crmscript_ref_NSBLOBAgent_GetPersonImage
title: NSImage GetPersonImage(Integer personId)
intellisense: NSBLOBAgent.GetPersonImage
keywords: NSBLOBAgent, GetPersonImage
so.topic: reference
---

Returns the person image that is displayed in the CRM application.

**Parameters:**
 - **personId** The person id of the person the image belongs to.

**Returns:** NSImage

```crmscript
NSBLOBAgent agent;
Integer personId;
NSImage res = agent.GetPersonImage(personId);
```

