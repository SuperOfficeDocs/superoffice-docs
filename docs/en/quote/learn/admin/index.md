---
uid: help-en-quote-admin
title: Quote sync
description: SuperOffice Quote helps you to create, validate, and manage quotes and orders across the entire order lifecycle.
author: SuperOffice RnD
date: 12.13.2023
keywords: quote, sync, sale
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Quote/Sync

SuperOffice Quote helps you to create, validate, and manage quotes and orders across the entire order lifecycle. It helps you get new or updated quotes to your customers faster and speed up the transition from a lead to a closed deal.

> [!NOTE]
> This feature requires a Sales Premium user plan and the Developer Tools license.

Help your colleagues send their proposals quicker and avoid unnecessary errors by using an automated Quote system. Save time by converting your proposal to an order confirmation with just one click of a button.

![The Quote screen in Sales showing a quotation for John Smith -screenshot][img1]

It will be very easy for you and your colleagues to choose the products for a proposal from the price list. You can send different versions of your proposal to your customers and automatically register a follow-up activity. To set up a good quote document template is also essential so your customers also get information about products and prices added in your quote.

## The screen

In the **Quote/Sync** screen you can administrate connections and settings for ERP systems that are linked to SuperOffice CRM. Here you can also work on the price lists and products in the SuperOffice database.

* [ERP connections][1] – Here you can configure and add Quote Connectors and ERP connections.
* [SuperOffice products][2] – Here you can work on the price lists and products stored in SuperOffice.
* [Settings][3] – Here you can adjust the settings for quotes and configure the fields that are displayed for products.
* [Sync][4] – Here you can configure and add Sync Connectors and associated ERP connections.

## What are Quote/Sync Connectors and ERP connections?

* Each Quote Connector or Sync Connector is a DLL file/web service that manages communication between SuperOffice and an ERP system.
* Quote Connectors are used to calculate quote prices, and send order details to the ERP system when the customer accepts the quote.
* Sync Connectors are used to integrate SuperOffice and the ERP system, so that companies in SuperOffice can be linked to/synchronized with customers and suppliers in ERP system. The same applies to contacts and projects.
* An ERP connection consists of a Quote Connector or Sync Connector and configuration data (such as client data (if the ERP system is used by several companies) and authentication data for the ERP system).

## Related content

* [Customize price lists][5]
* [Configure product fields][6]
* [Add products to a price list][7]
* [Add a product image][8]

<!-- Referenced links -->
[1]: quotesync-tab-erp-connections.md
[2]: product/index.md
[3]: product/configure.md
[4]: ../../../erp/admin/index.md
[5]: product/add-price-list.md
[6]: product/configure.md
[7]: product/add-product-to-price-list.md
[8]: product/select-product-image.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/quote/quote-management.png
