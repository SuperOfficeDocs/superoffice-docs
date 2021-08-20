---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 17.08.2021
keywords:
---

# SalesAfterSaveContact (1105)

Called after a contact is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[ContactEntity input values](includes/contact-var.md)]

## Sample code

```crmscript
// Get the variables in the current context
EventData ed = getEventData();

String contactId = ed.getInputValue("ContactEntity.ContactId");

// If contact is new and category is "Prospect" create a new Sale opportunity
if(ed.getInputValue("IsNew") == "true" && ed.getInputValue("ContactEntity.Category.Value") == "Prospect"))
{
  NSSaleAgent saleAgent;
  NSContactAgent contactAgent;
  NSContact contact = contactAgent.GetContact(contactId.toInteger());
  NSSaleEntity entity = saleAgent.CreateDefaultSaleEntity();

  entity.SetHeading("New potential sale on " + ed.getInputValue("ContactEntity.Name"));
  entity.SetContact(contact);

  NSSaleType saleType;
  saleType.SetId(1);
  entity.SetSaleType(saleType);

  saleAgent.SaveSaleEntity(entity);
}
```
