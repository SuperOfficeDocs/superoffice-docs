---
title: crmscript_ref_NSForeignSystemAgent_AddForeignKey
description: ForeignKey AddForeignKey(ForeignKey foreignKey, String applicationName, String deviceName, String deviceIdentifier)
intellisense: NSForeignSystemAgent.AddForeignKey
keywords: NSForeignSystemAgent,AddForeignKey
so.topic: reference
---

Add a new key belonging to the ForeignApp and ForeignDevice specified.

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
ForeignKey res = agent.AddForeignKey(foreignKey, applicationName, deviceName, deviceIdentifier);
```

