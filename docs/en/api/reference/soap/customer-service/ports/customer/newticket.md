---
uid: cs-soap-ports-customer- newticket
title: newTicket
description: Services SOAP interface port reference - customer newTicket
keywords: customer port, newTicket method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/customer/newticket
---

# newTicket

## Description

This method will create a new request/ticket with the customer as the author of the request. You can set various information about the request. To set any external extra fields, you use an array of **ValuePairStruct**. The field should contain the name of the extra field, which is `x_<nr>`, where nr = number of the extra field. User calls **getExtraFields()** to find this name. The value should contain the value of the extra field (and is always sent as a string). The method returns the id of the newly created request. You use this id to add messages with the **addMessage()** method.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| title | The title of the request |
| sLevel | The security level of the request. 1 = internal, 2 = external |
| categoryId | The category id of the request. Only external categories are allowed. Use `getCategory()` to find the id of the category |
| priorityId | The ID of the priority for this request. Only external priorities are allowed. Use `getPriorities()` to find the id of the priority. If you want the system to use its internal rules for deciding the priority, specify -1 for this field |
| extraField | An array of **ValuePairStruct** specifying any external extra values you want to set for this request. The field member should contain the name of the extra field, and the value member contains the value/data to set (as a string). |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| ticketId | The ID of the newly created request |

## Example

```csharp
customer.customerService custService = new customer.customerService();
customer.ValuePairStruct[] extraFields = new customer.ValuePairStruct[0]; //We do not want any extra fields set
string errorCode = custService.login("johndoe","pw",out sessionKey);

if(errorCode.Equals("0"))
{
  string ticketId;
  string retVal = custService.newTicket(sessionKey, "Server error", "2", "23", "-1", extraFields, out ticketId);

  if (retVal.Equals("0"))
    // ticketId now contains the id of the new request
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md

<!-- Referenced links -->
