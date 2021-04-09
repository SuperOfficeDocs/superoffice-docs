---
uid: crmscript_ref_HTTP_setValue_String_p_cgiVariable_String_p_value
title: HTTP.setValue(String p_cgiVariable, String p_value)
intellisense: HTTP.setValue
sortOrder: 418
keywords: setValue(String,String)
so.topic: reference
---

This function add a cgi variable and its according value to the HTTP request.



## Parameters


 - p\_cgiVariable: The variable to set
 - p\_value: The value




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


