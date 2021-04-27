---
title: cs_soap_ports_ticket_addattachment
description: Services SOAP interface ticket reference  addAttachment
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# addAttachment

## Description

Adds an attachment to Service. This attachment can be used to attach to a message, faq entry, reply template, and so on. The binary data should be automatically base64 encoded by your client SOAP stack, but if not you have to do this manually.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| attachmentName | File name of the attachment |
| contentType | The content type, for example, "application/octet-stream", "image/gif" |
| data | binary data |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| attachmentId | The ID of the newly inserted attachment |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0"))
{
  System.IO.FileStream infile = new System.IO.FileStream("DivFix.exe", System.IO.FileMode.Open,System.IO.FileAccess.Read);
  byte[] buffer = new byte[infile.Length];
  int read = infile.Read(buffer,0,(int)infile.Length);
  infile.Close();
  string attachmentId;

  ticketService.addAttachment(sessionKey, infile.Name, "application/octet-stream", buffer, out attachmentId);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
