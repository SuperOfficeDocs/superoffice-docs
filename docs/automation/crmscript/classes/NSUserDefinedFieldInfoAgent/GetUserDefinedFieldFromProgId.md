---
title: crmscript_ref_NSUserDefinedFieldInfoAgent_GetUserDefinedFieldFromProgId_String_p_0_Integer_p_1
description: NSUserDefinedFieldInfoAgent.GetUserDefinedFieldFromProgId(String p_0, Integer p_1)
intellisense: NSUserDefinedFieldInfoAgent.GetUserDefinedFieldFromProgId
keywords: GetUserDefinedFieldFromProgId(String,Integer)
so.topic: reference
---


Return information about the given user defined field identified by the owner and the prog-id. The prog-id is used as the key in the entity carriers. Note this may be different than the currently published fields.



* **progId:** The prog.id is a hidden name that uniquely identifies the field.
* **ownerType:** The user-defined field owner-entity id.
* **Returns:** Returns the user-defined field info carrier, or null if no matching field is found.


