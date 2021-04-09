---
uid: crmscript_ref_HTTP_getErrorMessage
title: HTTP.getErrorMessage()
intellisense: HTTP.getErrorMessage
sortOrder: 412
keywords: getErrorMessage()
so.topic: reference
---

Returns the last error message.



## Example


    HTTP h;
    
    h.addHeader("header", "test");
    h.setValue("key", "value");
    h.setValue("key2", "value2");
    h.setOption("followLocation", "true");
    Byte[] b = h.put("https://httpbin.org/put");
    
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));


