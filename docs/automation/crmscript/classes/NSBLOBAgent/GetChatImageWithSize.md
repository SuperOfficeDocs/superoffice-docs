---
uid: crmscript_ref_NSBLOBAgent_GetChatImageWithSize
title: Image GetChatImageWithSize(Integer chatTopicId, Integer width, Integer height)
intellisense: NSBLOBAgent.GetChatImageWithSize
keywords: NSBLOBAgent, GetChatImageWithSize
so.topic: reference
---

Returns the chat image that is displayed in chat with a specified maximum size.

**Parameters:**
 - **chatTopicId** The project id of the project the image belongs to.
 - **width** The maximum with of the returned image. Specify <= 0 to preserve aspect ratio of existing image
 - **height** The maximum height of the returned image. Specify <= 0 to preserve aspect ratio of existing image

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a jpeg/base64 encoded string.)

```crmscript
NSBLOBAgent agent;
Integer chatTopicId;
Integer width;
Integer height;
Image res = agent.GetChatImageWithSize(chatTopicId, width, height);
```

