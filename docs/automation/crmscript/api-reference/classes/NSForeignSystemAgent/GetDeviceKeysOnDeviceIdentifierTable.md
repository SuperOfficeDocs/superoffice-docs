---
uid: crmscript_ref_NSForeignSystemAgent_GetDeviceKeysOnDeviceIdentifierTable
title: NSForeignKey[] GetDeviceKeysOnDeviceIdentifierTable(String applicationName, String deviceName, String deviceIdentifier, String tableName)
intellisense: NSForeignSystemAgent.GetDeviceKeysOnDeviceIdentifierTable
keywords: NSForeignSystemAgent, GetDeviceKeysOnDeviceIdentifierTable
so.topic: reference
---

# NSForeignKey[] GetDeviceKeysOnDeviceIdentifierTable(String applicationName, String deviceName, String deviceIdentifier, String tableName)

Returns all ForeignKeys that belong to a device with a given deviceIdentifier and table name.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.
 - **deviceIdentifier** Identifier for a unique grouping of keys within a device.
 - **tableName** Table name, transformed to and from numeric table id by the service layer.<p/>Use an empty string to indicate that your key is not bound to any specific table.

**Returns:** NSForeignKey[]

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
String deviceIdentifier;
String tableName;
NSForeignKey[] res = agent.GetDeviceKeysOnDeviceIdentifierTable(applicationName, deviceName, deviceIdentifier, tableName);
```

