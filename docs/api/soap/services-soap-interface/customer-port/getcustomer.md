---
title: cs_soap_ports_customer_getcustomer
description: Services SOAP interface port reference - customer getCustomer
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getCustomer

## Description

Retrieve information about a customer. You specify which fields you wish to retrieve in the `customerField` field. If one or more of the fields are invalid no fields are returned.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| customerFields | A list of the fields you wish to retrieve. You can specify standard fields or extra fields. Extra fields are given on the form "customer.x\_2"  |where the number is the ID on the extra field. |

**Valid customerFields fields:**

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

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| customerResult | An array of the fields queried. [See getTicket()][2] |
| customerEmail | An array of all email addresses registered on this customer. |

## Example

```csharp
string sessionKey;
customer.customerService custService = new customer.customerService();

if(custService.login("test","test", out sessionKey) =="0")
{
  string[] customerFields = new string[4];
  customerFields[0]="customer.name";
  customerFields[1]="customer.phone";
  customerFields[2]="customer.note";
  customerFields[3]="customer.cellphone";
  customer.ResultStruct[] customerResult;
  string [] customerEmail;
  string res = custService.getCustomer(sessionKey, customerFields, out customerResult, out customerEmail);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
[2]: getticket.md
