---
uid: crmscript_ref_EabEntry_getValue_String_p_0
title: EabEntry.getValue(String p_0)
intellisense: EabEntry.getValue
sortOrder: 277
keywords: getValue(String)
so.topic: reference
---

Get the value of the given field in the EabEntry instance.

## Available fields

 - name
 - email
 - sms
 - folderId
 - dbi\_agent_id
 - dbi\_key
 - dbi\_last_syncronized
 - dbi\_last_modified
 - dbi\_delete




## Parameters


 - p0: The name of the field.
 - String: The value of the field.




## Example


    EabEntry eab;
    
    Bool b = eab.load(15);
    print(b.toString());
    
    eab.setValue("name", "test");
    print(eab.getValue("name"));


