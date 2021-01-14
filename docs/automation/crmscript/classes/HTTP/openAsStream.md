---
title: NSStream openAsStream(String p\_url)
path: /EJScript/Classes/HTTP/Member functions/NSStream openAsStream(String p_url)
intellisense: 1
classref: 1
sortOrder: 407
keywords: openAsStream(String)
---

This function opens an url and returns the result as a NSStream.



###Parameter:###


 - p\_url: The url to open. http://.....




###Example code:###


    HTTP h;
    
    NSStream b = h.openAsStream("https://httpbin.org/");
    
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));


