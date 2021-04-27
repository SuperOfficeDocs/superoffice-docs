---
title: cs_soap_ports_ticket_getmessage
description: Services SOAP interface ticket reference getMessage
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getMessage

## Description

Gets data contained in a single message. Info about the attachments that are linked to this message is also returned, and can be retrieved by `getAttachment()`.

Valid data field to retrieve:

* message.id
* message.body
* message.header
* message.md\_body
* message.created\_at
* message.author
* message.slevel (1=internal, 2=external)

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
|  messageId - The message ID |
| messageField | A list of the fields you wish to retrieve. |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| messageResult | An array containing these fields: field, type, value |
| attachmentInfo | A list of all attachments on this message |

| attachmentInfo | Description |
|---|---|
| attachmentId | The ID |
| attachmentName | The file name of the attachment |
| contentType | The content type ("text/plain", "text/html" etc) |
| attachmentKey | A key needed to retrieve the attachment. |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0")
{
  string[] messageFields = new string[1];
  messageFields[0] = "message.body";
  ticket.ResultStruct[] messageInfo;
  ticket.AttachmentInfoStruct[] attachments;
  getMessage(sessionKey,"23",messageFields, out messageInfo, out attachments);

  foreach(ticket.ResultStruct i in messageInfo)
  {
    cout << "field:" << i.field << " value:" << i.value << endl;
  }
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
