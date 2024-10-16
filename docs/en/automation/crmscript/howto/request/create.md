---
uid: crmscript-request-create
title: Create and update requests
description: How to create a ticket with CRMScript.
keywords: Service, ticket, request, CRMScript
author: Bergfrid Skaara Dias
date: 05.26.2023
version: 10
topic: howto
---

# Create and update requests

## Void setValue(String colName, String value)

Sets a named field to the given value. Look up names in the reference section down below, or check out the [class reference][1].

> [!NOTE]
> Both parameters are strings! Remember to use quotes even for IDs.
>
> You must call `save()` after setting all applicable values to actually create or update the ticket.

```crmscript!
Ticket t;
t.setValue("title", "No audio");
t.setValue("category", "2");
t.setValue("status", "1");
t.setValue("priority", "2");
print(t.save().toString());
```

This snippet creates a new ticket and prints its ID.

> [!TIP]
> To check the available options for category, status, and priority: Go to the SuerOffice Admin client and select **Requests** from the main menu. You can now inspect the options in each tab.

### Frequently used ticket values

| Parameter | Db field | Description |
|:--|:--|:--|
| title        | title | A descriptive name, String |
| category     | category | The ID of the category the ticket belongs to |
| ownedBy      | owned_by | The ID of the user who owns the ticket |
| slevel       | slevel | The security level of the ticket (1: internal, 2: external) |
| priority     | priority | The ID |
| status       | status | The main ticket status \[0-5\] |
| custId       | cust_id | The ID of the primary customer |
| customers    | ticket_customers | A comma-separated list of customer IDs |
| createdBy    | created_by | The ID of the user who posted the ticket (1: system) |

For a complete list of fields, see the [database reference][6].

## Integer save()

Saves a new or updated ticket and returns its ID.

```crmscript
Ticket t;
t.setValue("title", "No audio");
t.save();
```

## Integer save(String log)

A variant of `save()` that also adds a message to the ticket log.

```crmscript
Ticket t;
t.setValue("title", "No audio");
t.save("This is the 5th audio complaint in 1 hour!");
```

## Integer save(Bool setReadStatus, Bool doNotCheckEscalating)

A variant of `save()` with 2 settings for controlling processing:

* `setReadStatus`: if **true**, update the read status
* `doNotCheckEscalating`: if **true**, do NOT let the update trigger a possible escalation

```crmscript
Ticket t;
t.setValue("title", "No audio");
t.save(true, false);
```

## Integer save(String log, Bool setReadStatus, Bool doNotCheckEscalating)

A variant of `save()` that combines the processing settings and a log message.

```crmscript
Ticket t;
t.setValue("title", "No audio");
t.save("audio",true, true);
```

<!-- Referenced links -->
[1]: <xref:CRMScript.Native.Ticket.setValue(String,String)>
[6]: ../../../../database/tables/ticket.md
