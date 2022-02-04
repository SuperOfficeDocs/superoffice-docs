---
title: Architecture
uid: erp_architecture
description: ERP connector architecture
author: {github-id}
so.date: 05.11.2016
keywords:
so.topic: concept
# so.envir:
# so.client:
---

# Architecture

Outside of developer installations, there is no connector code hosted on the SuperOffice side.

The connector URL will be stored in the SuperOffice database, and there will also be a copy of the connection details for each Sync Connection stored there, in case the connector needs to have it resent (see “Setting up a sync connection”). Other than that, SuperOffice will know nothing about the infrastructure on the ERP side, and all method calls will be through a web service interface ( `IErpConnector`).

The connector interface declares methods to handle:

* Configuring the connection to the ERP system.
* Getting information about changes in the ERP system.
* Sending information about changes in the SuperOffice system to the ERP system.
* Creating, removing, and updating links between ERP entities (Actors) and SuperOffice entities (like companies or projects)

<!-- Referenced images -->
