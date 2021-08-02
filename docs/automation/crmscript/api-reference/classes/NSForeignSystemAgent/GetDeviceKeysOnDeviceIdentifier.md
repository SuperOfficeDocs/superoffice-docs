---
uid: crmscript_ref_NSForeignSystemAgent_GetDeviceKeysOnDeviceIdentifier
title: NSForeignKey[] GetDeviceKeysOnDeviceIdentifier(String applicationName, String deviceName, String deviceIdentifier)
intellisense: NSForeignSystemAgent.GetDeviceKeysOnDeviceIdentifier
keywords: NSForeignSystemAgent, GetDeviceKeysOnDeviceIdentifier
so.topic: reference
---

Returns all ForeignKeys that belong to a device with a given deviceIdentifier.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.
 - **deviceIdentifier** Identifier for a unique grouping of keys within a device.

**Returns:** NSForeignKey[]

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
String deviceIdentifier;
NSForeignKey[] res = agent.GetDeviceKeysOnDeviceIdentifier(applicationName, deviceName, deviceIdentifier);
```

