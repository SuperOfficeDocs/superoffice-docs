---
title: ERP Sync Connector Interface
uid: erp_connectors
description: ERP Sync Connector Interface
author: {github-id}
so.date: 05.11.2016
keywords:
---

# ERP Sync Connector Interface

## Background and vision

SuperOffice’s ERP Integration server is designed to allow integration with any external ERP system through exposing a small set of methods and functionality through a web service - a Sync Connector.

A SuperOffice installation can be connected to any number of external ERP systems, either several instances accessed through a single connector or different systems through different connectors. Partners will be relied on to create and distribute all Sync Connectors, and SuperOffice will not host connectors on its Cloud infrastructure. On-premise customers may host connectors as they please.

## Quick facts

* A SuperOffice installation can connect to any number of Sync Connectors, and communicate with any number of Sync Connections through each connector. Many companies have several ERP clients/companies (the exact terminology may vary), and many larger companies may also have several different ERP systems (e.g. different systems in different countries).

* A Sync Connector should offer or require no user interface. SuperOffice will offer the required user interface for the administration and day-to-day use of Erp Sync.

* A Sync Connector will not have the capability to contact the SuperOffice installation (in fact, it will be given no knowledge about it at all). All method calls will come from SuperOffice and will simply ask the Sync Connector to perform a given task and return the results.

* SuperOffice will not create, distribute, install or host any Sync Connectors. This responsibility falls to partners.

* SuperOffice will provide a "reference host" – a standard IIS Website configured for a WCF Service with the correct Sync Connector interface, and a mechanism for loading connector implementations as plugins. This host site is meant to provide routinely-used methods and make development easier but is not in any way mandatory.
