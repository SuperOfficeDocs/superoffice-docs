---
uid: crmscript_quotes
title: Quotes
author:
so.date:
keywords:
so.topic:
---

# Quotes

In sales, a quote allows a prospective buyer to see the **costs of selected products and/or services**. It can contain multiple **alternatives** for the customer to choose between.

For you as a CRMScript developer, working with quotes means that:

* you won't have to worry about miscalculating
* the sales details can be automatically updated

## ERP

You might be working with a tenant that is integrated with an ERP system.
In that case, the ERP connection determines where the product information and prices are obtained from.

### Find available quote connections

```crmscript!
SearchEngine se;
se.addFields("QuoteConnection", "quoteconnection_id,DisplayName,Rank");
print(se.executeTextTable());
```

## Quote vs. other entities

When working with quotes, data will often intersect with the following entities:

* [documents][1]
* [follow-ups][2] (appointment table)
* [company][3] (contact table)
* [contact][4] (person table)
* [project][5]
* [sale][6]

## In this section

1. autolist

<!-- Referenced links -->
[1]: ../documents/index.md
[2]: ../follow-ups/index.md
[3]: ../persons-and-organizations/company.md
[4]: ../persons-and-organizations/customer.md
[5]: ../projects/index.md
[6]: ../sales/index.md
