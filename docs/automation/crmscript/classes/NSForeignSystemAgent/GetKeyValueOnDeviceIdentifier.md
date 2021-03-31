---
uid: crmscript_ref_NSForeignSystemAgent_GetKeyValueOnDeviceIdentifier
title: String GetKeyValueOnDeviceIdentifier(String applicationName, String deviceName, String deviceIdentifier, String keyName, String tableName, Integer recordId)
intellisense: NSForeignSystemAgent.GetKeyValueOnDeviceIdentifier
keywords: NSForeignSystemAgent, GetKeyValueOnDeviceIdentifier
so.topic: reference
---

Returning a foreign key string value by its key name and device identifier, that belongs to the specified device and application. A table name and record ID can also be specified.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.
 - **deviceIdentifier** The device identifier.
 - **keyName** The name of the foreign key.
 - **tableName** Table name, transformed to and from numeric table id by the service layer.<p/>Use an empty string to indicate that your key is not bound to any specific table.
 - **recordId** Id of record that this key refers to. If the table name was blank, then this parameter must be 0. It can also be 0 to mean that the foreign key record was not bound to any particular record of the target table.

**Returns:** The ForeignKey's string value.

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
String deviceIdentifier;
String keyName;
String tableName;
Integer recordId;
String res = agent.GetKeyValueOnDeviceIdentifier(applicationName, deviceName, deviceIdentifier, keyName, tableName, recordId);
```

