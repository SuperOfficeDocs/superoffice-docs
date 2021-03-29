---
title: crmscript_ref_HTTP_deleteAsStream_String_p_0
description: HTTP.deleteAsStream(String p_0)
intellisense: HTTP.deleteAsStream
sortOrder: 405
keywords: deleteAsStream(String)
so.topic: reference
---

Supports both http and https. Returns the result in a NSStream.



###Example code:###


    HTTP h;
    
    NSStream b = h.deleteAsStream("https://httpbin.org/delete");
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));


