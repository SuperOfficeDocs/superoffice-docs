---
title: cs_soap_ports_ticket_getattachment
description: Services SOAP interface ticket reference getAttachment
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getAttachment

## Description

Retrieves an attachment. Attachment can be linked to various types of eJournal entities, for example, messages, faq entries, and reply templates. The client stub should be able to decode the binary data automatically. If not you should base64 decode the returned byte stream.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |, or empty if the attachment is linked to a public FAQ entry.
| attachmentId | ID of the attachment to retrieve. |
| attachmentKey | The unique key identifying this attachment, for security reasons |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| attachmentName | The file name of the attachment |
| contentType | The mime like content type of the file. |
| data | The attachment binary data. |

[!include[ALT](../includes/attachment-content-types.md)]

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string attachmentId = "34";
string attachmentName;
string contentType;
string sessionKey;

ticketService.login("Kai","Akk", out sessionKey);
string[] messageFields = new string[0];
ticketService.ResultStruct[] messageResult;
ticketService.AttachmentInfoStruct[] attachments;
ticketService.getMessage(sessionKey,"12324",messageFields, out messageResult, out attachmentInfoStruct);

System.Byte[] data;

string res = ticketService.getAttachment(sessionKey, attachments[0].attachmentId, attachments[0].attachmentKey, out attachmentName, out contentType, out data);
if(res == "0")
{
  //...StoreAttachmentToDisk...
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
