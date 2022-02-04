---
title: findCompanies
uid: cs_soap_ports_ticket_findcompanies
description: Services SOAP interface ticket reference findCompanies
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# findCompanies

## Description

This method will search for companies and return information about the companies which match the search criteria. If you specify an illegal search criterion (an invalid field or matching operator) an error message will be returned.

If you specify an illegal search field, the field will be dropped in the output.

**Valid search criteria and search fields:**

* contact.id
* contact.name
* contact.note
* contact.phone
* contact.fax
* contact.adr
* contact.our\_contact
* contact.priority\_id
* contact.domain\_name (only as search field, returns comma-separated list)

**Valid operator for search criteria:**

* OperatorContains
* OperatorBeginsWith
* OperatorEquals
* OperatorLt (only for numerics)
* OperatorGt (only for numerics)

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| searchCriteria | A list of criteria (field, operator, value) |
| searchFields | A list of fields that you want to have returned. |
| maxRows | Maximum number of rows returned. |
| orderBy | (not in use) |
| ascending | (not in use) |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| searchResult | A two-dimensional array of field/value/type structs. |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("tommy", "myPwd", out sessionKey);

if (errorCode.Equals("0")
{
  ticket.CriteriaStruct[] searchCriteria = new searchCriteria[1];

  searchCriteria[0].field = "contact.id";
  searchCriteria[0].op    = "OperatorEquals";
  searchCriteria[0].value = "23";

  string[] fields = new string[2];
  fields[0] = "contact.id";
  fields[1] = "contact.name";

  ticket.ResultStruct[][] result;

  if(ticketService.findCompanies(sessionKey, searchCriteria, fields, "100", "customer.id", true, out result)== "0");
  {
    foreach(i1 ResultStruct[] in result)
    {
      cout << "Row\n";
      foreach(i2 ResultStruct in i1)
      {
        cout << "Field:" << i2.field << endl;
        cout << "Value:" << i2.value << endl;
      }
    }
  }
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
