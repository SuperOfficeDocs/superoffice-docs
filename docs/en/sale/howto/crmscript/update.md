---
uid: crmscript-sale-update
title: Update a sale
description: How to update a sale with CRMScript in SuperOffice.
author: Bergfrid Dias
so.date: 06.09.2023
keywords: sale, SaleAgent
so.topic: howto
---

# Update a sale

```crmscript
NSSaleAgent saleAgent;
NSSaleEntity sale = saleAgent.GetSaleEntity(4);

NSListAgent listAgent;
sale.SetCompetitor(listAgent.GetCompetitor(1));

sale = saleAgent.SaveSaleEntity(sale);
```

## Delete a sale

It might be necessary to delete a sale if it is no longer appropriate to store it in the database.

```crmscript
NSSaleAgent saleAgent;
Void DeleteSaleEntity(123);
```

<!-- Referenced links -->
