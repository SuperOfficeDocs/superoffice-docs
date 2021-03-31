---
title: crmscript_ref_NSForeignSystemAgent_DeleteDeviceByIdentifier
description: Void DeleteDeviceByIdentifier(String applicationName, String deviceName, String deviceIdentifier)
intellisense: NSForeignSystemAgent.DeleteDeviceByIdentifier
keywords: NSForeignSystemAgent,DeleteDeviceByIdentifier
so.topic: reference
---

Delete a ForeignDevice with deviceName and deviceIdentifier that belongs to the application with applicationName.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.
 - **deviceIdentifier** Unique id of device (Palm pilot device ID, version number, etc)

**Returns:** This method has no return value

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
String deviceIdentifier;
Void res = agent.DeleteDeviceByIdentifier(applicationName, deviceName, deviceIdentifier);
```

