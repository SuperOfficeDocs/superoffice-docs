---
uid: crmscript_ref_HTTP_get_String_p_0
title: HTTP.get(String p_0)
intellisense: HTTP.get
sortOrder: 400
keywords: get(String)
so.topic: reference
---

# HTTP.get(String p_0)

Supports both http and https. Returns the result in a byte array.

## Example

    HTTP h;
    
    h.addHeader("header", "test");
    h.setValue("key", "value");
    h.setValue("key2", "value2");
    h.setOption("followLocation", "true");
    Byte[] b = h.get("https://httpbin.org/get");
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));

