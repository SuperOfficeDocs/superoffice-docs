---
title: crmscript_ref_NSForeignSystemAgent_GetDeviceKeysOnDeviceIdentifierTableRecordId_String_p_0_String_p_1_String_p_2_String_p_3_Integer_p_4
description: NSForeignSystemAgent.GetDeviceKeysOnDeviceIdentifierTableRecordId(String p_0, String p_1, String p_2, String p_3, Integer p_4)
intellisense: NSForeignSystemAgent.GetDeviceKeysOnDeviceIdentifierTableRecordId
sortOrder: 3773
keywords: GetDeviceKeysOnDeviceIdentifierTableRecordId(String,String,String,String,Integer)
so.topic: reference
---


Returns all ForeignKeys that belong to a device with a given deviceIdentifier and table name, as well as record id.



* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **deviceIdentifier:** Identifier for a unique grouping of keys within a device.
* **tableName:** Table name, transformed to and from numeric table id by the service layer.\<p/>Use an empty string to indicate that your key is not bound to any specific table.
* **recordId:** Id of record that this key refers to. If the table name was blank, then this parameter must be 0. It can also be 0 to mean that the foreign key record was not bound to any particular record of the target table.
* **Returns:** Array of all ForeignKeys in the ForeignDevice that match the criteria


