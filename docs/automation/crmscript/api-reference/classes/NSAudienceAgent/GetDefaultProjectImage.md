---
uid: crmscript_ref_NSAudienceAgent_GetDefaultProjectImage
title: NSImage GetDefaultProjectImage(String layoutName)
intellisense: NSAudienceAgent.GetDefaultProjectImage
keywords: NSAudienceAgent, GetDefaultProjectImage
so.topic: reference
---

# NSImage GetDefaultProjectImage(String layoutName)

Returns the default project or event image that is displayed in Audience when no project/event image is found. The image belongs to a specific Audience layout instance.

**Parameters:**
 - **layoutName** Name of the Audience layout instance

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)

```crmscript
NSAudienceAgent agent;
String layoutName;
NSImage res = agent.GetDefaultProjectImage(layoutName);
```

