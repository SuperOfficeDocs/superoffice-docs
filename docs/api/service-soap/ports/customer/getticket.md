---
title: getTicket
uid: cs_soap_ports_customer_getticket
description: Services SOAP interface port reference - customer getTicket
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getTicket

## Description

This method is used to retrieve one request (ticket). You are only allowed to see request which has security level external. You have to specify which fields/information (as strings) you want to get for this request. All valid fields are listed below.

The fields are returned as an array of `ResultStruct`. Also, all external message IDs are returned for this request. Use `getMessage()` to retrieve information about one specific message.

A **ResultStruct** consists of a *field* indicating which ticket fields this is, a *value* indicating the value of the field, and a *type* indicating the [type of the field][2]. Normally the sequence of the ResultStructs will follow the same sequence as specified in the `ticketFields` parameter. The only exception is if you enter an illegal ticket field, this will be skipped, and thus the number of ResultStructs will be less than the number specified in `ticketFields`. You should therefore always check the *field* member to be sure.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| ticketId | The ID of the request to retrieve |
| ticketFields | An array of strings indicating all fields to be retrieved for this request. If you specify an illegal field, it will be ignored. |

**Valid ticketFields fields:**

* ticket.id
* ticket.title
* ticket.created_at
* ticket.category
* ticket.status
* ticket.replied_at
* ticket.closed_at
* ticket.priority
* ticket.read_by_customer
* ticket.has_attachment
* ticket_last_changed
* ticket.x_[extra field ID] - Extra fields are also valid on the form

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| ticketResult | An array of *ResultStruct* containing all the requested ticket fields. All fields are formatted as strings, so you have to do any conversion yourself. |
| messageIds | An array of integers of all external messages connected to this request.|

## Example

```csharp
customer.customerService custService = new customer.customerService();
string sessionKey;
string errorCode = custService.login("johndoe","pw",out sessionKey);

if(errorCode.Equals("0"))
{
  // The fields we want to get
  string[] ticketFields = new string[3];
  ticketFields[0] = "ticket.title";
  ticketFields[1] = "ticket.created_at";
  ticketFields[2] = "ticket.category";

  // The return values go here
  customer.ResultStruct[] ticketResult;
  string[] messageIds;

  // Get request 1012
  errorCode = custService.getTicket(sessionKey, "1012", ticketFields, out ticketResult, out messageIds);
  if (errorCode.Equals("0"))
  {
    foreach (string i in messageIds)
      //Here *i* is running through all message IDs
      if (ticketFields[0].field.Equals("ticket.title"))
        //Here ticketFields[0].value is the title of the request
  }
  else
    string errorMsg = custService.getErrorMessage(sessionKey);
}
else
{
  // Could not log in customer
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
[2]: ../../field-types.md
