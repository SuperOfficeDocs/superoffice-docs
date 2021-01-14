---
title: HTTP
path: /EJScript/Classes/HTTP
intellisense: 1
classref: 1
sortOrder: 396
---


Class used to retrieve the result of an url




###Example code:###


    HTTP h;
    
    Byte[] b = h.open("https://httpbin.org/");
    printLine(h.getValue("statusCode"));
    
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));




1. autolist

