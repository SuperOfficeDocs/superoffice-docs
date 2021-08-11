---
uid: crmscript_ref_HTTP_postAsStream_String_p_0
title: HTTP.postAsStream(String p_0)
intellisense: HTTP.postAsStream
sortOrder: 409
keywords: postAsStream(String)
so.topic: reference
---

# HTTP.postAsStream(String p_0)

Supports both http and https. Returns the result in a NSStream.

## Example

    HTTP h;
    
    h.addHeader("header", "test");
    h.setValue("key", "value");
    h.setValue("key2", "value2");
    h.setOption("followLocation", "true");
    NSStream b = h.postAsStream("https://httpbin.org/post");
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));

