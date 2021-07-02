---
uid: crmscript_ref_HTTP
title: HTTP
intellisense: Void.HTTP
sortOrder: 396
so.topic: reference
---


Class used to retrieve the result of an url




## Example


    HTTP h;
    
    Byte[] b = h.open("https://httpbin.org/");
    printLine(h.getValue("statusCode"));
    
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));
