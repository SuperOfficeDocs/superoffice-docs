---
title: cs_soap_ports_ticket_setcustomer
description: Services SOAP interface ticket reference setCustomer
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# setCustomer

## Description

This method will set/change one or more values on the specified customer. The values are sent as an array of **ValuePairStruct**, which contain one field and one value. Note that all fields have to be valid, else nothing will be stored.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| customerId | The id of the customer to change |
| customerValues | An array of **ValuePairStruct** consisting of a field and a value. The field indicates which customer field you want to set and its value. It is important to only use legal fields, else the whole method will fail. To set an extra field on a customer, use `x_<nr>` where nr = number of the extra fields. Use the method `getExtraFields` to find available extra fields. |

**Other legal fields:**

* name
* display\_name
* firstname
* lastname
* phone
* cellphone
* note
* password
* username
* email (will add the email address)
* language
* company (id of company and -1 to set none)

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "banken", out sessionKey);
string customerId = "10"; // Hard coded customer id for example

if(errorCode.Equals("0"))
{
  ticket.ValuePairStruct[] customerValues = new ticket.ValuePairStruct[2];
  customerValues[0] = new ticket.ValuePairStruct();
  customerValues[0].field = "name";
  customerValues[0].value = "Johnny X";
  customerValues[1] = new customer.ValuePairStruct();
  customerValues[1].field = "company";
  customerValues[1].value = "23";
  string ret = ticketService.setCustomer(sessionKey, customerId, customerValues);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
