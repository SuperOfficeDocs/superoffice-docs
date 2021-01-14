---
title: NSImage GetProjectImageWithSize(Integer projectId, Integer width, Integer height)
path: /EJScript/Classes/NSBLOBAgent/Member functions/NSImage GetProjectImageWithSize(Integer p_0, Integer p_1, Integer p_2)
intellisense: 1
classref: 1
sortOrder: 1422
keywords: GetProjectImageWithSize(Integer,Integer,Integer)
---


Returns the project image that is displayed in the CRM application with a specified maximum size.



* **projectId:** The project id of the project the image belongs to.
* **width:** The maximum with of the returned image. Specify <= 0 to preserve aspect ratio of existing image
* **height:** The maximum height of the returned image. Specify <= 0 to preserve aspect ratio of existing image
* **Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a jpeg/base64 encoded string.)


