---
# Mandatory fields.
title: erp_terminology       # (Required) Very important for SEO.
description: ERP connector terminology # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Terminology

| Term | Description |
|---|---|
| Erp Sync | The synchronization application and a generic prefix for all of its components |
| Sync Connector (or just Connector) | An installed and running instance of a piece of code implementing and exposing the `IErpConnector` interface. |
| Sync Connection (or just Connection) | A given combination of a Sync Connector and a set of parameters (as defined by the connector) that specifies which ERP instance/client the Connector will retrieve and save data to. Will typically represent an ERP Client/ERP Company |
| ERP Actor | Any actor that can be synced to SuperOffice from a Sync Connection<br>For example, Customers, suppliers, persons |
| CRM Entity | The SuperOffice equivalent of an ERP Actor (any entity that can be synced to a Sync Connection, such as contact, person, or project) |

## Connect*or* vs. connect*ion*

![components][img1]

An ERP **connector** is a piece of code that implements one or more of the required interfaces.

* It will generally be the "glue" between SuperOffice and one kind of ERP system (Baan, Dynamics, ...)
* It is a DLL/web service

A **connection** is a connector + config information

* It points to a particular ERP connector
* Client (if there are multiple client companies in the ERP system)
* Authentication
* Other config info that might be needed to connect

<!-- Referenced images -->
[img1]: media/components.png
