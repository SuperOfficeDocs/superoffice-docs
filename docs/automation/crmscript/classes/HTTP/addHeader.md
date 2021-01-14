---
title: Void addHeader(String p\_name, String p\_value)
path: /EJScript/Classes/HTTP/Member functions/Void addHeader(String p_name, String p_value)
intellisense: 1
classref: 1
sortOrder: 415
keywords: addHeader(String,String)
---


Adds a new header. The new header will be placed after other existing headers.




###Parameters:###


 - p\_name: name of header
 - p\_value: value of header




###Example code:###


    HTTP h;
    
    h.addHeader("header", "test");
    
    Byte[] b = h.post("https://httpbin.org/post");
    
    if (h.hasError())
    print(h.getErrorMessage());
    else
    print(String(b));


