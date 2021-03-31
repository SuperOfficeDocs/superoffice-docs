---
title: crmscript_ref_NSForeignSystemAgent_SaveForeignDevice
description: ForeignDevice SaveForeignDevice(ForeignDevice foreignDevice, String applicationName)
intellisense: NSForeignSystemAgent.SaveForeignDevice
keywords: NSForeignSystemAgent,SaveForeignDevice
so.topic: reference
---

Saves a foreign device for an foreign application

**Parameters:**
 - **foreignDevice** Foreign device to save
 - **applicationName** The name of the foreign application.

**Returns:** Returns the saved foreign device

```crmscript
NSForeignSystemAgent agent;
ForeignDevice foreignDevice;
String applicationName;
ForeignDevice res = agent.SaveForeignDevice(foreignDevice, applicationName);
```

