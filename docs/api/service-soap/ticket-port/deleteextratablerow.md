---
title: cs_soap_ports_ticket_deleteextratablerow
description: Services SOAP interface ticket reference deleteExtraTableRow
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# deleteExtraTableRow

## Description

Deletes a row from an extra table if the row exists.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| tableId | A valid table ID |
| rowId | A valid row ID |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0"))
{
  errorCode = t.deleteExtraTableRows(sessionKey,"10",rowId);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
