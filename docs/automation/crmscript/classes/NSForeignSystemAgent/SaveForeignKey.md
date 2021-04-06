---
uid: crmscript_ref_NSForeignSystemAgent_SaveForeignKey
title: ForeignKey SaveForeignKey(ForeignKey foreignKey, String applicationName, String deviceName, String deviceIdentifier)
intellisense: NSForeignSystemAgent.SaveForeignKey
keywords: NSForeignSystemAgent, SaveForeignKey
so.topic: reference
---

Saves a key belonging to the ForeignApp and ForeignDevice specified.

**Parameters:**
 - **foreignKey** Foreign key to save
 - **applicationName** The name of the foreign application.
 - **deviceName** The name of the foreign device.
 - **deviceIdentifier** The device identifier. Optional if device identifier is not used.

**Returns:** The new or updated ForeignKey

```crmscript
NSForeignSystemAgent agent;
ForeignKey foreignKey;
String applicationName;
String deviceName;
String deviceIdentifier;
ForeignKey res = agent.SaveForeignKey(foreignKey, applicationName, deviceName, deviceIdentifier);
```

