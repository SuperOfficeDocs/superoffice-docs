---
uid: crmscript_ref_NSForeignSystemAgent_SaveDeviceByIdentifier
title: NSForeignDevice SaveDeviceByIdentifier(String applicationName, String deviceName, String deviceIdentifier, NSForeignDevice foreignDevice)
intellisense: NSForeignSystemAgent.SaveDeviceByIdentifier
keywords: NSForeignSystemAgent, SaveDeviceByIdentifier
so.topic: reference
---

# NSForeignDevice SaveDeviceByIdentifier(String applicationName, String deviceName, String deviceIdentifier, NSForeignDevice foreignDevice)

Updates a NSForeignDevice with deviceName that belongs to the application with applicationName.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.
 - **deviceIdentifier** Unique id of device (Palm pilot device ID, version number, etc)
 - **foreignDevice** Foreign device to save. Can be null if adding new device.

**Returns:** NSForeignDevice

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
String deviceIdentifier;
NSForeignDevice foreignDevice;
NSForeignDevice res = agent.SaveDeviceByIdentifier(applicationName, deviceName, deviceIdentifier, foreignDevice);
```

