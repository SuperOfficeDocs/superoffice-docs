---
uid: crmscript-sale-samples
title: Samples
description: Sample code for working with projects in CRMScript.
keywords: sale, SearchEngine
author: Bergfrid Dias
date: 06.09.2023
version: 10
topic: howto
---

# Samples

## List available sale types

```crmscript!
SearchEngine se;
se.addFields("SaleType", "SaleType_Id,name");
print(se.executeTextTable());
```

## Check if a sale is connected to a guide

```crmscript!
NSListAgent listAgent;
NSSaleAgent saleAgent;

NSSaleEntity sale = saleAgent.GetSaleEntity(4);

Integer saleTypeId = sale.GetSaleType().GetId();
NSSaleTypeEntity type = listAgent.GetSaleTypeEntity(saleTypeId);

if (type.GetHasGuide()) {
  printLine("This sale has a guide!");
}
else {
  printLine("This sale does not have a guide.");
}
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

<!-- Referenced links -->
