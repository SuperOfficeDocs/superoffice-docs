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

[ERP connections](quotesync_tab_ERP_connections.md) – Here you can configure and add Quote Connectors and ERP connections.

[SuperOffice products](quotesync_tabs_SO_products.md) – Here you can work on the price lists and products stored in SuperOffice.

[Settings](settings_configure_product.md) – Here you can adjust the settings for quotes and configure the fields that are displayed for products.

[Sync](quotesync_tab_sync.md) – Here you can configure and add Sync Connectors and associated ERP connections.

## What are Quote/Sync Connectors and ERP connections?

* Each Quote Connector or Sync Connector is a DLL file/web service that manages communication between SuperOffice and an ERP system.
* Quote Connectors are used to calculate quote prices, and send order details to the ERP system when the customer accepts the quote.
* Sync Connectors are used to integrate SuperOffice and the ERP system, so that companies in SuperOffice can be linked to/synchronised with customers/suppliers in ERP system. The same applies to contacts and projects.
* An ERP connection consists of a Quote Connector or Sync Connector and configuration data (such as client data (if the ERP system is used by several companies) and authentication data for the ERP system).

<!-- Fix reuse ID=a1 --> ![icon](../CRMOnline.png)

To set up an ERP connection for the online version of SuperOffice:

1. Go to <a href="https://online.superoffice.com/appstore" target="_blank">https://online.superoffice.com/appstore</a>.
2. Locate the correct "sync" app for your ERP system. <a href="https://online.superoffice.com/appstore/app/search?phrase=sync" target="_blank">Click here to search</a>.
3. Locate the correct "quote" app for your ERP system. <a href="https://online.superoffice.com/appstore/app/search?phrase=quote" target="_blank">Click here to search</a>.
4. To complete the setup, contact the app provider.
