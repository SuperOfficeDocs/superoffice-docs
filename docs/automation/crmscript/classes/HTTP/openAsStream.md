---
uid: crmscript_ref_HTTP_openAsStream_String_p_url
title: HTTP.openAsStream(String p_url)
intellisense: HTTP.openAsStream
sortOrder: 407
keywords: openAsStream(String)
so.topic: reference
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


