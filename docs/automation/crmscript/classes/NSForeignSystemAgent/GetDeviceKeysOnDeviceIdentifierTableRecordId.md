---
title: crmscript_ref_NSForeignSystemAgent_GetDeviceKeysOnDeviceIdentifierTableRecordId
description: ForeignKeyArray GetDeviceKeysOnDeviceIdentifierTableRecordId(String applicationName, String deviceName, String deviceIdentifier, String tableName, Integer recordId)
intellisense: NSForeignSystemAgent.GetDeviceKeysOnDeviceIdentifierTableRecordId
keywords: NSForeignSystemAgent,GetDeviceKeysOnDeviceIdentifierTableRecordId
so.topic: reference
---

Returns all ForeignKeys that belong to a device with a given deviceIdentifier and table name, as well as record id.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.
 - **deviceIdentifier** Identifier for a unique grouping of keys within a device.
 - **tableName** Table name, transformed to and from numeric table id by the service layer.<p/>Use an empty string to indicate that your key is not bound to any specific table.
 - **recordId** Id of record that this key refers to. If the table name was blank, then this parameter must be 0. It can also be 0 to mean that the foreign key record was not bound to any particular record of the target table.

**Returns:** Array of all ForeignKeys in the ForeignDevice that match the criteria

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
String deviceIdentifier;
String tableName;
Integer recordId;
ForeignKeyArray res = agent.GetDeviceKeysOnDeviceIdentifierTableRecordId(applicationName, deviceName, deviceIdentifier, tableName, recordId);
```

