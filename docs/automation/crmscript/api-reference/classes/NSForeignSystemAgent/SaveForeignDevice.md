---
uid: crmscript_ref_NSForeignSystemAgent_SaveForeignDevice
title: NSForeignDevice SaveForeignDevice(NSForeignDevice foreignDevice, String applicationName)
intellisense: NSForeignSystemAgent.SaveForeignDevice
keywords: NSForeignSystemAgent, SaveForeignDevice
so.topic: reference
---

# NSForeignDevice SaveForeignDevice(NSForeignDevice foreignDevice, String applicationName)

Saves a foreign device for an foreign application

**Parameters:**
 - **foreignDevice** Foreign device to save
 - **applicationName** The name of the foreign application.

**Returns:** NSForeignDevice

```crmscript
NSForeignSystemAgent agent;
NSForeignDevice foreignDevice;
String applicationName;
NSForeignDevice res = agent.SaveForeignDevice(foreignDevice, applicationName);
```

