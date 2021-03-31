---
title: crmscript_ref_NSForeignSystemAgent_SaveDeviceByIdentifier
description: ForeignDevice SaveDeviceByIdentifier(String applicationName, String deviceName, String deviceIdentifier, ForeignDevice foreignDevice)
intellisense: NSForeignSystemAgent.SaveDeviceByIdentifier
keywords: NSForeignSystemAgent,SaveDeviceByIdentifier
so.topic: reference
---

Updates a ForeignDevice with deviceName that belongs to the application with applicationName.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.
 - **deviceIdentifier** Unique id of device (Palm pilot device ID, version number, etc)
 - **foreignDevice** Foreign device to save. Can be null if adding new device.

**Returns:** The ForeignDevice.

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
String deviceIdentifier;
ForeignDevice foreignDevice;
ForeignDevice res = agent.SaveDeviceByIdentifier(applicationName, deviceName, deviceIdentifier, foreignDevice);
```

