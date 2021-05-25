---
title: SOAP Sync Service
uid: erp_arch_soap
description: ERP connector SOAP Sync Service
author: {github-id}
so.date: 05.11.2016
keywords: soap
so.topic: concept
# so.envir:
# so.client:
---

# SOAP Sync Service

![x][img1]

Implementing the SOAP service API directly removes any .Net dependencies. You can implement the `IErpConnectorWS` SOAP Service API directly from Java or PHP.

The SOAP API is very similar to the .Net API, just a bit more house-keeping to take care of.

For example: when working with the SOAP API, each connection is represented by a different GUID. You will need to find the configuration data associated with the GUID yourself.

Here is a snippet from the SDK sample **ExcelErpSyncConnector** where the `Filename` parameter is saved and mapped to the GUID for the connection.

```csharp
public ConnectorResultBaseWS WSSaveConnection(SaveConnectionRequestWS request)
{
  var result = new ConnectorResultBaseWS();
  result.IsOk = request.ConnectionInfo.ContainsKey("Filename");
  result.State = result.IsOk ? ResponseStateWS.Ok : ResponseStateWS.Error;
  result.UserExplanation = result.IsOk ? "" : "Filename is missing.";
  if (result.IsOk)
  {
    string connectionGuid = request.ConnectionGuid;
    string filename = request.ConnectionInfo["Filename"];
    Connection.AddConnection(connectionGuid, filename);
  }
  return result;
}
```

The SuperOffice client will call the `WSSaveConnection` SOAP web-service end-point directly. WCF will dispatch the call to this method.

The `request` parameter contains the `ConnectionGuid` property, which identifies this connection. The method must save the configuration values for the connection (passed via the `ConnectionInfo` dictionary) somewhere it can find it again later. Subsequent calls to the web service will not pass in the `ConnectionInfo` dictionary, just the `ConnectionGuid`.

<!-- Referenced images -->
[img1]: media/slide2.png
