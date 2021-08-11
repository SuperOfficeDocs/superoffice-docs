---
uid: crmscript_ref_HTTP_getAsStream_String_p_0
title: HTTP.getAsStream(String p_0)
intellisense: HTTP.getAsStream
sortOrder: 406
keywords: getAsStream(String)
so.topic: reference
---

# HTTP.getAsStream(String p_0)

Supports both http and https. Returns the result in a NSStream.

## Example

    HTTP h;
    
    h.addHeader("header", "test");
    h.setValue("key", "value");
    h.setValue("key2", "value2");
    h.setOption("followLocation", "true");
    NSStream b = h.getAsStream("https://httpbin.org/get");
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));

