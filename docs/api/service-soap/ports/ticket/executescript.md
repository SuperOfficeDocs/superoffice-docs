---
title: cs_soap_ports_ticket_executeScript
description: Services SOAP interface ticket reference 
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# executeScript

## Description

Execute a CRMScript with parameters.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| includeId | The include ID text. |
| parameters | Array of name/value pairs, available in the script via getVariable("varName"). |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| script result | Result from the script execution. |

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
  values[0].field = "var1Key";   // variable name
  values[0].value = "var1Value";  //variable value
  values[1].field = "var2Key";   // variable name
  values[1].value = "var2Value";  //variable value

  string error = ticketService.executeScript(sessionKey, includeId, values, out scriptResult);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
