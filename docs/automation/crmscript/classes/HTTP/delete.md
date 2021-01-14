---
title: Byte[] delete(String p0)
path: /EJScript/Classes/HTTP/Member functions/Byte[] delete(String p_0)
intellisense: 1
classref: 1
sortOrder: 399
keywords: delete(String)
---

Supports both http and https. Returns the result in a byte array.



###Example code:###


    HTTP h;
    
    Byte[] b = h.delete("https://httpbin.org/delete");
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));


