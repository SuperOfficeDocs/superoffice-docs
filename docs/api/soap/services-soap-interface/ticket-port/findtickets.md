---
title: cs_soap_ports_ticket_findtickets
description: Services SOAP interface ticket reference findTickets
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# findTickets

## Description

This method will search for tickets/requests and return information about the tickets which match the search criteria.

**Valid fields for search criteria and search fields:**

* ticket.id
* ticket.title
* ticket.created\_at
* ticket.category
* ticket.status
* ticket.replied\_at
* ticket.closed\_at
* ticket.priority
* ticket.read\_by\_customer
* ticket.has\_attachment
* ticket.last\_changed
* ticket.author
* ticket.created\_by
* ticket.owned\_by
* customer.id (note that this only will match the primary customer)
* customer.firstname
* customer.lastname
* and any extra field.

**Valid operator for search criteria:**

* OperatorContains
* OperatorBeginsWith
* OperatorEquals
* OperatorGt
* OperatorLt
* OperatorGte
* OperatorLte
* OperatorNotEqualsOperatorIn (Only valid for integer/relation fields. Example value: 1,2-4,8-10)
* OperatorNotIn

## In parameters

| Parameter | Description |
|---|---|
| sessionKey - A valid sessionKey |
| searchCriteria | A list of criteria (field, operator, value) |
| searchFields | A list of fields that you want to have returned. |
| maxRows | Maximum number of rows returned. |
| orderBy | which field you wish to order the returned data by. |
| ascending | set to true if you wish that the returned data is ordered ascending, false if you want them descending. |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| searchResult | A two-dimensional array of field/value/type structs. |

## Example

```csharp
ticket.ticketService ticketService = new * ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("tommy", "myPwd", out sessionKey);

if (errorCode.Equals("0")
{

  ticket.CriteriaStruct[] searchCriteria = new searchCriteria[1];

  searchCriteria[0].field = "ticket.id";
  searchCriteria[0].op    = "OperatorLt";
  searchCriteria[0].value = "10";

  string[] fields = new string[2];
  fields[0] = "ticket.id";
  fields[1] = "ticket.title";

  ticket.ResultStruct[][] result;

  if(ticketService.findTickets(sessionKey, searchCriteria, fields, "100", "ticket.id",true, out result)== "0");
  {
    foreach(i1 ResultStruct[] in result)
    {
      cout << "Row\\n";
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
[1]: ../error-codes.md
