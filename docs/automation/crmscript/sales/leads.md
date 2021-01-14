---
title: Leads 
uid: crmscript_sale-leads
SortOrder: 10
---

One way of reaching your sales target is to increase the number of activities you start and complete. But it all starts with registering leads.

## Record a sale

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

You might be picking up leads such as up-sells to existing customers from service tickets. Here's how to get the contact ID from the [ticket](../requests/tickets.md):

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

## Update a sale

```crmscript
NSSaleAgent saleAgent;
NSSaleEntity sale = saleAgent.GetSaleEntity(4);

NSListAgent listAgent;
sale.SetCompetitor(listAgent.GetCompetitor(1));

sale = saleAgent.SaveSaleEntity(sale);
```

## Create a follow-up for a sale

The generic procedure is like this. The details are up to you.

1. Retrieve an existing sale or create a new.
2. Create the new follow-up **and save it**.
3. Call `SetAppointment()` to link the appointment to the sale.
4. Save the sale.

> [!NOTE]
> The follow-up you created is an **NSAppointmentEntity**, but `SetAppointment()` takes an **NSAppointment**. You can't pass the saved follow-up directly, but need to fetch the corresponding slim version by ID.

In this example, we use info from the sale to populate the new [follow-up](../follow-ups/index.md).

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

## Delete a sale

It might be necessary to delete a sale if it is no longer appropriate to store it in the database.

```crmscript
NSSaleAgent saleAgent;
Void DeleteSaleEntity(123);
```

## Reference

### Frequently used fields

| Field          | Description                                  |
|:---------------|:---------------------------------------------|
| sale_id        | ID                                           |
| heading        | short description                            |
| associate_id   | owner                                        |
| source_id      | origin of the lead                           |
| amount         | total sale amount                            |
| project_id     | optional project reference                   |
| contact_id     | company                                      |
| saleType_id    | type of sale                                 |
| status         | EnumSaleStatus 1 = open, 2 = sold, 3 = lost, 4 = stalled |
| done           | EnumSaleDone 0 = unknown, 1 = no, 2 = yes    |

For a complete list of fields, see the [database reference](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-sale.htm).

### Timestamp values

| Field         | Description                                              |
|:--------------|:---------------------------------------------------------|
| registered    | UtcDateTime of registration                              |
| updated       | UtcDateTime of last update                               |
| saledate      | expected closing time or when it was lost/won (DateTime) |
| nextDueDate   | closest future activity date<br />if nothing is planned: the most recent activity |
