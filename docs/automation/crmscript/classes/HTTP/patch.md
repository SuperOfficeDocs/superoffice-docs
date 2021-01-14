---
title: Byte[] patch(String p0)
path: /EJScript/Classes/HTTP/Member functions/Byte[] patch(String p_0)
intellisense: 1
classref: 1
sortOrder: 402
keywords: patch(String)
---

Supports both http and https. Returns the result in a byte array.



###Example code:###


    HTTP h;
    
    h.addHeader("header", "test");
    h.setValue("key", "value");
    h.setValue("key2", "value2");
    h.setOption("followLocation", "true");
    Byte[] b = h.patch("https://httpbin.org/patch");
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));


