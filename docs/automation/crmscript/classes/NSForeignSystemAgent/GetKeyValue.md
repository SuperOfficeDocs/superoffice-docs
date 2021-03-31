---
title: crmscript_ref_NSForeignSystemAgent_GetKeyValue
description: String GetKeyValue(String applicationName, String deviceName, String keyName, String tableName, Integer recordId)
intellisense: NSForeignSystemAgent.GetKeyValue
keywords: NSForeignSystemAgent,GetKeyValue
so.topic: reference
---

Gets the string value of a ForeignKey, that belongs to the specified device and application. The table name and record ID must also be specified.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.
 - **keyName** The name of the foreign key.
 - **tableName** Table name, transformed to and from numeric table id by the service layer.<p/>Use an empty string to indicate that your key is not bound to any specific table.
 - **recordId** Id of record that this key refers to. If the table name was blank, then this parameter must be 0. It can also be 0 to mean that the foreign key record was not bound to any particular record of the target table.

**Returns:** The ForeignKey value as string.

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
String keyName;
String tableName;
Integer recordId;
String res = agent.GetKeyValue(applicationName, deviceName, keyName, tableName, recordId);
```

