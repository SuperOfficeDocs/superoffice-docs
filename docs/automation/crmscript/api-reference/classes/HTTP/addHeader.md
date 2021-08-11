---
uid: crmscript_ref_HTTP_addHeader_String_p_name_String_p_value
title: HTTP.addHeader(String p_name, String p_value)
intellisense: HTTP.addHeader
sortOrder: 415
keywords: addHeader(String,String)
so.topic: reference
---

# HTTP.addHeader(String p_name, String p_value)

Adds a new header. The new header will be placed after other existing headers.

## Parameters

 - p\_name: name of header
 - p\_value: value of header

## Example

    HTTP h;
    
    h.addHeader("header", "test");
    
    Byte[] b = h.post("https://httpbin.org/post");
    
    if (h.hasError())
    print(h.getErrorMessage());
    else
    print(String(b));

