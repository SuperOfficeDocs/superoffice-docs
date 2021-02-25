---
title: cs_soap_ports_ticket_getpriorities
description: Services SOAP interface ticket reference getPriorities
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getPriorities

## Description

Gets all the available priorities. The lowest ordered priority will be first in the array.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| priorities | A sorted array of `PriorityStruct` with lowest sortOrder first. Elements are: id, name, sortOrder (higher number indicates higher priority) |

## Example

```csharp
string sessionKey;

ticket.ticketService ticketService = new ticket.ticketService();

if(ticketService.login("test","test",out sessionKey)=="0")
{
  ticket.PriorityStruct[] priorities;
  ticketService.getPriorities(sessionKey, out priorities);
  string newValue="";
  foreach(ticket.PriorityStruct i in priorities)
  {
    newValue += i.name +"\\r\\n";
  }
  textBox1.Text = newValue;
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
