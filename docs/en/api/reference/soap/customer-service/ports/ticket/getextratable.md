---
uid: cs-soap-ports-ticket-getextratable
title: getExtraTable
description: Services SOAP interface ticket reference getExtraTable
keywords: ticket port, getExtraTable method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/ticket/getextratable
---

# getExtraTable

## Description

Same as [getExtraTables][2], but returns only one extra table.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key. |
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
