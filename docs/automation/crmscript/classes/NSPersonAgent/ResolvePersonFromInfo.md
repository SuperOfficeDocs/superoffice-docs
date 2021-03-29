---
title: crmscript_ref_NSPersonAgent_ResolvePersonFromInfo_Integer_p_0_String_p_1_String__p_2_String__p_3
description: NSPersonAgent.ResolvePersonFromInfo(Integer p_0, String p_1, String[] p_2, String[] p_3)
intellisense: NSPersonAgent.ResolvePersonFromInfo
keywords: ResolvePersonFromInfo(Integer,String,String[],String[])
so.topic: reference
---


Get a person from the provided information. If the person does not exist, it will be created on demand.



* **contactId:** The contact Id of the contact which the person belongs to. Cannot be 0.
* **personName:** The full name of the person to be resolved. Optional.
* **phoneNumbers:** Phone numbers registered on the person. Optional.
* **emails:** Email-addresses registered on the person. Optional.
* **Returns:** The results of the resolve-operation.


