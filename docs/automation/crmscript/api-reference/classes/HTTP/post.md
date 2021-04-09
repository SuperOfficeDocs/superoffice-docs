---
uid: crmscript_ref_HTTP_post_String_p_0
title: HTTP.post(String p_0)
intellisense: HTTP.post
sortOrder: 403
keywords: post(String)
so.topic: reference
---

Supports both http and https. Returns the result in a byte array.



## Example


    HTTP h;
    
    h.addHeader("header", "test");
    h.setValue("key", "value");
    h.setValue("key2", "value2");
    h.setOption("followLocation", "true");
    Byte[] b = h.post("https://httpbin.org/post");
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));


