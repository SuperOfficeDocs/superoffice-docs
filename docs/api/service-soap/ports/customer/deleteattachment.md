---
title: deleteAttachment
uid: cs_soap_ports_customer_deleteattachment
description: Services SOAP interface port reference - customer deleteAttachment
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# deleteAttachment

## Description

Deletes an attachment. Only attachments not attached to any other entities in Service can be deleted. That way only stray attachments can be deleted, hence we don’t need to verify the validity of the contact.

## In parameters

| Parameter | Description |
|---|---|

| attachmentId | The ID of the attachment |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |

## Example

```csharp
string sessionKey;

customer.customerService custService = new customer.customerService();

if(custService.login("test","test", out sessionKey) == "0")
{
  string ret = custService.deleteAttachment("10");
  if(ret == "0")
    cout << "Hip hurray";
  else
    cout << "Oh no";
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
