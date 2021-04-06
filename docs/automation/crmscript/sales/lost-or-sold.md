---
uid: crmscript_sale-done
title: Lost or sold sales
author:
so.date:
keywords:
so.topic:
---

# Lost or sold sales

In the end, regardless of whether you followed a sales guide or not, a sale is either **sold** or **lost**. It is time to wrap things up and at the same time make sure the seller and others can learn from it either way.

| Status | Description        |
|:------:|:-------------------|
| 2      | Sold               |
| 3      | Lost               |

## Sold

The date and amount are no longer estimates, and you can record the actual values. Also, keeping track of why the sales rep made the sale can prove beneficial.

```crmscript
NSListAgent listAgent;
NSSaleAgent saleAgent;

NSSaleEntity sale = saleAgent.GetSaleEntity(4);

sale.SetStatus(2);
sale.SetSaledate(getCurrentDateTime());
sale.SetAmount(Float("59.7"));
sale.SetReasonSold(listAgent.GetReasonSold(3));
sale.SetCredited(listAgent.GetCredited(5));

sale = saleAgent.SaveSaleEntity(sale);
```

### List available reasons for winning

```crmscript!
SearchEngine se;
se.addFields("ReasonSold", "ReasonSold_Id,name");
print(se.executeTextTable());
```

### List the latest successful sales

You can get the won sales directly from the agent without filtering by date and status.
When calling `GetRecentSales()`, you can optionally limit the result by an amount and/or count.

> [!TIP]
> To ignore a filter, set it to **-1**.

```crmscript!
NSSaleAgent saleAgent;
NSSale[] saleList = saleAgent.GetRecentSales(-1, 10);

for(Integer i = 0; i < saleList.length(); i++) {
  print(saleList[i].GetTitle() + "\t ID: " + saleList[i].GetSaleId().toString() + "\t amount: " + saleList[i].GetAmount().toString(1));
}
```

The result is sorted descending with the most recent at the top.

## Lost

Lessons learned: why the sale was lost and to which competitor.

```crmscript
NSListAgent listAgent;
NSSaleAgent saleAgent;

NSSaleEntity sale = saleAgent.GetSaleEntity(4);

sale.SetStatus(3);
sale.SetSaledate(getCurrentDateTime());
sale.SetReason(listAgent.GetReason(4));
sale.SetCompetitor(listAgent.GetCompetitor(1));

sale = saleAgent.SaveSaleEntity(sale);
```

### List available reasons for a loss

```crmscript!
SearchEngine se;
se.addFields("Reason", "Reason_id,name");
print(se.executeTextTable());
```

### List sales lost in a given month

```crmscript!
DateTime start = String("2020-01-01").toDateTime();
DateTime end = start;
end.moveToMonthEnd();

NSSaleAgent saleAgent;
NSSale[] saleList = saleAgent.GetSalesByDate(start, end,-1,3);

if (saleList.length() == 0) {
  printLine("No lost sales in month " + start.getMonth().toString());
}
else {
  for(Integer i = 0; i < saleList.length(); i++) {
    print(saleList[i].GetTitle() + "\t ID: " + saleList[i].GetSaleId().toString());
  }
}
```

> [!NOTE]
> `GetSalesByDate()` returns the simple **NSSale** type. If you want to dig into details such as reasons for losing the sale, you need to also fetch the corresponding **NSSaleEntity** based on the sale ID.

### List sales lost by reason

```crmscript!
SearchEngine se;
se.addFields("sale", "sale_id,associate_id,contact_id,comptr_id");
se.addCriteria("sale.status", "OperatorEqual", "1","OperatorAnd", 3);
se.addOrder("sale.reason_id", false);

if (!se.eof()) {
  print(se.executeTextTable());
}
```
