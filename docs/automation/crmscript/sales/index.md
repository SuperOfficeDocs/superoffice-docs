---
title: Sales
uid: crmscript_sales
SortOrder: 40
---

A sale process typically consists of different stages. For each stage, you have certain activities and perhaps documents that need to be completed. With every activity and every stage completed, you will get closer to [closing the sale](./lost-or-sold.md).

## Key info

* a unique ID
* a short descriptive heading
* an amount
* an (expected) closing date
* the type of sale
* a status
* the seller and the customer

## Retrieve a sale

**To view basic info, use NSSale:**

```crmscript
NSSaleAgent saleAgent;
NSSale sale = saleAgent.GetSale(1);
printLine(sale.GetSaleTypeName());
```

**To view (and possibly update) complex info, use NSSaleEntity:**

```crmscript!
NSSaleAgent saleAgent;
NSSaleEntity sale = saleAgent.GetSaleEntity(1);
printLine(sale.GetSaleType().GetValue());
```

## Sale type

A *sale type* is a named set of reuseable info that will help you standardize the sale process. Aside from the name and ID, you'll find info such as:

* the expected duration
* whether it has stakeholders
* whether a sales guide is available
* percentages for discount and profit
* stages

**List available types:**

```crmscript!
SearchEngine se;
se.addFields("SaleType", "SaleType_Id,name");
print(se.executeTextTable());
```

## Sales guides

[Using a *guide*](./guides.md) will simplify and structure the sales process for the sales staff with suggestions for which follow-ups to do and which documents to create at each stage.

## Status of a sale

| Status | Description        |
|:------:|:-------------------|
| 0      | Unknown            |
| 1      | Open               |
| 2      | Sold               |
| 3      | Lost               |
| 4      | Stalled            |

## Sales vs. other entities

When working with sales, data will often intersect with the following entities:

* [follow-ups](../follow-ups/index.md) (appointment table)
* [company](../persons-and-organizations/company.md) (contact table)
* [contact](../persons-and-organizations/customer.md) (person table)
* project

## In this section

1. autolist
