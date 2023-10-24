---
uid: crmscript-sale-create
title: Record a sale
description: How to create a sale with CRMScript in SuperOffice.
author: Bergfrid Dias
so.date: 06.09.2023
keywords: sale, SaleAgent
so.topic: howto
---

# Record a sale

One way of reaching your sales target is to increase the number of activities you start and complete. But it all starts with registering leads.

```crmscript!
NSSaleAgent saleAgent;
NSSaleEntity newSale = saleAgent.CreateDefaultSaleEntity();

newSale.SetHeading("Back to school campaign");

NSListAgent listAgent;
newSale.SetSaleType(listAgent.GetSaleType(1));

NSContactAgent contactAgent;
newSale.SetContact(contactAgent.GetContact(1));

newSale.SetAmount(Float("19.9"));

DateTime expectedSaleDate;
expectedSaleDate.addMonth(2);
newSale.SetSaledate(expectedSaleDate);

newSale = saleAgent.SaveSaleEntity(newSale);

print("Registered new sale with ID " + newSale.GetSaleId().toString());
```

## Find company ID from ticket ID

You might be picking up leads such as up-sells to existing customers from Service tickets. Here's how to get the contact ID from the [ticket][1]:

```crmscript
Integer ticketId = 123;
Integer contactId;

SearchEngine se;
se.addField("ticket.cust_id.contact_id");
se.addCriteria("ticket.id", "Equals", ticketId.toString(), "and", 0);

se.execute();

if (!se.eof()) {
  contactId = se.getField(0).toInteger();
}
```

## Create a follow-up for a sale

The generic procedure is like this. The details are up to you.

1. Retrieve an existing sale or create a new.
2. Create the new follow-up **and save it**.
3. Call `SetAppointment()` to link the follow-up to the sale.
4. Save the sale.

> [!NOTE]
> The follow-up you created is an **NSAppointmentEntity**, but `SetAppointment()` takes an **NSAppointment**. You can't pass the saved follow-up directly, but need to fetch the corresponding slim version by ID.

In this example, we use info from the sale to populate the new [follow-up][2].

```crmscript
NSSaleAgent saleAgent;
NSSaleEntity sale = saleAgent.GetSaleEntity(4);

NSAppointmentAgent appointmentAgent;
NSAppointmentEntity todo = appointmentAgent.CreateDefaultAppointmentEntityByTypeAndAssociate(7, sale.GetAssociate().GetAssociateId());

todo.SetDescription("Set up initial meeting");
todo.SetContact(sale.GetContact());
todo.SetEndDate(getCurrentDateTime().addHour(2));

todo = appointmentAgent.SaveAppointmentEntity(todo);

sale.SetAppointment(appointmentAgent.GetAppointment(todo.GetAppointmentId()));
sale = saleAgent.SaveSaleEntity(sale);
```

<!-- Referenced links -->
[1]: ../../../request/howto/crmscript/create.md
[2]: ../../../diary/howto/crmscript/index.md
