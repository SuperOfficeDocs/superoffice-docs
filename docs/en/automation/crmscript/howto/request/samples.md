---
uid: crmscript-request-samples
title: Samples
description: Sample code for working with requests in CRMScript.
keywords: Service, ticket, request, CRMScript
author: Bergfrid Skaara Dias
date: 05.26.2023
version: 10
content_type: howto
redirect_from: /en/request/howto/crmscript/samples
---

# Samples

## List available categories

```crmscript!
SearchEngine se;
se.addField("ej_category.name");
printLine(se.executeTextTable());
```

## List available priorities

```crmscript!
SearchEngine se;
se.addField("ej_priority.name");
printLine(se.executeTextTable());
```

## Find requests

### Search for a ticket with a given tag

Tagging is a powerful tool for organizing and finding requests in SuperOffice Service.

```crmscript!
SearchEngine se;
se.addFields("ticket", "id,title");
se.addCriteria("ticket.tags", "in", "1,2");
printLine(se.executeTextTable());
```

> [!TIP]
> List tags by their ID as a comma-separated string.

### List all tickets with a given status

```crmscript!
SearchEngine se;
se.addFields("ticket", "id,title,cust_id.contact_id.associate_id");
se.addCriteria("ticket.status", "OperatorEquals", "1");
printLine(se.executeTextTable());
```

This snippet lists all **active** tickets. Change the last argument to `addCriteria()` to filter on other statuses.

## Find people

### Find "Our contact" on the company for the customer connected to the ticket

There is not a direct route from a ticket to an associate. You need to step through the tables in the following order using the foreign keys:

* Ticket (cust_id)
* Person (contact_id)
* Contact (associate_id)
* Associate

```crmscript
SearchEngine se;
se.addField("ticket.cust_id.contact_id.associate_id");
se.addCriteria("ticket.id", "OperatorEquals", "1");
se.execute();
```

This snippet fetches the associate ID of "Our contact" form ticket 1.

## Postpone tickets

Sometimes you need to put tickets on the back-burner.

```crmscript
DateTime now = getCurrentDateTime();

Ticket t;
t.load(3);
t.setValue("status", "3");
t.setValue("lastChanged", now.toString());
t.setValue("dbiLastModified", now.toString());

Message m;
m.setValue("ticketId", t.getValue("id"));
m.setValue("createdAt", t.getValue("lastChanged"));
m.setValue("createdBy", t.getValue("ownedBy"));
m.setValue("slevel", "1");
m.setValue("body", "Expecting fix in next patch");
m.save();

t.setValue("activate", now.moveToMonthEnd().toString());
t.save();
t.notifyEmail(5);
```
