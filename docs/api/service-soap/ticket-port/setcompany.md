---
title: cs_soap_ports_ticket_setcompany
description: Services SOAP interface ticket reference setCompany
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# setCompany

## Description

This method will set/change one or more values on the specified company. The values are sent as an array of **ValuePairStruct**, which contain one field and one value. Note that all fields have to be valid, else nothing will be stored.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| companyId | The id of the company to change |
| companyValues | An array of **ValuePairStruct** consisting of a field and a value. The field indicates which company field you want to set and its value. It is important to only use legal fields, else the whole method will fail. To set an extra field on a company, use `x_<nr>` where nr = number of the extra fields. Use the method `getExtraFields` to find available extra fields. |

**Other legal fields:**

* name
* note
* phone
* fax
* countryId
* ticketPriorityId
* ourContact
* primContact
* ourSalesContact
* domain
* department
* contactCategory
* contactBusiness

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "banken", out sessionKey);
string companyId = "10"; // Hard coded company id for example

if(errorCode.Equals("0"))
{
  ticket.ValuePairStruct[] companyValues = new ticket.ValuePairStruct[2];
  companyValues[0] = new ticket.ValuePairStruct();
  companyValues[0].field = "name";
  companyValues[0].value = "Libery Communications";
  companyValues[1] = new customer.ValuePairStruct();
  companyValues[1].field = "company";
  companyValues[1].value = "23";
  string ret = ticketService.setCompany(sessionKey, companyId, companyValues);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
