---
title: cs_soap_ports_customer_addmessage
description: Services SOAP interface port reference - customer addMessage
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# addMessage

## Description

Adds a message to an existing ticket. You are only allowed to add messages to a ticket owned by the logged-in customer.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| messageBody | The text in the message. |
| ticketId | The ticket to attach the message to. |
| sLevel | Security level of the ticket. Can be:<br>1 – Internal<br>2 – Externala<br>Other values will result in an error. |
| attachmentIds | An array of the IDs of all attachments that you wish to connect to this message.<br>The ID is received from `addAttachment()`. |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| messageId  The internal ID of the new message |

## Example

```csharp
customer.customerService custService = new customer.customerService();

string sessionKey;
string ret = custService.login("test","test", out sessionKey);

if(ret == "0")
{
  string\[\] attachmentIDs = new string\[0\];
  string messageId;
  ret = custService.addMessage(sessionKey,
    "I would like more information","1201","2",
    attachmentIDs,
    out messageId);
  if(ret == "0")
    cout << messageId;
    //messageId now contains the new ID
  custService.logout(sessionKey);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
