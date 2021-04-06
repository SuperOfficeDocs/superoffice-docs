---
uid: crmscript_ref_NSAudienceAgent_GetDefaultCountryFlag
title: Image GetDefaultCountryFlag(String layoutName)
intellisense: NSAudienceAgent.GetDefaultCountryFlag
keywords: NSAudienceAgent, GetDefaultCountryFlag
so.topic: reference
---

Returns the default country flag image that is displayed in Audience when no person image is found. The image belongs to a specific Audience layout instance.

**Parameters:**
 - **layoutName** Name of the Audience layout instance

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)

```crmscript
NSAudienceAgent agent;
String layoutName;
Image res = agent.GetDefaultCountryFlag(layoutName);
```

