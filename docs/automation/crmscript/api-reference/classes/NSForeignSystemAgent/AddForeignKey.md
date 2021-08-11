---
uid: crmscript_ref_NSForeignSystemAgent_AddForeignKey
title: NSForeignKey AddForeignKey(NSForeignKey foreignKey, String applicationName, String deviceName, String deviceIdentifier)
intellisense: NSForeignSystemAgent.AddForeignKey
keywords: NSForeignSystemAgent, AddForeignKey
so.topic: reference
---

# NSForeignKey AddForeignKey(NSForeignKey foreignKey, String applicationName, String deviceName, String deviceIdentifier)

Add a new key belonging to the ForeignApp and NSForeignDevice specified.

**Parameters:**
 - **foreignKey** Foreign key to save
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.
 - **deviceIdentifier** The device identifier. Optional if device identifier is not used.

**Returns:** NSForeignKey

```crmscript
NSForeignSystemAgent agent;
NSForeignKey foreignKey;
String applicationName;
String deviceName;
String deviceIdentifier;
NSForeignKey res = agent.AddForeignKey(foreignKey, applicationName, deviceName, deviceIdentifier);
```

