---
title: cs_soap_ports_customer_getpriorities
description: Services SOAP interface port reference - customer getPriorities
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getPriorities

## Description

Gets all the available external priorities. The lowest ordered priority will be first in the array.

## In parameters

| Parameter | Description |
|---|---|
 sessionKey | A valid session key |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| priorities | A sorted array of *PriorityStruct* with lowest sortOrder first. |

**PriorityStruct elements:**

* id: internal ID of the priority
* name: name of the priority
* sortOrder: Sort order number, where a higher number indicated higher priority.

## Example

```csharp
string sessionKey;

customer.customerService custService = new customer.customerService();

if(custService.login("test","test",out sessionKey)=="0")
{
  customer.PriorityStruct[] priorities;
  custService.getPriorities(sessionKey, out priorities);
  string newValue="";
  foreach(customer.PriorityStruct i in priorities)
  {
    newValue += i.name +"\r\n";
  }
  textBox1.Text = newValue;
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md

<!-- Referenced links -->
[1]: ../../error-codes.md
