---
title: foreign_keys       
description: Foreign keys
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords:
so.topic: concept
---

# Foreign keys

Foreign keys are designed to make it easy for 3rd parties to store extra keys needed by their application in the SuperOffice database. The `ForeignKey` property exists on the following objects:

* Contact
* Person
* Associate
* Project
* Document
* Appointment
* Sale

`ForeignApp` can represent a sync application. It is the starting point for the foreign key identity because you cannot get a `ForeignDevice` row without a ForeignApp. Links the foreign key and the external application. Each application should have a unique ForeignApp.

`ForeignDevice` represents an external device: a PDA, an external database, or some other device. An application may have more than one device. For ERP systems there would be only one device record. For PDAs, there would be one record per PDA. These data are stored in the `foreigndevice` table.

Foreign keys are stored in the `foreignkey` table. It holds a reference to the `foreigndevice` table.

## ForeignKeyHelper

`ForeignKeyHelper` is designed to make it easier to manage foreign keys. The foreign key system can be broken down into 3 levels: application, device, and key.

## Example

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

    // create a key under the device
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
