---
title: crmscript_ref_NSPersonAgent_GetSalesRep_String_p_0_String_p_1_String_p_2_String_p_3_String_p_4
description: NSPersonAgent.GetSalesRep(String p_0, String p_1, String p_2, String p_3, String p_4)
intellisense: NSPersonAgent.GetSalesRep
keywords: GetSalesRep(String,String,String,String,String)
so.topic: reference
---


Returns the sales representative for an external user. If this method is accessed with anonymous authentication the external user is recognized by contact and name, or by email, or phone number. If the external user is recognized as an CRM5 user (internal or external) the input fields can be left blank.



* **contactName:** The company name of the person requesting his sales representative. May be empty if email or phone is provided.
* **personFirstname:** The firstname of the person requesting his sales representative. May be empty if email or phone is provided.
* **personLastname:** The lastname of the person requesting his sales representative. May be empty if email or phone is provided.
* **emailAddress:** The email address of the person requesting his sales representative. May be empty if phone, or contact and person name is provided.
* **phoneNumber:** The phone number of the person requesting his sales representative. May be empty if email, or contact and person name is provided.
* **Returns:** The PersonEntity of the sales rep.


