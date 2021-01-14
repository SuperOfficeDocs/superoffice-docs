---
title: NSUserDefinedFieldInfo GetUserDefinedFieldFromFieldLabel(String fieldLabel, Integer ownerType)
path: /EJScript/Classes/NSUserDefinedFieldInfoAgent/Member functions/NSUserDefinedFieldInfo GetUserDefinedFieldFromFieldLabel(String p_0, Integer p_1)
intellisense: 1
classref: 1
sortOrder: 8633
keywords: GetUserDefinedFieldFromFieldLabel(String,Integer)
---


Return information about the given user defined field identified by the owner and the field label. Note that field labels are fuzzy. Leading and trailing spaces and punctuation are ignored. Note this may be different than the currently published fields.



* **fieldLabel:** The field label - the text label shown in the user interface. Trailing spaces and punctuation (":" and ".") are ignored when searching.
* **ownerType:** The user-defined field owner-entity id.
* **Returns:** Returns the user-defined field info carrier, or null if no matching field is found.


