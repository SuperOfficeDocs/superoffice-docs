---
title: cs_soap_ports_ticket_getcustomer
description: Services SOAP interface ticket reference getCustomer
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getCustomer

## Description

Retrieve information about a customer. You specify which fields you wish to retrieve in the `customerFields` field. If one or more of the fields are invalid no fields are returned.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| customerId | ID of the customer to retrieve |
| customerFields | A list of the fields you wish to retrieve. You can specify standard fields or extra fields. Extra fields are given on the form "customer.x\_2" where the number is the ID on the extra field. |

**Valid standard fields:**

* customer.id
* customer.name
* customer.firstname
* customer.lastname
* customer.phone
* customer.cellphone
* customer.note
* customer.language
* customer.username
* customer.extTable
* customer.extKey
* customer.company
* customer.password

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| customerResult | An array of the fields queried. See `getTicket()` for reference. |
| customerEmail | An array of all email addresses registered on this customer. |

## Example

```csharp
string sessionKey;
ticket.ticketService ticketService = new ticket.ticketService();

if(ticketService.login("test","test", out sessionKey) == "0")
{
  string[] customerFields = new string[4];
  customerFields[0]="customer.name";
  customerFields[1]="customer.phone";
  customerFields[2]="customer.note";
  customerFields[3]="customer.cellphone";

  ticket.ResultStruct[] customerResult;
  string [] customerEmail;

  string res = ticketService.getCustomer(sessionKey, "22", customerFields, out customerResult, out customerEmail);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
