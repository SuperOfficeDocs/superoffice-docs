---
title: crmscript_ref_NSForeignSystemAgent_GetKeyByValue_String_p_0_String_p_1_String_p_2_String_p_3_String_p_4
description: NSForeignSystemAgent.GetKeyByValue(String p_0, String p_1, String p_2, String p_3, String p_4)
intellisense: NSForeignSystemAgent.GetKeyByValue
sortOrder: 3765
keywords: GetKeyByValue(String,String,String,String,String)
so.topic: reference
---


Get a foreignkey based on its name and value, that belongs to the specified device and application.



* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **keyName:** The name of the foreign key.
* **keyValue:** Foreignkey value
* **tableName:** Table name, transformed to and from numeric table id by the service layer.\<p/>Use an empty string to indicate that your key is not bound to any specific table.
* **Returns:** The ForeignKey.


