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

[ERP connections](quotesync-tab-ERP-connections.md) – Here you can configure and add Quote Connectors and ERP connections.

[SuperOffice products](quotesync-tabs-SO-products.md) – Here you can work on the price lists and products stored in SuperOffice.

[Settings](settings-configure-product.md) – Here you can adjust the settings for quotes and configure the fields that are displayed for products.

[Sync](quotesync-tab-sync.md) – Here you can configure and add Sync Connectors and associated ERP connections.

## What are Quote/Sync Connectors and ERP connections?

* Each Quote Connector or Sync Connector is a DLL file/web service that manages communication between SuperOffice and an ERP system.
* Quote Connectors are used to calculate quote prices, and send order details to the ERP system when the customer accepts the quote.
* Sync Connectors are used to integrate SuperOffice and the ERP system, so that companies in SuperOffice can be linked to/synchronised with customers/suppliers in ERP system. The same applies to contacts and projects.
* An ERP connection consists of a Quote Connector or Sync Connector and configuration data (such as client data (if the ERP system is used by several companies) and authentication data for the ERP system).

<!-- Fix reuse ID=a1 --> ![icon](../CRMOnline.png)

To set up an ERP connection for the online version of SuperOffice:

1. Go to [https://online.superoffice.com/appstore][1].
2. Locate the correct "sync" app for your ERP system. [Click here to search][2].
3. Locate the correct "quote" app for your ERP system. [Click here to search][3].
4. To complete the setup, contact the app provider.

<!-- Referenced links -->
[1]: https://online.superoffice.com/appstore
[2]: https://online.superoffice.com/appstore/app/search?phrase=sync
[3]: https://online.superoffice.com/appstore/app/search?phrase=quote

<!-- Referenced images -->
