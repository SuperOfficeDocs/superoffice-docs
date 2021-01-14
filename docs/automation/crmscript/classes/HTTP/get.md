---
title: Byte[] get(String p0)
path: /EJScript/Classes/HTTP/Member functions/Byte[] get(String p_0)
intellisense: 1
classref: 1
sortOrder: 400
keywords: get(String)
---

Supports both http and https. Returns the result in a byte array.



###Example code:###


    HTTP h;
    
    h.addHeader("header", "test");
    h.setValue("key", "value");
    h.setValue("key2", "value2");
    h.setOption("followLocation", "true");
    Byte[] b = h.get("https://httpbin.org/get");
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));


