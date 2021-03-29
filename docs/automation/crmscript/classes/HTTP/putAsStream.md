---
title: crmscript_ref_HTTP_putAsStream_String_p_0
description: HTTP.putAsStream(String p_0)
intellisense: HTTP.putAsStream
sortOrder: 410
keywords: putAsStream(String)
so.topic: reference
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


