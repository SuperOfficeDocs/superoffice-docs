---
title: crmscript_ref_NSForeignSystemAgent_GetKeyOnDeviceIdentifier_String_p_0_String_p_1_String_p_2_String_p_3_String_p_4_Integer_p_5
description: NSForeignSystemAgent.GetKeyOnDeviceIdentifier(String p_0, String p_1, String p_2, String p_3, String p_4, Integer p_5)
intellisense: NSForeignSystemAgent.GetKeyOnDeviceIdentifier
sortOrder: 3767
keywords: GetKeyOnDeviceIdentifier(String,String,String,String,String,Integer)
so.topic: reference
---


Returning a foreign key by its key name and device identifier, that belongs to the specified device and application. A table name and record ID can also be specified.



* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **deviceIdentifier:** The device identifier.
* **keyName:** The name of the foreign key.
* **tableName:** Table name, transformed to and from numeric table id by the service layer.\<p/>Use an empty string to indicate that your key is not bound to any specific table.
* **recordId:** Id of record that this key refers to. If the table name was blank, then this parameter must be 0. It can also be 0 to mean that the foreign key record was not bound to any particular record of the target table.
* **Returns:** The ForeignKey.


