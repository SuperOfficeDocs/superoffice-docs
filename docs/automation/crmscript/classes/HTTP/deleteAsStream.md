---
title: NSStream deleteAsStream(String p0)
path: /EJScript/Classes/HTTP/Member functions/NSStream deleteAsStream(String p_0)
intellisense: 1
classref: 1
sortOrder: 405
keywords: deleteAsStream(String)
---

Supports both http and https. Returns the result in a NSStream.



###Example code:###


    HTTP h;
    
    NSStream b = h.deleteAsStream("https://httpbin.org/delete");
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));


