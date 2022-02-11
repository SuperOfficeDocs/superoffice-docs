---
uid: crmscript_sales
title: Sales
description: Working with sales in CRMScript
author: Bergfrid Dias
so.date: 02.04.2022
keywords: sale
so.topic: concept
---

# Sales

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

## List available sale types

```crmscript!
SearchEngine se;
se.addFields("SaleType", "SaleType_Id,name");
print(se.executeTextTable());
```

<!-- Referenced links -->
