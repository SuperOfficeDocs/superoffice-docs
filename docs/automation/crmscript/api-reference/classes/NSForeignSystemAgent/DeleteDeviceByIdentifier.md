---
uid: crmscript_ref_NSForeignSystemAgent_DeleteDeviceByIdentifier
title: Void DeleteDeviceByIdentifier(String applicationName, String deviceName, String deviceIdentifier)
intellisense: NSForeignSystemAgent.DeleteDeviceByIdentifier
keywords: NSForeignSystemAgent, DeleteDeviceByIdentifier
so.topic: reference
---

Delete a NSForeignDevice with deviceName and deviceIdentifier that belongs to the application with applicationName.

**Parameters:**
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.
 - **deviceIdentifier** Unique id of device (Palm pilot device ID, version number, etc)

```crmscript
NSForeignSystemAgent agent;
String applicationName;
String deviceName;
String deviceIdentifier;
agent.DeleteDeviceByIdentifier(applicationName, deviceName, deviceIdentifier);
```

