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

## The tables

![x][img1]

The foreign key table can point to any record. There can be several different foreign keys registered on the same record, with different keys on different applications and devices.

The values are stored in the `ForeignKey` table, along with a pointer to the relevant entity (Contact, Person, Project record) that the foreign key identifies.

The values are identified by the `ForeingDevice` and `ForeignApp` tables.

### ForeignApp

`ForeignApp` defines a sync application. An application is present on one or more devices.

It is the starting point for the foreign key identity because you cannot get a `ForeignDevice` row without a ForeignApp. Links the foreign key and the external application. Each application should have a unique ForeignApp.If you’re not dealing with devices, then just repeat the application name, or use a blank string.

### ForeignDevice

A `ForeignDevice` represents an external device (a PDA, an external database, or some other device) and consists of one or more keys. Each key for a given device has its own name.

The device record is intended to allow the same SuperOffice record to be mapped to different devices. For example, Company A might be stored as record 123 on my mobile phone, but as record 456 on your PocketPC.

An application may have more than one device. For ERP systems there would be only one device record. For PDAs, there would be one record per PDA. These data are stored in the `foreigndevice` table.

### ForeignKey

Each `ForeignKey` can consist of several different record pointers. In the example above, we named the sub-key "ERP-id" but we could have added a second key called "ERP-name" without affecting the first key.

If the key value is particularly long, then the sequence ID on the foreignkey can be used to chain several values together into one long identifier.

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

## See also

* [foreignapp table][1]
* [foreigndevice table][2]
* [foreignkey table][3]

<!-- Referenced links -->
[1]: ../../../../database/docs/tables/foreignapp.md
[2]: ../../../../database/docs/tables/foreigndevice.md
[3]: ../../../../database/docs/tables/foreignkey.md

<!-- Referenced images -->
[img1]: media/foreign-keys.gif
