---
uid: sale-overview
title: Sales
description: Sales in SuperOffice
author: Bergfrid Dias
date: 06.09.2023
keywords: sale
topic: concept
---

# Sales

A sale process typically consists of different stages. For each stage, you have certain activities and perhaps documents that need to be completed. With every activity and every stage completed, you will get closer to closing the sale.

[!include[License requirement](../../../common/includes/req-sales-essentials.md)]

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

[!include[License requirement](../../../common/includes/req-sales-prem.md)]

## Sales guides

Using a guide will simplify and structure the sales process for the sales staff with suggestions for which follow-ups to do and which documents to create at each stage.

[!include[License requirement](../../../common/includes/req-sales-prem.md)]

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

The blueprints sit in the intersection between sale types and stages. A sale type can have many stages, and a stage can apply to multiple sale types. The [SaleTypeStageLink table][5] connects them all.

## Status of a sale

| Status | Description |
|:------:|:------------|
| 0      | Unknown     |
| 1      | Open        |
| 2      | Sold        |
| 3      | Lost        |
| 4      | Stalled     |

### Stalled sales

A sale might become stalled if, say, the customer decides to wait until next year before purchasing.

When this happens, the next activity changes to the re-open date. The seller should then set up a future meeting or phone call to follow up the stalled sale.

## Sales vs. other entities

When working with sales, data will often intersect with the following entities:

* [Follow-ups][1] (appointment table)
* [Company][2] (contact table)
* [Contact][3] (person table)
* [Project][4]

## Howtos

* [Sale management in the UI][6]
* [Using CRMScript][7]
* [Using raq SQL][8]

<!-- Referenced links -->
[1]: ../diary/index.yml
[2]: ../company/index.yml
[3]: ../contact/index.yml
[4]: ../project/index.yml
[5]: ../database/tables/saletypestagelink.md
[6]: learn/index.md
[7]: ../automation/crmscript/howto/sale/index.md
[8]: ../api/sql/howto/sale/stakeholders.md

<!-- Referenced images -->
[img1]: media/stakeholders.png
[img2]: media/include-stakeholders.png
