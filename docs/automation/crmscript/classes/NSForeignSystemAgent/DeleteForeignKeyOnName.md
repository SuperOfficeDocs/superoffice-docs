---
uid: crmscript_ref_NSForeignSystemAgent_DeleteForeignKeyOnName
title: Void DeleteForeignKeyOnName(String applicationName, String deviceName, String deviceIdentifier, String keyName, String tableName, Integer recordId)
intellisense: NSForeignSystemAgent.DeleteForeignKeyOnName
keywords: NSForeignSystemAgent, DeleteForeignKeyOnName
so.topic: reference
---

Deletes all specified occurrences of a key, belonging to the ForeignApp and ForeignDevice, table and record specified. Specifying a blank table name will delete ALL keys of the given name; specifying a recordId of 0 will delete ALL keys of the given name for the given table.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.
 - **deviceIdentifier** The device identifier. Optional if device identifier is not used.
 - **keyName** The name of the foreign key to delete.
 - **tableName** Table name, transformed to and from numeric table id by the service layer.<p/>Use an empty string to delete ALL keys that otherwise match; this may be dangerous and can take a long time if there are many items to delete.
 - **recordId** Id of record that this key refers to. If the table name was blank, then this parameter must be 0. It can also be 0 to mean that the foreign key record was not bound to any particular record of the target table.<p/>Specifying a zero recordId will remove the recordId restriction and delete all keys that otherwise match.

**Returns:** This method has no return value

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
String deviceIdentifier;
String keyName;
String tableName;
Integer recordId;
Void res = agent.DeleteForeignKeyOnName(applicationName, deviceName, deviceIdentifier, keyName, tableName, recordId);
```

