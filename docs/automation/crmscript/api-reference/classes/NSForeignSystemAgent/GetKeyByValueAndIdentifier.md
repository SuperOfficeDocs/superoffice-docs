---
uid: crmscript_ref_NSForeignSystemAgent_GetKeyByValueAndIdentifier
title: NSForeignKey GetKeyByValueAndIdentifier(String applicationName, String deviceName, String deviceIdentifier, String keyName, String keyValue, String tableName)
intellisense: NSForeignSystemAgent.GetKeyByValueAndIdentifier
keywords: NSForeignSystemAgent, GetKeyByValueAndIdentifier
so.topic: reference
---

# NSForeignKey GetKeyByValueAndIdentifier(String applicationName, String deviceName, String deviceIdentifier, String keyName, String keyValue, String tableName)

Get a foreignkey based on its name and value, that belongs to the specified deviceId, device, and application.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.
 - **deviceIdentifier** The device identifier. Optional if device identifier is not used.
 - **keyName** The name of the foreign key.
 - **keyValue** Foreignkey value
 - **tableName** Table name, transformed to and from numeric table id by the service layer.<p/>Use an empty string to indicate that your key is not bound to any specific table.

**Returns:** NSForeignKey

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
String deviceIdentifier;
String keyName;
String keyValue;
String tableName;
NSForeignKey res = agent.GetKeyByValueAndIdentifier(applicationName, deviceName, deviceIdentifier, keyName, keyValue, tableName);
```

