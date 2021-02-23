---
title: foreign_keys       
description: Foreign keys
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords:
so.topic: concept
---

# Foreign keys

```csharp
using SuperOffice.CRM.Services;
using(SoSession.Authenticate("SAL1" , ""))
{
  using(ForeignSystemAgent agent = new ForeignSystemAgent())
  {
    // create application
    string appName = "App" + DateTime.Now.Ticks.ToString();
    ForeignAppEntity app = new ForeignAppEntity();
    app.Name = appName;
    app = agent.SaveForeignAppEntity(app);

    // create device under application
    ForeignDevice device = new ForeignDevice();
    device.Name = "Device" + DateTime.Now.Ticks.ToString();
    device.DeviceIdentifier = "DeviceId" + DateTime.Now.Ticks.ToString();
    device.ForeignAppId = app.ForeignAppId;
    device = agent.SaveForeignDevice(device, app.Name);

    // create key under device
    ForeignKey key = new ForeignKey();
    key.Key = "A Key";
    key.Value = "testkey" + DateTime.Now.Ticks.ToString();
    key = agent.SaveForeignKey(key, app.Name, device.Name, device.DeviceIdentifier);

    // now get the key back again
    ForeignKey savedKey = agent.GetKey(app.Name, device.Name, "A Key");
  }
}
```

<!-- See Also: ForeignKey, ForeignDevice, ForeignAppEntity, ForeignSystemAgent -->
