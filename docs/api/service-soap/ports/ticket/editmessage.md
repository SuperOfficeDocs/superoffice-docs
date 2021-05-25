---
title: editMessage
uid: cs_soap_ports_ticket_editmessage
description: Services SOAP interface ticket reference editMessage
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# editMessage

## Description

Edits an existing message by setting values.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| messageId | The id of the message to edit |
|  Values | Array of name/value values. See MessageLib::setValue for possible values to set |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| messageID | A notification key to be used in `getUserNotfications()` and similar |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0"))
{
  string messageId = 10;
  ticket.ValuePairStruct[] values = new ticket.ValuePairStruct[2];

  values[0] = new ticket.ValuePairStruct();
  values[0].field = "body";   // field id, can be extra field
  values[0].value = "denne meldingen er endret fra SOAP";  //new value
  values[1].field = "x_field";   // field id, can be extra field
  values[1].value = "1032";  //new value 

  string error = ticketService.editMessage(sessionKey, messageId, values, out messageId);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
