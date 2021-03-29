---
title: crmscript_ref_NSBLOBAgent_GetChatImageWithSize_Integer_p_0_Integer_p_1_Integer_p_2
description: NSBLOBAgent.GetChatImageWithSize(Integer p_0, Integer p_1, Integer p_2)
intellisense: NSBLOBAgent.GetChatImageWithSize
sortOrder: 1416
keywords: GetChatImageWithSize(Integer,Integer,Integer)
so.topic: reference
---


Returns the chat image that is displayed in chat with a specified maximum size.



* **chatTopicId:** The project id of the project the image belongs to.
* **width:** The maximum with of the returned image. Specify <= 0 to preserve aspect ratio of existing image
* **height:** The maximum height of the returned image. Specify <= 0 to preserve aspect ratio of existing image
* **Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a jpeg/base64 encoded string.)


