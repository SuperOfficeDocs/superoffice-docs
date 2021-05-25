---
title: foreignkey
description: ForeignKeys – to fluent or not to fluent, that is the question
author: Tony Yates
so-date: 26 Dec 2009
keywords:
so.topic:
so.envir: cloud
so.client: online
---

# ForeignKeys – to fluent or not to fluent, that is the question

So there I was, one week to Christmas, and thinking not about what shopping I needed to get done before Christmas, but how to make it easier to work with Foreign Keys.

![image_thumb.png][img1]

In SDK training, I refer to Foreign Keys as a means of connecting SuperOffice entities with those defines in external systems. These can be mapped to any pre-existing SuperOffice entities, such as appointments, contacts, and documents, as well as user-defined entities.

![image_thumb_1.png][img2]

Conceptually the external system is referred to as an Application. Where applications generally have multiple functions or departments, the Foreign Key system exposes a device id and device name.

Choose your favorite ERP system and use that name as the application name, then, divide the sub-components into textual device identifiers, which can then have multiple device names. This gives you a three-dimensional means of differentiating conceptual components between architectures.

![image_thumb_2.png][img3]

Now add in the key/value mapping dictionary, the ForeignKey table, and you have a myriad of possibilities.

![image_thumb_3.png][img4]

## Enter the Code-ness

In NetServer you have but two options for working _easily_ with ForeignKeys: work at the Entity or Rows layer. Working at the Entities layer is great when working with pre-existing SuperOffice entities and performance is not a concern.

Alternatively, working at the Rows layer feels disconnected and cumbersome – assemble a trilogy of ForeignAppRow, ForeignDeviceRows, and ForeignKeyRows types and somehow find a happy means of managing them. There is some help using the SuperOffice.CRM.Rows.Util.RowForeignKeyHelper, but that only gets you so far.

## Choosing an API – Two Choices (so far)

So, it comes down to trying to figure out a better or more intuitive way of managing the foreign key system concept.

### Option One

I’ve been juggling the idea of creating a set of helper classes that all work in conjunction with each other - each complimenting the next. Considering the multidimensional aspects of the **system**, why not implement it that way? For example, how about accessing a specific foreignkey value by indexing into it, such as:

```csharp
["appName"]["deviceId"]["key"].Value
```

or

```csharp
["appName"]["deviceId", "deviceName"]["key"].Value
```

The indexing works via three classes, intuitively called ForeignApp, ForeignDevice, and ForeignKey. You can start with creating a new instance of a ForeignApp, and then drilling all the way down to a foreign key by indexes.

```csharp
ForeignApp fh = new ForeignApp();
string a = fh["appName"]["deviceId"]["key"].Value;
string b = fh["appName"]["deviceId", "deviceName"]["key"].Value;
string c = fh["appName"]["deviceId", "deviceName"]["key"].Value;
```

The ForeignApp class just acts as an adapter around the ForeignAppRow type, exposing it as a property, but also returning a ForeignDevice via its indexer. The ForeignDevice then has a direct reference to the ForeignApp and is therefore **connected**. Obtaining a ForeignDevice this way will always have access to the ForeignAppRow when necessary.

```csharp
public class ForeignApp
{
    public ForeignAppRow AppRow { get; }

    public ForeignDevice this[string appName]
    {
        get  this.AppRow = /* logic to get the correct ForeignAppRow */
        return new ForeignDevice(this);}
    }
}
```

Conversely, accessing en indexer of a ForeignDevice will return an instance of a ForeignKey which too exposes a property of its *parent* and therefore has access to both the ForeignDevice and ForeignApp that pertain to the ForeignKey.

```csharp
public class ForeignDevice
{
    public ForeignApp ForeignApp { get; }
    public ForeignDeviceRow DeviceRow { get ; }

    public ForeignKey this[string deviceId]
    {
        get
        {
            DeviceRow = /* logic to get the correct DeviceRow */
            return new ForeignKey(this);
        }
    }

    public ForeignKey this[string deviceId, string deviceName]
    {
        get
        {
            DeviceRow = /* logic to get the correct DeviceRow */
            return new ForeignKey(this);
        }
    }

    public ForeignDevice(ForeignApp appRow)
    {
        ForeignApp = appRow;
    }
}
```

And finally the ForeignKey class. The ForeignKey class gets interesting because it’s never really known just how many ForeignKeyRow’s are retrieved when accessing a specific key. This is because foreign key values can be very long, but the actual sub-value field of a ForeignKeyRow type is limited to 239 characters – but you can leverage the `seqno` field to span a complete value across multiple ForeignKeyRows.  Additionally, the `tableId` and `recordId` fields must be considered to ensure, when associating a key with a particular entity, that only the correct ForeignKeyRow’s are returned. Alternatively, if none are found, to create and prepare them for use.

```csharp
public class ForeignKey
{
    public ForeignDevice ForeignDevice { get; }

    public ForeignKeyRows KeyRows { get ; }

    public string Value { get; set;}

    public ForeignKey(ForeignDevice foreignDevice)
    {
        ForeignDevice = foreignDevice;
    }
}
```

### Option Two

The growing popularity of [Fluent interfaces][1] today has lead me to consider this type of API for accessing foreign keys.

My original fluent interface design looks something like this:

```csharp
public interface IForeignKeysFluent
{
    ForeignApp ForeignApp { get; }
    ForeignDevice ForeignDevice { get; }
    ForeignKey ForeignKey { get; }

    IForeignKeysFluent GetForeignApp(string name);
    IForeignKeysFluent GetForeignDevice(string deviceId);
    IForeignKeysFluent GetForeignDevice(string deviceId, string name);
    IForeignKeysFluent GetForeignKey(string key);
    IForeignKeysFluent GetForeignKey(string key, int table);
    IForeignKeysFluent GetForeignKey(string key, int table, int record);
}
```

Without discussing the actual implementation, it’s safe to say that working with the API goes a little something like this:

```csharp
public interface IForeignKeysFluent
{
    ForeignApp ForeignApp { get; }
    ForeignDevice ForeignDevice { get; }
    ForeignKey ForeignKey { get; }

    IForeignKeysFluent GetForeignApp(string name);
    IForeignKeysFluent GetForeignDevice(string deviceId);
    IForeignKeysFluent GetForeignDevice(string deviceId, string name);
    IForeignKeysFluent GetForeignKey(string key);
    IForeignKeysFluent GetForeignKey(string key, int table);
    IForeignKeysFluent GetForeignKey(string key, int table, int record);
}
```

So I guess what I really want to do is ask the question "What looks/feels best to you?" – the fluent interface above, or indexing into it?

```csharp
FluentForeignKeys ffk = new FluentForeignKeys();

ffk.GetForeignApp("appName")
    .GetForeignDevice("deviceId", "deviceName")
    .GetForeignKey("key").ForeignKey.Value = "";

ffk.GetForeignApp("appName")
    .GetForeignDevice("deviceId", "deviceName")
    .GetForeignKey("key", tableId, recordId).ForeignKey.Value = "";
```

Do you have any different ideas? I’m interested in hearing them.

<!-- Referenced links -->
[1]: http://en.wikipedia.org/wiki/Fluent_interface

<!-- Referenced images -->
[img1]: media/foreignkey-1095.jpg
[img2]: media/foreignkey-1096.jpg
[img3]: media/foreignkey-1097.jpg
[img4]: media/foreignkey-1098.jpg
