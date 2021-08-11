---
uid: crmscript_ref_HTTP_patch_String_p_0
title: HTTP.patch(String p_0)
intellisense: HTTP.patch
sortOrder: 402
keywords: patch(String)
so.topic: reference
---

# HTTP.patch(String p_0)

Supports both http and https. Returns the result in a byte array.

## Example

    HTTP h;
    
    h.addHeader("header", "test");
    h.setValue("key", "value");
    h.setValue("key2", "value2");
    h.setOption("followLocation", "true");
    Byte[] b = h.patch("https://httpbin.org/patch");
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));

