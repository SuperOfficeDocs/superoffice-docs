---
title: crmscript_ref_NSUserAgent_CreateDefaultUserFromUserTypeAndCredential_Integer_p_0_Integer_p_1_String_p_2_String_p_3_String_p_4
description: NSUserAgent.CreateDefaultUserFromUserTypeAndCredential(Integer p_0, Integer p_1, String p_2, String p_3, String p_4)
intellisense: NSUserAgent.CreateDefaultUserFromUserTypeAndCredential
keywords: CreateDefaultUserFromUserTypeAndCredential(Integer,Integer,String,String,String)
so.topic: reference
---


Creates a PersonEntity with default values based on the contactId and credentials.



* **userType:** Type of associate for the user
* **contactId:** Contact id of the person
* **credentialType:** Type of credentials, corresponding to name of plugin and type in the credentials table.
* **credentialValue:** This is the actuall value of the credentials.  This will typically be the password or teh users SID in active directory
* **credentialDisplayValue:** The value displayed to the user. this will typically be the users login name in active directory.


