---
title: NSStream putAsStream(String p0)
path: /EJScript/Classes/HTTP/Member functions/NSStream putAsStream(String p_0)
intellisense: 1
classref: 1
sortOrder: 410
keywords: putAsStream(String)
---

Supports both http and https. Returns the result in a NSStream.



###Example code:###


    HTTP h;
    
    h.addHeader("header", "test");
    h.setValue("key", "value");
    h.setValue("key2", "value2");
    h.setOption("followLocation", "true");
    NSStream b = h.putAsStream("https://httpbin.org/put");
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));


