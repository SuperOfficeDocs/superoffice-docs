---
title: crmscript_ref_NSPersonAgent_CreateDefaultFromCredential_Integer_p_0_String_p_1_String_p_2_String_p_3
description: NSPersonAgent.CreateDefaultFromCredential(Integer p_0, String p_1, String p_2, String p_3)
intellisense: NSPersonAgent.CreateDefaultFromCredential
keywords: CreateDefaultFromCredential(Integer,String,String,String)
so.topic: reference
---


Creates a PersonEntity with default values based on the contactId and credentials.



* **contactId:** Contact id of the person
* **credentialType:** Type of credentials, corresponding to name of plugin and type in the credentials table.
* **credentialValue:** This is the actuall value of the credentials.  This will typically be the password or teh users SID in active directory
* **credentialDisplayValue:** The value displayed to the user. this will typically be the users login name in active directory.


