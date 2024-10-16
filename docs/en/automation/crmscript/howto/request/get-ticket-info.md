---
uid: crmscript-request-load
title: Get ticket info
description: How to load and get ticket info with CRMScript
keywords: Service, ticket, request, CRMScript, load
author: Bergfrid Skaara Dias
date: 05.26.2023
version: 10
topic: howto
---

# Get ticket info

## Bool load(Integer id)

Brings up the ticket with the given ID. This is always the first step when you want to do anything with an existing ticket.

```crmscript
Ticket t;
t.load(1);
```

## String getValue(String colName)

Fetches the value from a named field. Look up names in the reference section down below, or check out the [class reference][3].

```crmscript!
Ticket t;
t.load(2);
print(t.getValue("ticketStatus"));
```

<!-- Referenced links -->
[3]: <xref:CRMScript.Native.Ticket.getValue(String)>
