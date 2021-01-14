---
title: Bool addDocumentData(Integer p_documentId)
path: /EJScript/Classes/HTTP/Member functions/Void addDocumentData(Integer p_documentId)
intellisense: 1
classref: 1
sortOrder: 418
keywords: addDocumentData(Integer p_documentId)
---

This function will add the binary data in the document specified to the body of the request. Must be used together with POST, PUT or PATCH.
Many REST endpoints expect the content to be uploaded as binary data when adding files. You can use this method for
doing that. This method will automatically set the Content-Type header based on the extension of the document being added. If you want
to override the Content-Type, be sure to set a Content-Type header **after** doing the addDocumentData call.
The method will return true if the document was found, else false.


###Parameter:###


 - p_documentId: The id of the Document you want to upload




###Example code:###


    #setLanguageLevel 3;
    
    HTTP http;
    
    if(http.addDocumentData(24))
    {
      Byte[] res = http.post("https://httpbin.org/post");
      if (!http.hasError())
        print(String(res));
      else
        print(http.getErrorMessage());
    }


