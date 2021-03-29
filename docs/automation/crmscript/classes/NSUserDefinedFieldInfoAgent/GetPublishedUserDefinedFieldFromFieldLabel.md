---
title: crmscript_ref_NSUserDefinedFieldInfoAgent_GetPublishedUserDefinedFieldFromFieldLabel_String_p_0_Integer_p_1
description: NSUserDefinedFieldInfoAgent.GetPublishedUserDefinedFieldFromFieldLabel(String p_0, Integer p_1)
intellisense: NSUserDefinedFieldInfoAgent.GetPublishedUserDefinedFieldFromFieldLabel
keywords: GetPublishedUserDefinedFieldFromFieldLabel(String,Integer)
so.topic: reference
---


Return information about the given user defined field identified by the owner and the field label. Note that field labels are fuzzy. Leading and trailing spaces and punctuation are ignored.



* **fieldLabel:** The field label - the text label shown in the user interface. Trailing spaces and punctuation (":" and ".") are ignored when searching.
* **ownerType:** The user-defined field owner-entity id.
* **Returns:** Returns the user-defined field info carrier, or null if no matching field is found.


