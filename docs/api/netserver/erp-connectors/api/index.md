---
title: Sync Connector API
uid: erp_sync_connector_api
description: Sync Connector API
author: {github-id}
so.date: 05.11.2016
keywords:
so.topic: concept
# so.envir:
# so.client:
---

# Sync Connector API

* [IErpConnector][2]
* [Field meta-data carrier][3]
* [ERP actor data carrier][4]
* [PluginResponseInfo][5]

## ConnectorHost

SuperOffice offers an [IIS web service site][1] which is designed to simplify the process of developing and deploying a Sync Connector. The connector host will be able to host any number of named connectors and will be able to expose their methods through web service calls.

## Data carriers

Data carriers (or just *carriers*) are object types that transfer data between Erp Sync/SuperOffice and the Sync Connector.

> [!NOTE]
> These objects have no methods or behavior. They are pure data transfer objects (DTO).

* The **field meta-data carrier** describes configuration settings for the connection
* The **ERP Actor data carrier** describes company/person/project data

<!-- Referenced links -->
[1]: ../architecture/wcf-host.md
[2]: ierpconnector.md
[3]: field-meta-data-carrier.md
[4]: erp-actor-carrier.md
[5]: pluginresponseinfo.md
