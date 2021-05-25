---
title: IntellisyncConnector element
uid: ns_config_intellisyncconnector
description: NetServer IntellisyncConnector element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---

# IntellisyncConnector element (Legacy - SuperOffice only)

Not used in version 7 or higher.

Configuration settings used by SoIntellisyncConnector.

| Name | Description |
|---|---|
| SessionTimeout | Intellisync Server authenticates against Intellisync Connector. When an Intellisync Server sync session for a particular user is ended, the authentication session is always removed. When a synchronization session exceeds this time-out, an error is returned to Intellisync Server. Intellisync Server will then try to re-synchronize later. Extensive traffic in the database resulting in a slowed up synchronization will typically trigger this. Synchronization for a normal user will seldom take more than 5 minutes (300 seconds), hence the default value of 10 minutes (600 seconds) is conservative. Situations in which a lot of database locks are occurring should probably result in this default value being decreased, rather than increased. Extremely slow hardware as a result of virtualization should probably result in an increased value. |
| IntellisyncConnectorUri | The endpoint hosted by SoConnectorService used by Intellisync Server for communication.<br>Default: `http://*:8000/` |
| EnableDiagnosticsWeb | True to make SoIntellisyncConnector host an internal web server enabling the possibility to analyze the current activity of SoIntellisyncConnector. The URI listened on is described by `DiagnosticsWebUri`. |
| DiagnosticsWebUri | The end-point used by the `SoIntellisyncConnector` internal diagnostics web server.<br>Default: `http://*:8001/` |
