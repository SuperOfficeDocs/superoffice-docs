---
# Mandatory fields.
title: erp_setup_connection       # (Required) Very important for SEO.
description: Setting up ERP Sync connection # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Setting up ERP Sync connection

When creating a new Sync Connection, SuperOffice calls the ERP Sync connector and requests an array of `FieldMetaDataInfo` objects. [FieldMetaDataInfo][1] details what data the connector will need to identify which ERP instance/client to connect to. For example, database server, database name, username, and password.

![03][img1]

In the GUI, the user can enter these connection fields (or selected, if the field type is a list).

Before this is sent back to the connector, SuperOffice generates a new **GUID** (globally unique identifier) which the connector will use to identify this particular connection in the future. This GUID will accompany every connection-specific call made to the connector.

SuperOffice sends the completed connection details to the connector and asks that it be saved in some form of persistent storage along with the Connection ID GUID. This way, ERP Sync will not have to resend the complete connection info with every call in the future. To save the configuration data, you can take advantage of the [helper methods][2].

Once the connector reports back that the connection details have been saved, SuperOffice calls the **TestConnection** method to verify that the connection info is working as intended. The connector will then need to perform some kind of operation on the ERP system to verify this and report back.

SuperOffice will also store a copy of the connection details, in case the connector requests it to be resent in the future.

## GetConfigData

When the user has selected the sync connector (the URL) to use, SuperOffice will call the connector's `GetConfigData` via SOAP to find out what configuration fields to use.

```csharp
FieldMetadataInfoArrayPluginResponse response = GetConfigData();
```

The `FieldMetaDataInfo` objects might look something like this:

```csharp
[0] = { Access = Normal, Rank = 1,
        FieldKey = "VID", FieldType = Text,
        DisplayName = "Visma Client ID",
        DisplayDescription = "This is the tooltip",
        DefaultValue = "<name>" }
[1] = { Access = Mandatory, Rank = 2,
        FieldKey = "U", FieldType = Text,
        DisplayName = "User",
        DefaultValue = "" }
[2] = { Access = Normal, Rank = 3,
        FieldKey = "P", FieldType = Password,
        DisplayName = "Password",
        DisplayDescription = "ERP password" }
```

The configuration fields describe the defaults. Any [default values][1] that contain template tags will be replaced with company name/current user values. You can use this to get the serial number `<ser#>` for example.

The user then fills in the config fields in the dialog and clicks the **Test** button to verify that the settings are correct.

## TestConfigData

SuperOffice calls the `TestConfigData` method with the values from the dialog, and using the `FieldKeys` as keys to the dictionary.

```csharp
var connectionInfo = new Dictionary<string, string>(){
  {"VID","NO SME"},
  {"U","nosmexxx"},
  {"P","glops123"}
};
PluginResponseInfo responseInfo = TestConfigData(connectionInfo);
```

If `TestConfigData()` returns `IsOk = false`, then the `UserExplanation` message is displayed as an error message, and the **Save** button in the configuration dialog is not enabled. See all [members of PluginResponseInfo][4].

## SaveConnection

The user clicks the **Save** button in the config dialog. SuperOffice generates a GUID for the connection and calls the `SaveConnection` method.

```csharp
responseInfo = SaveConnection(3aef3af6-8642-4fc1-8dc9-4e08bd76a6bf, connectionInfo);
```

The connector needs to save the connection parameters mapped to the `connectionId`, so that later invocations (which are only passed the `connectionId`) can retrieve the parameters needed to communicate with the ERP system.

## GetSupportedActorTypes

SuperOffice then calls `GetSupportedActorTypes` (with the connectionId) to find out what things the connector supports syncing. This response is cached in the SuperOffice database until the next time the connection is configured and saved.

```csharp
StringArrayPluginResponse response = GetSupportedActorTypes({3aef3af6-8642-4fc1-8dc9-4e08bd76a6bf});
```

The supported types can for example be:

```csharp
[0] = "Customer"
[1] = "Supplier"
[2] = "Project"
```

The actor type names are defined by the [ErpActorType][5] enum. The "Customer", "Supplier" and "Partner" all correspond to SuperOffice companies. The different actor types can have different field mappings.

> [!NOTE]
> The actor type names are not translated - they are constants.

## Lists

If one of the fields is a list field, the name of the list is passed to the connector when the drop-down list is opened. The `GetList` method should return a mapping of list-item ID to list-item text.

```csharp
ListItemArrayPluginResponse response = GetList({3aef3af6-8642-4fc1-8dc9-4e08bd76a6bf}, "the List");
```

The mapping might look something like this:

```csharp
["a"] = "item A"
["x"] = "item X"
["9"] = "number nine"
```

> [!NOTE]
> The connection ID is 0000-000-000 when you are setting up the connection for the first time. The connection hasn't been saved yet, so no connection GUID has been created yet.

## Sequence diagram

The process of defining and saving a new sync connection.

![04][img2]

<!-- Referenced links -->
[1]: api/field-meta-data-carrier.md
[2]: helpers.md
[3]: default-values.md
[4]: api/pluginresponseinfo.md
[5]: api/erp-actor-carrier.md

<!-- Referenced images -->
[img1]: media/image003.png
[img2]: media/image004.png