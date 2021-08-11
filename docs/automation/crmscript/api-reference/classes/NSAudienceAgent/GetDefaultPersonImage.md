---
uid: crmscript_ref_NSAudienceAgent_GetDefaultPersonImage
title: NSImage GetDefaultPersonImage(String layoutName)
intellisense: NSAudienceAgent.GetDefaultPersonImage
keywords: NSAudienceAgent, GetDefaultPersonImage
so.topic: reference
---

# NSImage GetDefaultPersonImage(String layoutName)

Returns the default person (sales rep) image that is displayed in Audience when no person image is found. The image belongs to a specific Audience layout instance.

**Parameters:**
 - **layoutName** Name of the Audience layout instance

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)

```crmscript
NSAudienceAgent agent;
String layoutName;
NSImage res = agent.GetDefaultPersonImage(layoutName);
```

