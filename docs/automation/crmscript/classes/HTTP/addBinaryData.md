---
title: crmscript_ref_HTTP_addBinaryData_Byte__p_binaryData
description: HTTP.addBinaryData(Byte[] p_binaryData)
intellisense: HTTP.addBinaryData
sortOrder: 418
keywords: addBinaryData(Byte[])
so.topic: reference
---

This function will add the binary data to the body of the request. Must be used together with POST, PUT or PATCH.
Many REST endpoints expect the content to be uploaded as binary data when adding files. You can use this method for
doing that. Normally, you also want to add a Content-Type header, indicating what kind of files this is.



###Parameter:###


 - p_binaryData: An array of Bytes containing the binary data you want to apply to the request body




###Example code:###


    #setLanguageLevel 3;

    HTTP http;
    Byte[] image = http.get("https://httpbin.org/image/png");
    if (!http.hasError())
    {
      http.addBinaryData(image);
      http.addHeader("Content-Type", "image/png");
      Byte[] res = http.post("https://httpbin.org/post");
      print(String(res));
    }
    else
    {
      print(http.getErrorMessage());
    }


