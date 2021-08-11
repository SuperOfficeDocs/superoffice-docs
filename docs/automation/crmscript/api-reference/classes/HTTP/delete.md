---
uid: crmscript_ref_HTTP_delete_String_p_0
title: HTTP.delete(String p_0)
intellisense: HTTP.delete
sortOrder: 399
keywords: delete(String)
so.topic: reference
---

# HTTP.delete(String p_0)

Supports both http and https. Returns the result in a byte array.

## Example

    HTTP h;
    
    Byte[] b = h.delete("https://httpbin.org/delete");
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));

