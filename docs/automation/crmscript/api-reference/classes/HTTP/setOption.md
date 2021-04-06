---
uid: crmscript_ref_HTTP_setOption_String_p_name_String_p_value
title: HTTP.setOption(String p_name, String p_value)
intellisense: HTTP.setOption
sortOrder: 417
keywords: setOption(String,String)
so.topic: reference
---


Option function.


Possible values for p\_name and p\_value:


 - "verifyPeer" - p\_value: bool - verify the peer's SSL sertificate
 - <b>"verifyHost"</b> - p\_value: bool - verify the certificate's name against the host
 - <b>"timeout"</b> - p\_value: int - set maximum time the request is allowed to take
 - <b>"followLocation"</b> - p\_value: bool - follow HTTP 3xx redirects if set to 1, default is 0
 - <b>"username"</b> - p\_value: string - username used in authentication
 - <b>"password"</b> - p\_value: string - password used in authentication
 - <b>"parameters"</b> - p\_value: string - The complete parameters to post. This will replace whatever you have added using .setValue(), but allows you to specify the whole parameter to post. Useful when posting e.g. JSON structs instead of name=value pairs. NOTE: you need to prefix whatever you want to send with a dummy character (which will be removed)  due to complexities in this class. See example below.
 - <b>"authenticationMethod"</b> - p\_value - which authentication method to use. Legal values are:
    "basic" (default)
    "digest"
    "gssnegotiate"
    "ntlm"
    "digest\_ie"
    "ntlm\_wb"
    "none"
- "parametersUTF8" - p\_value: bool. From version 8.2R3. This option makes the parameters be encoded as UTF-8. Normally this is what you want, but to not break any old uses, this is an optional option.




###Example code:###


    HTTP h;
    
    h.addHeader("header", "test");
    h.setValue("key", "value");
    h.setValue("key2", "value2");
    h.setOption("followLocation", "true");
    
    Byte[] b = h.post("https://httpbin.org/post");
    
    if (h.hasError())
      print(h.getErrorMessage());
    else
      print(String(b));
    

/* Here is an example for creating an issue in JIRA, hosted by Atlassian*/

    HTTP h2;
    String json = " {
      \"fields\": {
        \"project\": {
          \"key\": \"SUP\"
        },

    \"summary\": \"I have a problem!.\",
    \"description\": \"Thats awesome\",

        \"issuetype\": {
          \"name\": \"Bug\"
        }
      }
    }";
    
    HTTP h;
    h.setOption("username", "theUsername");
    h.setOption("password", "thePassword");
    h.addHeader("Content-Type", "application/json");
    h.setOption("parameters", json);
    print(String(h.post("https://theInstance.atlassian.net/rest/api/2/issue/")));


