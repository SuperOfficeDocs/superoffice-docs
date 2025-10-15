---
uid: help-en-erp-admin
title: Manage ERP synchronization
description: Introduction to configuring synchronization between SuperOffice CRM and external ERP systems.
keywords: ERP tab, ERP system, ERP actor, Sync connector, ERP connection, sync, connector, connection, Quote/Sync screen, ERP
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: concept
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from: /en/quote/learn/admin/sync/index
---

# Manage ERP synchronization

The **Sync** tab in the Quote/Sync screen in Settings and maintenance lists Sync Connectors and ERP connections that enable integration between SuperOffice CRM and external ERP systems.

[!include[Requirement](../../includes/req-dev-tools.md)]

## Terminology

| Term | Description |
|---|---|
| **Sync connector** | The *integration* component that connects SuperOffice CRM to an external ERP system. Each connector points to a specific ERP system. |
| **ERP connection** | A *configuration* that uses a sync connector to define what to sync, how to authenticate, and which ERP client to target. You can have multiple connections per connector. |
| **ERP actor** | A record in the ERP system that can be linked to a SuperOffice CRM entity. |
| **CRM entity** | A record in SuperOffice CRM—typically a company, contact, or project—that can be linked to an ERP actor. |

You can use the **Sync** tab to add, configure, and prioritize connections.

## What ERP sync enables

When ERP integration is configured correctly, users can access the **ERP** tab on the **Company**, **Contact**, and **Project** screens in SuperOffice CRM.

From this tab, users can:

* Link SuperOffice records to matching actors in the ERP system.
* View synchronized fields and values from ERP.

This helps reduce duplicate data entry and improves data consistency across systems.

> [!NOTE]
> The **ERP** tab only appears for users who have the correct license and access to an active ERP connection.

## Related content

* [Add a sync connector and define an ERP connection][1]
* [Edit an ERP connection][7]
* [Configure field mapping and default values][4]
* [Set sync priority][3]
* [Import from ERP][9]

<!-- Referenced links -->
[1]: add-connection.md
[3]: configure.md#priority
[4]: configure.md
[7]: update-connection.md
[9]: ../../admin/import/from-erp.md
