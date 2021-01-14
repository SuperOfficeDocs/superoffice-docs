---
title: NSForeignKey GetKeyByValueAndIdentifier(String applicationName, String deviceName, String deviceIdentifier, String keyName, String keyValue, String tableName)
path: /EJScript/Classes/NSForeignSystemAgent/Member functions/NSForeignKey GetKeyByValueAndIdentifier(String p_0, String p_1, String p_2, String p_3, String p_4, String p_5)
intellisense: 1
classref: 1
sortOrder: 3766
keywords: GetKeyByValueAndIdentifier(String,String,String,String,String,String)
---


Get a foreignkey based on its name and value, that belongs to the specified deviceId, device, and application.



* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **deviceIdentifier:** The device identifier. Optional if device identifier is not used.
* **keyName:** The name of the foreign key.
* **keyValue:** Foreignkey value
* **tableName:** Table name, transformed to and from numeric table id by the service layer.\<p/>Use an empty string to indicate that your key is not bound to any specific table.
* **Returns:** The ForeignKey.


