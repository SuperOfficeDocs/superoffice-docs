---
uid: cs-soap-ports-ticket-deleteextratablerow
title: deleteExtraTableRow
description: Services SOAP interface ticket reference deleteExtraTableRow
keywords: ticket port, deleteExtraTableRow method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/ticket/deleteextratablerow
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
[1]: ../../error-codes.md
