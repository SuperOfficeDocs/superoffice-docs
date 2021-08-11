---
uid: crmscript_ref_HTTP_putAsStream_String_p_0
title: HTTP.putAsStream(String p_0)
intellisense: HTTP.putAsStream
sortOrder: 410
keywords: putAsStream(String)
so.topic: reference
---

# HTTP.putAsStream(String p_0)

Supports both http and https. Returns the result in a NSStream.

## Example

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

