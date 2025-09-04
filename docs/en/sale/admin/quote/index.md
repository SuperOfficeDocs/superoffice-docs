---
uid: help-en-quote-admin
title: Manage quote and order setup
description: Learn how quotes, quote connectors, and ERP integration work in SuperOffice CRM and how to configure them in the Quote/Sync screen.
keywords: quote connector, ERP connection, quote settings, price list, product, Quote/Sync screen, erp setup, quote connector settings, quoting integration, sales configuration, quote, sync
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: concept
license: salespremium
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from:
  - /en/quote/learn/admin/index
  - /en/quote/learn/admin/quotesync-tab-erp-connections
  - /en/quote/learn/admin/quotesync-tab-settings
---

# Manage quote and order setup

The **Quote/Sync** screen in Settings and maintenance is where you configure everything needed to enable quoting and ordering in SuperOffice CRM.

> [!NOTE]
> This feature requires the **Sales Premium** user plan.

## Products and price lists

Every quote in SuperOffice includes one or more products, and each product must belong to a **price list**.

There are two ways to manage products and prices in SuperOffice CRM:

* **Manually**, using the built-in SuperOffice product register, also known as the **SuperOffice Standalone connector**

* **Automatically**, by retrieving product data from an external **ERP system**

## Quote connectors and ERP connections

To retrieve product data and calculate prices, SuperOffice uses **quote connectors** and **ERP connections**.

A **quote connector** is a plug-in (web service or DLL) that handles the integration. It communicates with a specific ERP or product system and performs tasks such as:

* Fetching product and price data
* Validating discounts
* Calculating totals and VAT
* Submitting accepted quotes as orders

A **quote connector by itself is not functional** until configured. To activate it, you must create an **ERP connection**, which combines the connector with:

* Access control (who can use it)
* Authentication or endpoint settings
* Behavior rules like rounding, warnings, and approval logic

Think of it this way: **ERP connection = quote connector + configuration**

You can configure multiple ERP connections for the same connector. For example, if your organization uses different settings per market or user group.

> [!TIP]
> All ERP connections are managed in the **ERP connections** tab of the **Quote/Sync** screen.

### SuperOffice Standalone connector

This is the default setup when no ERP system is connected. It is ideal for simpler quoting needs or when product data is not managed elsewhere. All product data is stored and managed directly in SuperOffice:

* [Define price lists and add products manually][2]
* Use the built-in calculation engine
* Does not support automatic order submission

> [!NOTE]
> An ERP connection is still required, but it is local to SuperOffice and does not connect to an external system.

### ERP-based quoting

When SuperOffice is integrated with an ERP system, the quote connector retrieves product and pricing data directly from the ERP.

* Products are fetched in real time (not stored in SuperOffice)
* Prices and discounts follow ERP rules
* Accepted quotes can generate ERP orders automatically

## <a id="tabs"></a>Tabs in the Quote/Sync screen

The Quote/Sync screen includes four tabs used to configure quoting, products, and ERP integration.

### ERP connections

Used to manage ERP connections for quote connectors.

* Displays all available Quote Connectors (automatically loaded after installation). Hold the mouse pointer over a row to display detailed information.
* Shows active ERP connections.
* Double-click a connection to edit settings such as scope, behavior, and validation rules.
* Select an ERP connection in the list, and click **Test ERP connection** to verify that the connection is active.

> [!TIP]
> See [Set up ERP connection][1] for step-by-step instructions.

### SuperOffice products

Used to manage the [price lists and products][2] stored in SuperOffice (if using the standalone connector). They are saved in the SuperOffice database, NOT in any ERP system connected to SuperOffice.

You can:

* Add, edit, and delete price lists.
* Add or remove products from each list. Double-click a product to edit it.
* Configure product details such as cost, VAT, and earnings.
* Select a thumbnail image to display in the quote dialog.

### Settings

Used to configure global quote options and the [product dialog layout][3].

* **Use discount on total value:** Enables an optional field for applying a discount to the total quote amount (percent or amount). Two discount fields are then shown at the bottom of the **Products** tab in the **Edit quote** dialog.

    > [!NOTE]
    > The total discount is applied in addition to any discounts applied to the different products.

* **Default text for follow-up:** Sets the default reminder text for follow-ups created when sending quotes.

* **Open sale types:** Opens the **Sale - Type, Stages, Quote** list where quote-specific rules are defined. Every sale in SuperOffice CRM must have a [sale type][5], and many of the default properties of a quote are obtained from the sale type of the associated sale. This applies to, for instance, the use of alternatives, the quote template, validity of the quote and requirement for approval.

Under **Product fields**, you can control which fields are shown when users add or edit a product.

### Sync

Used to [add Sync Connectors and configure ERP connections][4] for synchronization of companies, contacts, and projects. This tab is only relevant if you plan to sync CRM data with ERP actors.

## Related content

* [Set up ERP connection][1]
* [Add price lists and products][2]
* [Customize the quote dialog][3]
* [Manage ERP synchronization][4]

<!-- Referenced links -->
[1]: set-up-quote-connector.md
[2]: price-list-and-products.md
[3]: configure-product-fields.md
[4]: ../../../erp/admin/index.md
[5]: ../sale-type.md
