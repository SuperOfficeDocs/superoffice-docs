---
title: crmscript_ref_NSForeignSystemAgent_GetDeviceKeysOnDeviceIdentifierTable_String_p_0_String_p_1_String_p_2_String_p_3
description: NSForeignSystemAgent.GetDeviceKeysOnDeviceIdentifierTable(String p_0, String p_1, String p_2, String p_3)
intellisense: NSForeignSystemAgent.GetDeviceKeysOnDeviceIdentifierTable
sortOrder: 3772
keywords: GetDeviceKeysOnDeviceIdentifierTable(String,String,String,String)
so.topic: reference
---


Returns all ForeignKeys that belong to a device with a given deviceIdentifier and table name.



* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **deviceIdentifier:** Identifier for a unique grouping of keys within a device.
* **tableName:** Table name, transformed to and from numeric table id by the service layer.\<p/>Use an empty string to indicate that your key is not bound to any specific table.
* **Returns:** Array of all ForeignKeys in the ForeignDevice that belong to the DeviceIdentifier.


