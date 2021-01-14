---
title: String getErrorMessage()
path: /EJScript/Classes/HTTP/Member functions/String getErrorMessage()
intellisense: 1
classref: 1
sortOrder: 412
keywords: getErrorMessage()
---

Returns the last error message.



###Example code:###


    HTTP h;
    
    h.addHeader("header", "test");
    h.setValue("key", "value");
    h.setValue("key2", "value2");
    h.setOption("followLocation", "true");
    Byte[] b = h.put("https://httpbin.org/put");
    
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));


