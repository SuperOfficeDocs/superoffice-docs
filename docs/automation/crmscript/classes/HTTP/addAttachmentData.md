---
title: Bool addAttachmentData(Integer p_attachmentId)
path: /EJScript/Classes/HTTP/Member functions/Void addAttachmentData(Integer p_attachmentId)
intellisense: 1
classref: 1
sortOrder: 418
keywords: addAttachmentData(Integer p_attachmentId)
---

This function will add the binary data in the Service attachment specified to the body of the request. Must be used together with POST, PUT or PATCH.
Many REST endpoints expect the content to be uploaded as binary data when adding files. You can use this method for
doing that. This method will automatically set the Content-Type header based on the content type recorded in the database for the attachment. If you want
to override the Content-Type, be sure to set a Content-Type header **after** doing the addAttachmentData call.
The method will return true if the attachment was found, else false.


###Parameter:###


 - p_attachmentId: The id of the Service attachment you want to upload




###Example code:###


    #setLanguageLevel 3;
    
    HTTP http;
    
    if(http.addAttachmentData(24))
    {
      Byte[] res = http.post("https://httpbin.org/post");
      if (!http.hasError())
        print(String(res));
      else
        print(http.getErrorMessage());
    }


