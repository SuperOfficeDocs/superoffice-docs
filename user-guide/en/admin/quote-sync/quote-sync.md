---
uid: help-en-quote-sync
title: quote sync
description: quote sync
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Quote/Sync

In the **Quote/Sync** screen you can administrate connections and settings for ERP systems that are linked to SuperOffice CRM. Here you can also work on the price lists and products in the SuperOffice database.

* [ERP connections][1] – Here you can configure and add Quote Connectors and ERP connections.
* [SuperOffice products][2] – Here you can work on the price lists and products stored in SuperOffice.
* [Settings][3] – Here you can adjust the settings for quotes and configure the fields that are displayed for products.
* [Sync][4] – Here you can configure and add Sync Connectors and associated ERP connections.

## What are Quote/Sync Connectors and ERP connections?

* Each Quote Connector or Sync Connector is a DLL file/web service that manages communication between SuperOffice and an ERP system.
* Quote Connectors are used to calculate quote prices, and send order details to the ERP system when the customer accepts the quote.
* Sync Connectors are used to integrate SuperOffice and the ERP system, so that companies in SuperOffice can be linked to/synchronised with customers/suppliers in ERP system. The same applies to contacts and projects.
* An ERP connection consists of a Quote Connector or Sync Connector and configuration data (such as client data (if the ERP system is used by several companies) and authentication data for the ERP system).

[!include[How to set up ERP](../includes/set-up-erp-web.md)]

<!-- Referenced links -->
[1]: quotesync-tab-ERP-connections.md
[2]: quotesync-tabs-SO-products.md
[3]: settings-configure-product.md
[4]: quotesync-tab-sync.md

<!-- Referenced images -->
