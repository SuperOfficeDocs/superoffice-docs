---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 17.08.2021
keywords:
---

# SalesAfterSaveSale (1108)

Called after a sale is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[SaleEntity input values](includes/sale-var.md)]

## Sample code

```crmscript
//If sale status has changed and is sold - Change customer category
if(ed.getInputValue("SaleStatusChanged") == "True" && ed.getInputValue("SaleStatus") == "2")
{
    if(ed.getInputValue("SaleEntity.Contact.CategoryName") == "Prospect")
    {
      NSContactAgent contactAgent;
      NSContactEntity entity = contactAgent.GetContactEntity(ed.getInputValue("SaleEntity.Contact.ContactId").toInteger());

      NSCategory category;
      category.SetId(1);
      entity.SetCategory(category);

      contactAgent.SaveContactEntity(entity);

    }
}
```
