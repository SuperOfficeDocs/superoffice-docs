---
title: ERP Sync Service WCF host
uid: erp_arch_wfc
description: ERP Sync Service WCF host
author: {github-id}
so.date: 05.11.2016
keywords: soap,web.config
so.topic: howto
# so.envir:
# so.client:
---

# ERP Sync Service WCF host

![x][img1]

To make life a little simpler for sync connector implementers, SuperOffice provides a WCF host called **Erp Sync Service** that takes plugins in the form of the .Net `IErpConnector` interface. The WCF host handles the translation between the WCF types used in `IERpConnectorWS` and the .net `IErpConnector` interface. The WCF host needs the *SuperOffice.Plugins.DLL* file since that defines the `IErpConnector` interface.

The `ErpConnectorWS.svc` must be configured to load your `IErpConnector` implementation via the web.config file for the service. The path to your plugin DLL is specified in the `applicationSettings` section. The ErpConnectorWS service will load all the assemblies specified here, and then check the loaded classes, and add the ones marked with a `[Plugin]` derived-attribute, and which inherit from the `IPlugin` interface (which the `IErpConnector` interface does).

## Setting up the WCF host

To set up the WCF host, you need to place the SVC file and the associated *BIN* folder somewhere, and point IIS at the folder.

> [!TIP]
> The WCF files are installed into your documents folder, under the *My Documents\\Expander SDK Samples\\ErpSync\\ErpSyncService*.

You should copy the *ErpSyncService* folder to a location where the IIS NetworkService user can read it. (Your personal folders are not web accessible).

Use Visual Studio to build the project. You may need to fix the reference to *SuperOffice.Plugins.DLL*.

Once the building is successful, you can use Visual Studio to deploy to IIS, or you can make an application using IIS Control Panel.

![x -screenshot][img2]

Remember to make Application pool .Net 4.0 or newer, since `SuperOffice.Plugins` is a .Net 4.0 DLL.

![x -screenshot][img3]

Once the IIS is set up, you should be able to browse to the website and see the web service page.

## Configuring the WCF host

The WCF host by itself cannot do any ERP syncing. It needs to be filled with plugins that implement the `IErpConnector` interface. We add these plugins using the WCF host's *web.config* file:

```XML
<applicationSettings>
  <ErpSyncService.Properties.Settings>
    <setting name="ConnectorAssemblies" serializeAs="Xml">
      <value>
        <ArrayOfString xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
          xmlns:xsd="http://www.w3.org/2001/XMLSchema">
          <string>
            c:\Samples\ErpSync\SuperOffice.EIS.DummyConnector\bin\Debug\SuperOffice.EIS.DummyConnector.dll
          </string>
        </ArrayOfString>
      </value>
    </setting>
  </ErpSyncService.Properties.Settings>
</applicationSettings>
```

The WCF Host will need to store its configuration data somewhere. This writeable folder is also specified in *web.config*:

```XML
<appSettings>
  <add key="ConfigFolder" value="c:\Samples\erpSyncConfig"/>
</appSettings>
```

This setting tells the WCF host to store the configuration settings in the given folder. The default implementation for configuration settings uses Isolated storage, which can be tricky to use with services that don't have their own profile folders.

The WCF host provides its own implementation for saving configuration data using the `FileConfigDataStore` class. This class reads a directory path from the *web.config* file and stores connection settings in sub-folders.

## IErpConnector implementation

The .Net connector interface is a little easier to work with than the raw SOAP interface.

```csharp
public CRM.PluginResponseInfo SaveConnection(Guid connectionID, Dictionary<string, string> connectionInfo)
{
  ConfigDataHelper.SaveData<DummyArguments>(connectionID,connectionInfo);
  var resp = ResponseHelper.CreateOkResponse<CRM.PluginResponseInfo>();
  return resp;
}
```

The WCF host has unpacked the parameters for us and handles conversion between the .Net types and the WS-types used in the SOAP API. Any exceptions in the `IErpConnector` plugin are caught and converted into SOAP responses.

The `ConfigDataHelper` uses the `FileConfigDataStore` to store the settings for us.

The major benefit of writing Sync services using the `IErpConnector` interface is that you can load them directly into SuperOffice Web for debugging. For more info, see the [debugging tips][1].

## Multi-hosting

![x][img4]

The WCF host can host more than one implementation of the `IErpConnector` interface.

The client can specify the implementation it wants by name in the URL, using a query string parameter.

`http://server/erpSync/ErpConnectorWS.svc?ConnectorName=Name-of-connector`

The name of the connector is not the name of the class, but the name specified in the `[ErpConnector("name-of-connector")]` plugin attribute on the class.

### Configuring the WCF host for multi-hosting

Like before, we add the plugins using the WCF host's *web.config* file:

```XML
<applicationSettings>
  <ErpSyncService.Properties.Settings>
    <setting name="ConnectorAssemblies" serializeAs="Xml">
      <value>
        <ArrayOfString xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
          xmlns:xsd="http://www.w3.org/2001/XMLSchema">
          <string>
            c:\Samples\ErpSync\SuperOffice.EIS.DummyConnector.dll
          </string>
          <string>
            c:\Samples\ExcelSync\SuperOffice.EIS.ExcelConnector.dll
          </string>
          <string>
            c:\Samples\Visma\SuperOffice.EIS.VismaConnector.dll
          </string>
        </ArrayOfString>
      </value>
    </setting>
  </ErpSyncService.Properties.Settings>
</applicationSettings>
```

This configures the WCF host to load three different DLLs, each with a different implementation of `IErpConnector` interface.

The client can specify the name of the connector (not the name of the DLL) in the URL, like this:

* `http://server/erpSync/ErpConnectorWS.svc`
  Will use the default - the first connector in the list.

* `http://server/erpSync/ErpConnectorWS.svc?ConnectorName=Test.Excel`
  Will use the connector named "Test.Excel" -- this is the name declared using the `[ErpConnector("Test.Excel")]` attribute on the class implementing the `IErpConnector` interface in the SuperOffice.EIS.ExcelConnector.dll.

* `http://server/erpSync/ErpConnectorWS.svc?ConnectorName=SAP`
  Will look for a connector named "SAP", and failing to find one, will return an error: the connector 'SAP' was not found.

<!-- Referenced links -->
[1]: ../getting-started.md

<!-- Referenced images -->
[img1]: media/slide1.png
[img2]: media/iis-add-application.png
[img3]: media/erp-sync-svc.png
[img4]: media/slide3.png
