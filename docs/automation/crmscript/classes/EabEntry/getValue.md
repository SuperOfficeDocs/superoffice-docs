---
title: String getValue(String p0)
path: /EJScript/Classes/EabEntry/Member functions/String getValue(String p_0)
intellisense: 1
classref: 1
sortOrder: 277
keywords: getValue(String)
---

Get the value of the given field in the EabEntry instance.



###The following fields are available:###


 - name
 - email
 - sms
 - folderId
 - dbi\_agent_id
 - dbi\_key
 - dbi\_last_syncronized
 - dbi\_last_modified
 - dbi\_delete




###Parameters:###


 - p0: The name of the field.
 - String: The value of the field.




###Example code:###


    EabEntry eab;
    
    Bool b = eab.load(15);
    print(b.toString());
    
    eab.setValue("name", "test");
    print(eab.getValue("name"));


