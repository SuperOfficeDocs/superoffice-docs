---
uid: crmscript_ref_HTTP_open_String_p_url
title: HTTP.open(String p_url)
intellisense: HTTP.open
sortOrder: 401
keywords: open(String)
so.topic: reference
---

This function opens an url and returns the result as a Byte array.



## Parameters


 - p\_url: The url to open. http://.....




## Example


    HTTP h;
    
    Byte[] b = h.open("https://httpbin.org/");
    
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));


