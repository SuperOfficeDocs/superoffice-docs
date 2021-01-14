---
title: Pipeline 
uid: crmscript_sale-pipeline
SortOrder: 30
---

## View sales

Whether you're a sales rep who wants to see whether you have enough ongoing sales opportunities to reach their budget or a sales manager who wants to see how their team is performing, inspecting the pipeline provides valuable info.

> [!TIP]
> You can only retrieve sales for persons that are SuperOffice users ([associates](../persons-and-organizations/employees.md)). The signed-in user must also have permission to view those sales. Otherwise, an exception is thrown.

### NSSale[] GetSalesByDate(DateTime fromDate, DateTime toDate, Integer amountLimit, Integer status)

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

### NSSale[] GetOpenSalesForContact(Integer contactId)

```crmscript
NSSaleAgent saleAgent;
NSSale[] saleList = saleAgent.GetOpenSalesForContact(1);
```

### NSSale[] GetUpcomingSales(Integer weightedAmountLimit, Integer count)

Fetches all open sales (in descending order). Optionally limit the result by a weighted amount and/or count. Set either filter to **-1** top ignore it.

Weighting is based on the probability that the sale will be closed (amount * probability).

```crmscript
NSSaleAgent saleAgent;
NSSale[] saleList = saleAgent.GetUpcomingSales(-1,-1);
```

## Check if a contact has open sales

```crmscript
Bool hasOpenSales(Integer contactId) {
  NSSaleAgent saleAgent;
  DateTime from;
  DateTime to;

  NSSaleSummary summary = saleAgent.GetSummaryByContact(contactId, from.addDay(-30), to);
  
  return summary.GetOpen() > 0;
}

print(hasOpenSales(2).toString());
```

## Get sales for associate

To call `GetSaleList()`, we need to create the list of sale IDs 1st.

```crmscript
String associateId = "5";
Integer[] saleIds;

SearchEngine se;
se.addField("sale.sale_id");
se.addCriteria("sale.associate_id", "OperatorEquals", associateId,"OperatorAnd", 1);
se.execute();

while (!se.eof()) {
  saleIds.pushBack(se.getField(0).toInteger());
  se.next();
}

NSSaleAgent saleAgent;
NSSale[] saleList = saleAgent.GetSaleList(saleIds);
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

## Prioritize your most urgent or valuable opportunities

What constitutes the hottest sales opportunities is up to you. But here's a few options to create a shortlist.

### Get next due date for a given sale

```crmscript
Integer saleId = 1;
NSSaleAgent saleAgent;
DateTime due = saleAgent.GetNextDueDate(saleId);
printLine("This sale is due " + due.toString());
```

### Get the n most urgent open sales

```crmscript
DateTime now;
Integer[] saleIds;

SearchEngine se;
se.addField("sale.sale_id");
se.addCriteria("sale.status", "OperatorEqual", "1","OperatorAnd", 1);
se.addCriteria("sale.sale", "OperatorLt", now.toString(), "OperatorAnd", 1);
se.addOrder("sale.saledate", false);
se.setLimit(10);
se.execute();

while (!se.eof()) {
  saleIds.pushBack(se.getField(0).toInteger());
  se.next();
}

NSSaleAgent saleAgent;
NSSale[] saleList = saleAgent.GetSaleList(saleIds);
```

### Get the n potentially largest open sales

```crmscript
String amount = "100.0";
Integer[] saleIds;

SearchEngine se;
se.addField("sale.sale_id");
se.addCriteria("sale.amount", "OperatorGt", amount,"OperatorAnd", 1);
se.addCriteria("sale.status", "OperatorEqual", "1","OperatorAnd", 1);
se.addOrder("sale.amount", false);
se.setLimit(10);
se.execute();

while (!se.eof()) {
  saleIds.pushBack(se.getField(0).toInteger());
  se.next();
}

NSSaleAgent saleAgent;
NSSale[] saleList = saleAgent.GetSaleList(saleIds);
```

## Stalled sales

A sale might become stalled if, say, the customer decides to wait until next year before purchasing.

When this happens, the next activity changes to the re-open date. The seller should then set up a future meeting or phone call to follow up the stalled sale.

* `reasonStalled_id`: reference to why the sale is stalled
* `reopenDate`: when the sale should be reopened
