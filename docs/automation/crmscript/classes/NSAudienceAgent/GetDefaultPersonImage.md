---
title: crmscript_ref_NSAudienceAgent_GetDefaultPersonImage
description: Image GetDefaultPersonImage(String layoutName)
intellisense: NSAudienceAgent.GetDefaultPersonImage
keywords: NSAudienceAgent,GetDefaultPersonImage
so.topic: reference
---

Returns the default person (sales rep) image that is displayed in Audience when no person image is found. The image belongs to a specific Audience layout instance.

**Parameters:**
 - **layoutName** Name of the Audience layout instance

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)

```crmscript
NSAudienceAgent agent;
String layoutName;
Image res = agent.GetDefaultPersonImage(layoutName);
```

