---
title: IErpConnector
uid: erp_api_ierpconnector
description: Sync Connector API - IErpConnector
author: {github-id}
so.date: 05.11.2016
keywords:
so.topic: reference
# so.envir:
# so.client:
---

# IErpConnector

A sync connector (plugin to the connector web-service host) will need to implement the`IErpConnector` interface. This interface contains methods needed to both set up and save a sync connection and to retrieve and save ERP actors. The`IErpConnector` interface, along with all related classes and interfaces are contained in *SuperOffice.Plugins.DLL*.

If you do not want to use the web-service host, you will need to implement the SOAP web service interface directly. The`IERpConnectorWS` interface is identical in functionality but uses SOAP definitions rather than .Net definitions.

## Interface members

| Member | Description |
|---|---|
| `FieldMetadataInfoArrayPluginResponse  GetConfigData()` | Asks the connector what fields are needed to set up a new connection (database, username and password) |
| `PluginResponseInfo   TestConfigData   ( Dictionary < string ,  string > connectionInfo)` | Asks the connector to verify that a given set of connection configuration data is valid, without saving it as a new connection. |
| `PluginResponseInfo   SaveConnection   (Guid connectionID,  Dictionary  < string ,  string > connectionInfo)` | Creates a new connection, or updates an existing one |
| `PluginResponseInfo   TestConnection   (Guid connectionID)` | Checks if the given connection ID is valid (is the connection up, is the configuration data correct, etc.) |
| `PluginResponseInfo   DeleteConnection  (Guid connectionID)` | Tells the Connector that a connection has been deleted from Erp Sync, in case the Connector needs to know and take some action |
| `StringArrayPluginResponse   GetSupportedActorTypes``(Guid connectionID)` | Gets the supported actor types for a given connection |
| `FieldMetadataInfoArrayPluginResponse   GetSupportedActorTypeFields``(Guid connectionID,  string  actorType)` | Gets a list of fields that are available for a given connection and a given actor type |
| `ActorArrayPluginResponse   GetActors   (Guid connectionID,  string  actorType,  string [] erpKeys,  string [] fieldKeys)` | Retrieves actors based on primary key and actor type |
| `ActorArrayPluginResponse   SearchActors``(Guid connectionID,  string  actorType,  string  searchText,  string [] fieldKeys)` | Searches for one or more actors given a simple search string |
| `ActorArrayPluginResponse   SearchActorByParent``(Guid connectionID,  string  actorType, string  searchText,  string  parentActorType,  string  parentActorErpKey,  string [] fieldKeys)` | Searches for one or more actors given a simple search string, and only searches for actors with a specified parent actor |
| `ActorPluginResponse   CreateActor``(Guid connectionID,  ErpActor  actorFromSuperOffice)` | Creates a new actor in the ERP system, based on information from SuperOffice entity |
| `ActorArrayPluginResponse   SaveActors``(Guid connectionID,  ErpActor [] actors)` | Saves (updates) existing actors in ERP with information from SuperOffice |
| `ListItemArrayPluginResponse   GetList   (Guid connectionID,  string  listName)` | Retrieves a list from the connector, using the name specified by the connector itself |
| `ListItemArrayPluginResponse   GetListItems   (Guid connectionID,  string  listName,  string [] listItemKeys)` | Retrieves one or more specific list items from the connector, using the list name specified by the connector. |
| `ActorArrayPluginResponse   GetActorsByTimestamp``(Guid connectionID,  string  lastModified ,  string  actorType,  string [] fieldKeys )` | Retrieves all actors of a specified actor type updated on or after a given date and time * |
| `StringArrayPluginResponse   GetSearchableFields (Guid connectionId,  string  actorType)` | Obtain a list of fields (a subset of previously  declared fields from `GetSupportedActorTypeFields`, that should be shown as criteria in the "Advanced Search" |
| `ActorArrayPluginResponse   SearchActorsAdvanced (Guid connectionID,  string  actorType,  SearchRestrictionInfo [] restrictions,  string [] returnFields)` | Performs a criteria-driven search (Advanced Search) and returns an array of rows |

For details about timestamps, see [ErpActor][1].

In addition to implementing the methods of `IErpConnector`, a sync connector will need to have a unique name attribute, for example:

```csharp
[ErpConnector("MyCompany.SuperErpConnector")]
public class MyErpSystemConnector : IErpConnector
{
  // Connector code
  // implement all the interface
}
```

This connector would be compiled into a DLL, and then exposed to the web using [the WCF ERP sync service host][2].

<!-- Referenced links -->
[1]: erp-actor-carrier.md
[2]: ../architecture/wcf-host.md
