---
title: crmscript_ref_NSUserDefinedFieldInfoAgent_GetCustomFieldInfoList_String_p_0_Bool_p_1
description: NSUserDefinedFieldInfoAgent.GetCustomFieldInfoList(String p_0, Bool p_1)
intellisense: NSUserDefinedFieldInfoAgent.GetCustomFieldInfoList
keywords: GetCustomFieldInfoList(String,Bool)
so.topic: reference
---


Return information about all the custom fields (user-defined + extra) on a particular table



* **tableName:** The name of table that owns the custom fields. e.g. 'contact', 'person', 'project' etc.
* **includeStandard:** Include standard fields in result. Default false.
* **Returns:** Array of user-defined and extra field info in rank order. Describes default values, mandatory, visiblity, labels and choices.


