---
# Mandatory fields.
title: erp_architecture       # (Required) Very important for SEO.
description: ERP connector architecture # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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
[img1]: media/image001.jpg
