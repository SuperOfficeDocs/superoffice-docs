---
title: crmscript_ref_NSBLOBAgent_SetAppData_String_p_0_String_p_1
description: NSBLOBAgent.SetAppData(String p_0, String p_1)
intellisense: NSBLOBAgent.SetAppData
sortOrder: 1432
keywords: SetAppData(String,String)
so.topic: reference
---


Get a CLOB (limited to a reasonable size by the mechanics of Web Services) according to a string key; ALSO limits to the current ApplicationToken if any. Existing data, if any, will be overwritten. Overwrite with a blank value to delete.



* **key:** The key string, less than 200 characters. Must be unique within each application.
* **data:** The applications value, suggested to be a JSON, XML or other readable structure
* **Returns:** This method has no return value


