---
title: cs_soap_ports_customer_getattachment
description: Services SOAP interface port reference - customer getAttachment
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getAttachment

## Description

Retrieves an attachment either linked to a message or an FAQ entry. For attachment attached to public entries, you do not need a session key.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key, or empty if the attachment Ds linked to a public FAQ entry. |
| attachmentId | ID of the attachment to retrieve. |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [Seelist of codes][1] |
| attacmentName | The file name of the attachment |
| contentType | The mime-like content type of the file. |

[!include[ALT](./includes/attachment-content-types.md)]

## Example

```csharp
customer.customerService custService = new customer.customerService();
string sessionKey;

if(custService.login("test","test", out sessionKey) == "0")
{
  string attachmentId = "34";
  string attachmentName;
  string contentType;
  string data;
  string res = custService.getAttachment(sessionKey, attachmentId, out attachmentName, out contentType, out data);
  byte[] newData = System.Convert.FromBase64String(data);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
