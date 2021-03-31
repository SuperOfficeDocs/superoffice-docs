---
title: crmscript_ref_NSPocketAgent_GetPushNotificationTagsForDevice
description: String GetPushNotificationTagsForDevice(String deviceIdentifier)
intellisense: NSPocketAgent.GetPushNotificationTagsForDevice
keywords: NSPocketAgent,GetPushNotificationTagsForDevice
so.topic: reference
---

Retrieve current tag value for a device

**Parameters:**
 - **deviceIdentifier** The unique identifier of this device

**Returns:** A comma separated list of events this device should receive push events for

```crmscript
NSPocketAgent agent;
String deviceIdentifier;
String res = agent.GetPushNotificationTagsForDevice(deviceIdentifier);
```

