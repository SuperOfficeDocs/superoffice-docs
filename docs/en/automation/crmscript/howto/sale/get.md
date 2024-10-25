---
uid: crmscript-sale-get
title: Retrieve a sale
description: How to retrieve a sale with CRMScript in SuperOffice
keywords: sale, SaleAgent
author: Bergfrid Dias
date: 06.09.2023
version: 10
topic: howto
---

<!-- markdownlint-disable-file MD013 -->

# Retrieve a sale

Whether you're a sales rep who wants to see whether you have enough ongoing sales opportunities to reach their budget or a sales manager who wants to see how their team is performing, inspecting the pipeline provides valuable info.

> [!TIP]
> You can only retrieve sales for persons that are SuperOffice users [associates][1]. The signed-in user must also have permission to view those sales. Otherwise, an exception is thrown.

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

## NSSale[] GetSalesByDate(DateTime fromDate, DateTime toDate, Integer amountLimit, Integer status)

Fetch all sales within a time period. Optionally limit the result by amount and/or status.

* `amountLimit`: amount in local currency OR **-1** to ignore filter
* `status`: 1-4 (open,sold,lost,stalled) OR **0** to ignore filter

```crmscript!
DateTime start;
start.addMonth(-6);
DateTime end;

NSSaleAgent saleAgent;
NSSale[] saleList = saleAgent.GetSalesByDate(start, end,-1,0);

for(Integer i = 0; i < saleList.length(); i++) {
  print(saleList[i].GetTitle() + "\t ID: " + saleList[i].GetSaleId().toString() + "\t amount: " + saleList[i].GetAmount().toString(1));
}
```

## NSSale[] GetOpenSalesForContact(Integer contactId)

```crmscript
NSSaleAgent saleAgent;
NSSale[] saleList = saleAgent.GetOpenSalesForContact(1);
```

## NSSale[] GetUpcomingSales(Integer weightedAmountLimit, Integer count)

Fetches all open sales (in descending order). Optionally limit the result by a weighted amount and/or count. Set either filter to **-1** top ignore it.

Weighting is based on the probability that the sale will be closed (amount * probability).

```crmscript
NSSaleAgent saleAgent;
NSSale[] saleList = saleAgent.GetUpcomingSales(-1,-1);
```

## Statistics

### NSSaleSummary GetSummaryByAssociate(Integer associateId, DateTime start, DateTime end)

This example fetches the number of sold, lost, and open sales for an associate since January 01, 2020.

```crmscript!
DateTime start = String("2020-01-01").toDateTime();
DateTime end;

NSSaleAgent saleAgent;
NSSaleSummary summary = saleAgent.GetSummaryByAssociate(1, start, end);

printLine("Sold: " + summary.GetSold().toString() + "\tLost: " + summary.GetLost().toString() + "\tOpen: " + summary.GetOpen().toString());
```

### NSSaleSummary GetSummaryByContact(Integer contactId, DateTime start, DateTime end)

This example fetches the number of sales and the total amount for a company from the time it was registered until now.

```crmscript!
Integer contactId = 1;

NSContactAgent contactAgent;
NSContact contact = contactAgent.GetContact(contactId);

DateTime start = contact.GetCreatedDate();
DateTime end;

NSSaleAgent saleAgent;
NSSaleSummary summary = saleAgent.GetSummaryByContact(contactId, start, end);

printLine("Sold: " + summary.GetSold().toString() + "\tTotal: " + summary.GetSoldTotalBaseCurrency().toString());
```

<!-- Referenced links -->
[1]: ../../../../contact/reference/index.md#associate
