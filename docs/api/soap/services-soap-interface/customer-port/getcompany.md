---
title: cs_soap_ports_customer_getcompany
description: Services SOAP interface port reference - customer getCompany
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getCompany

## Description

Retrieve information about the company that this user is connected to.

You specify which fields you wish to retrieve in the `companyFields` field. If one or more of the fields are invalid no fields are returned. If the customer is not connected to a company, the fields will be empty.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| customerFields | A list of the fields you wish to retrieve. You can specify standard fields or extra fields. Extra fields are given on the form "company.x_2" where the number is the ID on the extra field. |

**Valid customerFields fields:**

* company.id
* company.name
* company.address
* company.extTable
* company.extKey
* company.note
* company.phone
* company.fax
* company.primContact

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| companyResult | An array of the fields queried. [See getTicket()][2]. |

## Example

```csharp
string sessionKey;
customer.customerService custService = new customer.customerService();

if(custService.login("test","test", out sessionKey) =="0")
{
  string[] companyFields = new string[4];
  companyFields[0]="company.name";
  companyFields[1]="company.phone";
  companyFields[2]=" company.note";
  customer.ResultStruct[] companyResult;
  string res = custService.getCompany(sessionKey, companyFields, out companyResult);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
[2]: getticket.md
