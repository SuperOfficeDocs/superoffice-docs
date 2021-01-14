---
title: NSForeignKey[] GetDeviceKeysOnDeviceIdentifierTable(String applicationName, String deviceName, String deviceIdentifier, String tableName)
path: /EJScript/Classes/NSForeignSystemAgent/Member functions/NSForeignKey[] GetDeviceKeysOnDeviceIdentifierTable(String p_0, String p_1, String p_2, String p_3)
intellisense: 1
classref: 1
sortOrder: 3772
keywords: GetDeviceKeysOnDeviceIdentifierTable(String,String,String,String)
---


Returns all ForeignKeys that belong to a device with a given deviceIdentifier and table name.



* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **deviceIdentifier:** Identifier for a unique grouping of keys within a device.
* **tableName:** Table name, transformed to and from numeric table id by the service layer.\<p/>Use an empty string to indicate that your key is not bound to any specific table.
* **Returns:** Array of all ForeignKeys in the ForeignDevice that belong to the DeviceIdentifier.


