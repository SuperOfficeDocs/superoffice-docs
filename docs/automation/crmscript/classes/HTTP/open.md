---
title: Byte[] open(String p\_url)
path: /EJScript/Classes/HTTP/Member functions/Byte[] open(String p_url)
intellisense: 1
classref: 1
sortOrder: 401
keywords: open(String)
---

This function opens an url and returns the result as a Byte array.



###Parameter:###


 - p\_url: The url to open. http://.....




###Example code:###


    HTTP h;
    
    Byte[] b = h.open("https://httpbin.org/");
    
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));


