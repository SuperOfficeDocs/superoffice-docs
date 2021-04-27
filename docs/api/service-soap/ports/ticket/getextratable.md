---
title: cs_soap_ports_ticket_getextratable
description: Services SOAP interface ticket reference getExtraTable
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getExtraTable

## Description

Same as [getExtraTables][2], but returns only one extra table.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |.
| tableId | The ID of the table you want to retrieve |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| extraTables | An array of all extra tables: id, name, fields (array) |
| id | |
| name | |
| datatype | [See field types][3] |
| flags | see description |

## Example

```csharp
string sessionKey;
ticket.ticketService ticketService = new ticket.ticketService();

if(ticketService.login("test","test", out sessionKey) == "0")
{
  ticket.ExtraTablesStruct extraTable;
  string res = ticketService.getExtra(sessionKey, "1" out extraTable);
  if(res == "0")
  {
    //...doStuffWithExtraTables...
  }
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
[2]: getextratables.md
[3]: ../../field-types.md
