---
uid: quote-overview
title: Quotes
description: Introduction to quote management in SuperOffice
author: Bergfrid Dias
date: 06.12.2023
keywords: sale, quote, quoteconnection
topic: concept
---

# Quote management

[!include[License requirement](../../../common/includes/req-sales-prem.md)]

In sales, a quote allows a prospective buyer to see the **costs of selected products and/or services**. It can contain multiple **alternatives** for the customer to choose between.

Quotes are what connects products to a sale. You must record a sale **before** you can add a quote. Also, products must have been registered before you can add them to a quote.

> [!NOTE]
> Each quote belongs to a single sale. And there's only 1 quote per sale.

## Key info

* A unique ID
* The corresponding sale
* An ERP connection
* A version
* Alternatives
* Products
* A state

## Versions

There may be multiple versions of a quote, but only 1 of them is **active** at any time. Each version will have 1 or more alternatives, which in turn will have 1 or more quote lines.

When updating quotes, you'll always be working on the latest version.

## Alternatives and quote lines

Each alternative can contain different products, numbers of products, prices, and discounts. You should set the quantity and any discounts for the selected product.

A **discount** can be specified as:

* A percentage rate
* A discount amount
* A total amount

The estimated sales amount for the sale (forecast) is obtained from the total amount for the **favorite alternative**.

## Products and price lists

Each product belongs to a single price list. A price list can either be cached from an ERP system or set up in SuperOffice CRM.

### ERP

You might be working with a tenant that is integrated with an ERP system. In that case, the ERP connection determines where the product information and prices are obtained from.

### Quote connectors

SuperOffice has a simple product and price-list system built in, but using [quote connectors][7] you can access products and price lists in other systems from inside SuperOffice.

### VAT

The SuperOffice quote connector will calculate the VAT **amount** of an alternative based on the VAT **percent** of the individual lines.

> [!CAUTION]
> Other connectors may implement different VAT algorithms at will! Make sure you interpret the VAT field correctly.

## Quote documents

Quote documents will be saved as **activities on a sale**. They're tied to a specific **quote version**.

## State

| State | Description |
|:-:|:--|
| 0 | Unknown |
| 1 | OK: draft calculated and verified by ERP |
| 2 | Draft not calculated: prices and other attributes may not be valid |
| 3 | Draft has problems requiring approval |
| 4 | Draft approved (with problems) |
| 5 | Draft not approved due to problems |
| 6 | Sent to customer and is now a legally binding document |
| 7 | Archived |
| 8 | Rejected by customer (sale lost) |
| 9 | Accepted by customer (sold) |

## Status

| Status | Description |
|:-:|:--|
| 0 | OK, all is good |
| 1 | All is good, however, the user should be made aware of something |
| 2 | Problem, notify user |
| 3 | Problem, action required |

## Quote vs. other entities

When working with quotes, data will often intersect with the following entities:

* [Documents][1]
* [Follow-ups][2] (appointment table)
* [Company][3] (contact table)
* [Contact][4] (person table)
* [Project][5]
* [Sale][6]

<!-- Referenced links -->
[1]: ../document/index.yml
[2]: ../diary/index.yml
[3]: ../company/index.yml
[4]: ../contact/index.yml
[5]: ../project/index.yml
[6]: ../sale/index.yml
[7]: ../api/plugins/quote-connectors/index.md
