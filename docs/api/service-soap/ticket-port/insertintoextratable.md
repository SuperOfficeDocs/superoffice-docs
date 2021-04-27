---
title: cs_soap_ports_ticket_insertintoextratable
description: Services SOAP interface ticket reference insertIntoExtraTable
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# insertIntoExtraTable

## Description

Inserts or updates a row in an extra table.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| tableId | A valid table ID |
| rowId | A valid row ID, or -1 for inserts. |
| Column values | An array of each column and new value for the row<br>Name (ID of the column)<br>Value |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| owId | The row ID of the inserted or updated row. |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0"))
{
  ticket.ValuePairStruct[] values = new ticket.ValuePairStruct[1];

  values[0] = new ticket.ValuePairStruct();
  values[0].field = "27";   //extra field id
  values[0].value = "123";  //new value

  string rowId = "-1";

  errorCode = t.insertIntoExtraTable(sessionKey,
    "10",
    ref rowId, // rowId will be updated with the new ID
    values);

}
```

<!-- Referenced links -->
[1]: ../error-codes.md
