---
title: Void setValue(String p\_cgiVariable, String p\_value)
path: /EJScript/Classes/HTTP/Member functions/Void setValue(String p_cgiVariable, String p_value)
intellisense: 1
classref: 1
sortOrder: 418
keywords: setValue(String,String)
---

This function add a cgi variable and its according value to the HTTP request.



###Parameters:###


 - p\_cgiVariable: The variable to set
 - p\_value: The value




###Example code:###


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


