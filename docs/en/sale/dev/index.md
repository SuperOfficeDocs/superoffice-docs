---
uid: sale-overview
title: Sales
description: Sales in SuperOffice
keywords: sale process, base currency, currency, enable Stakeholders, stakeholder, suggested activities, stages, stalled, SaleTypeStageLink, quote connection, quote line, quote version, product, price list, sale, quote
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: en
index: true
redirect_from:
  - /en/quote/index
  - /en/sale/overview
---

# Sales

A sale process typically consists of different stages. For each stage, you have certain activities and perhaps documents that need to be completed. With every activity and every stage completed, you will get closer to closing the sale.

[!include[License requirement](../../../../common/includes/req-sales-essentials.md)]

## Key info

* A unique ID
* A short descriptive heading
* An amount
* An (expected) closing date
* The type of sale
* A status
* The seller and the customer

## Currency

Currency options depend on a couple of things:

* Whether the use of currency has been enabled
* The base currency setting
* The local (own) currency setting

> [!NOTE]
> If the sale has a **quote**, you will not be able to set or change the currency of that sale.

Currency exchange rates are fixed and apply to all sales. You can change them manually in the Settings and maintenance (or programmatically).

The **base currency** is the currency with an exchange rate equal to 1. Other exchange rates are expressed relative to this.

### Currency conversion

| Type of conversion | Math |
|---|---|
| To the base currency | Divide by rate and multiply by units. |
| From the base currency | Divide by units and multiply by rate. |
| Between any two currencies | Either do a two-step conversion via the base currency **or** calculate the relative rate between those two currencies and apply that directly. |

## Stakeholders

A sale has a main contact, but partners and subcontractors may also be involved in the sale. These are referred to as **stakeholders** and can be either individuals, organizations, or a mix.

This can be turned off using the preference in **Settings and maintenance** > **Preferences** > **Sale** > **Enable Stakeholders (default yes)**. With this preference turned on a new archive is presented for sales of type.

![Stakeholders -screenshot][img1]

This will also make the sale visible on more than one company sales archive if **Enable Stakeholders** is set.

![Enable stakeholders setting -screenshot][img2]

[!include[License requirement](../../../../common/includes/req-sales-prem.md)]

## Sales guides

Using a guide will simplify and structure the sales process for the sales staff with suggestions for which follow-ups to do and which documents to create at each stage.

[!include[License requirement](../../../../common/includes/req-sales-prem.md)]

## Sale type

A *sale type* is a named set of reuseable info that will help you standardize the sale process. Aside from the name and ID, you'll find info such as:

* The expected duration
* Whether it has stakeholders
* Whether a sales guide is available
* Percentages for discount and profit
* Stages

Some sale types have an associated sales guide. For those types, it's important to understand stages and how to work with suggested activities.

## Stages

Each stage has a set of **suggested activities**. There is also a setting controlling whether the sale will automatically advance to the next stage when the last guided activity in a stage is completed.

The sequence of the stages is determined by the **rank** of each stage.

**Example process:**

1. Lead
2. First meeting
3. Proposal
4. Second meeting
5. Short-list
6. Verbal acceptance

## Suggested activities

Suggested activities are just that  - **suggested**. They're blueprints that can be used to create actual follow-ups and documents.

The blueprints sit in the intersection between sale types and stages. A sale type can have many stages, and a stage can apply to multiple sale types. The [SaleTypeStageLink table][10] connects them all.

## Status of a sale

| Status | Description |
|:-:|:-|
| 0 | Unknown |
| 1 | Open |
| 2 | Sold |
| 3 | Lost |
| 4 | Stalled |

### Stalled sales

A sale might become stalled if, say, the customer decides to wait until next year before purchasing.

When this happens, the next activity changes to the re-open date. The seller should then set up a future meeting or phone call to follow up the stalled sale.

## <a id="quote"></a>Quote management

[!include[License requirement](../../../../common/includes/req-sales-prem.md)]

In sales, a quote allows a prospective buyer to see the **costs of selected products and/or services**. It can contain multiple **alternatives** for the customer to choose between.

Quotes are what connects products to a sale. You must record a sale **before** you can add a quote. Also, products must have been registered before you can add them to a quote.

> [!NOTE]
> Each quote belongs to a single sale. And there's only 1 quote per sale.

### Key info

* A unique ID
* The corresponding sale
* An ERP connection
* A version
* Alternatives
* Products
* A state

### Versions

There may be multiple versions of a quote, but only 1 of them is **active** at any time. Each version will have 1 or more alternatives, which in turn will have 1 or more quote lines.

When updating quotes, you'll always be working on the latest version.

### Alternatives and quote lines

Each alternative can contain different products, numbers of products, prices, and discounts. You should set the quantity and any discounts for the selected product.

A **discount** can be specified as:

* A percentage rate
* A discount amount
* A total amount

The estimated sales amount for the sale (forecast) is obtained from the total amount for the **favorite alternative**.

### Products and price lists

Each product belongs to a single price list. A price list can either be cached from an ERP system or set up in SuperOffice CRM.

#### ERP

You might be working with a tenant that is integrated with an ERP system. In that case, the ERP connection determines where the product information and prices are obtained from.

#### Quote connectors

SuperOffice has a simple product and price-list system built in, but using [quote connectors][9] you can access products and price lists in other systems from inside SuperOffice.

#### VAT

The SuperOffice quote connector will calculate the VAT **amount** of an alternative based on the VAT **percent** of the individual lines.

> [!CAUTION]
> Other connectors may implement different VAT algorithms at will! Make sure you interpret the VAT field correctly.

### Quote documents

Quote documents will be saved as **activities on a sale**. They're tied to a specific **quote version**.

### State

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

### Status

| Status | Description |
|:-:|:--|
| 0 | OK, all is good |
| 1 | All is good, however, the user should be made aware of something |
| 2 | Problem, notify user |
| 3 | Problem, action required |

## Sales and quotes vs. other entities

When working with sales and quotes, data will often intersect with the following entities:

* [Follow-ups][1] (appointment table)
* [Documents][5]
* [Company][2] (contact table)
* [Contact][3] (person table)
* [Project][4]

## How-tos

* [Sale management in the UI][6]
* [Using CRMScript][7]
* [Using raq SQL][8]

<!-- Referenced links -->
[1]: ../../diary/index.yml
[2]: ../../company/index.yml
[3]: ../../contact/index.yml
[4]: ../../project/index.yml
[5]: ../../document/index.yml
[6]: ../learn/index.md
[7]: ../../automation/crmscript/howto/sale/index.md
[8]: ../../api/sql/howto/sale/stakeholders.md
[9]: ../../api/plugins/quote-connectors/index.md
[10]: ../../database/tables/saletypestagelink.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/stakeholders-section-tab.png
[img2]: ../../../media/loc/en/sale/enable-stakeholders.png
