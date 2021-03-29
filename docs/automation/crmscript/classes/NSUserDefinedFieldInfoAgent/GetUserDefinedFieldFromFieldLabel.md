---
title: crmscript_ref_NSUserDefinedFieldInfoAgent_GetUserDefinedFieldFromFieldLabel_String_p_0_Integer_p_1
description: NSUserDefinedFieldInfoAgent.GetUserDefinedFieldFromFieldLabel(String p_0, Integer p_1)
intellisense: NSUserDefinedFieldInfoAgent.GetUserDefinedFieldFromFieldLabel
keywords: GetUserDefinedFieldFromFieldLabel(String,Integer)
so.topic: reference
---


Return information about the given user defined field identified by the owner and the field label. Note that field labels are fuzzy. Leading and trailing spaces and punctuation are ignored. Note this may be different than the currently published fields.



* **fieldLabel:** The field label - the text label shown in the user interface. Trailing spaces and punctuation (":" and ".") are ignored when searching.
* **ownerType:** The user-defined field owner-entity id.
* **Returns:** Returns the user-defined field info carrier, or null if no matching field is found.


