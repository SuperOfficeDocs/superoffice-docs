---
title: crmscript_ref_NSUserAgent_SetExternalUserInfo_Integer_p_0_String_p_1_String_p_2_Bool_p_3_Integer_p_4_Integer_p_5
description: NSUserAgent.SetExternalUserInfo(Integer p_0, String p_1, String p_2, Bool p_3, Integer p_4, Integer p_5)
intellisense: NSUserAgent.SetExternalUserInfo
keywords: SetExternalUserInfo(Integer,String,String,Bool,Integer,Integer)
so.topic: reference
---


Modifies an external user. Changes external users information according to the flags set in  externalUserInfoModification.



* **associateId:** The associateId to alter.
* **userName:** Login username.
* **password:** Login password.
* **isActive:** Set isActive to true to enable the external user to log in.
* **roleId:** Id of role for the external user. The role must be a role of type external users.
* **externalUserInfoModification:** externalUserInfoModification is a flag describing what to change. \<see cref="SuperOffice.CRM.Services.Util.ExternalUserInfoModification"/>.


