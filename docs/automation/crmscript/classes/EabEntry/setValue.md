---
title: crmscript_ref_EabEntry_setValue_String_p_0_String_p_1
description: EabEntry.setValue(String p_0, String p_1)
intellisense: EabEntry.setValue
sortOrder: 279
keywords: setValue(String,String)
so.topic: reference
---

Sets the value of the given field in the EabEntry instance.



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
 - p1: The value to set.




###Example code:###


    EabEntry eab;
    
    Bool b = eab.load(15);
    print(b.toString());
    
    eab.setValue("name", "test");
    print(eab.getValue("name"));


