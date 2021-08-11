---
uid: crmscript_ref_NSForeignSystemAgent_SaveForeignKey
title: NSForeignKey SaveForeignKey(NSForeignKey foreignKey, String applicationName, String deviceName, String deviceIdentifier)
intellisense: NSForeignSystemAgent.SaveForeignKey
keywords: NSForeignSystemAgent, SaveForeignKey
so.topic: reference
---

# NSForeignKey SaveForeignKey(NSForeignKey foreignKey, String applicationName, String deviceName, String deviceIdentifier)

Saves a key belonging to the ForeignApp and NSForeignDevice specified.

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
NSForeignKey res = agent.SaveForeignKey(foreignKey, applicationName, deviceName, deviceIdentifier);
```

