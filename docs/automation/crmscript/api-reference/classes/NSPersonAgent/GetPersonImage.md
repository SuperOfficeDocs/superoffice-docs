---
uid: crmscript_ref_NSPersonAgent_GetPersonImage
title: NSImage GetPersonImage(Integer personId)
intellisense: NSPersonAgent.GetPersonImage
keywords: NSPersonAgent, GetPersonImage
so.topic: reference
---

Returns the person image that is displayed in the CRM application.

**Parameters:**
 - **personId** The person id of the person the image belongs to.

**Returns:** NSImage

```crmscript
NSPersonAgent agent;
Integer personId;
NSImage res = agent.GetPersonImage(personId);
```

