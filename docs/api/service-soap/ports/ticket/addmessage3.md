---
title: cs_soap_ports_ticket_addmessage3
description: Services SOAP interface ticket reference  addMessage3
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# addMessage3

## Description

Adds a message to an existing ticket. If you are creating a new ticket, you need to also call this to add a message to the ticket. If you have file attachments you wish to add to this message, you have to call `addAttachment()` for each of these.

If `replyTemplateId > 0`, then the chosen reply template body will be inserted as the body. If the body parameter is not empty, then this body will be inserted into the parser as `%messsage.body%` and `%message.bodyHtml%` (newlines will be converted to `<br> in HTML version). If the language module is installed, then the reply template will be chosen with the customer’s language.

The complete body will be sent by email to the chosen recipients. Illegal email addresses will be ignored.

When making a new ticket, a New Ticket notification is sent, so you should normally not send a notification for the `addMessage()` call. This is controlled by the `sendNotification` parameter.

> [!NOTE]
> `addMessage3` will not affect `ticket.status`, this can be set using `setTicket`.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| messageBody | The message body text. |
| htmlMessageBody | The HTML message body version. |
| replyTemplateId | The id of the reply template to use as body. |
| ticketId | The ID of the ticket to attach this message to. |
| sLevel | Security level. 1=Internal, 2=External |
| attachmentIds | A list of the ids to the attachments linked to this message. |
| sendNotification | A boolean indicating if you wish that the owner is notified that a message has been added to the ticket. |
| To | Array of  "To:" recipients. |
| Cc | Array of "Cc:" recipients. |
| Bcc | Array of "Bcc:" recipients. |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| messageID | A notification key to be used in `getUserNotfications()` and similar |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();

string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);
string replyTemplateId = "10"; // hard coded id of template
string [] to = "[hjelms@ejournal.no](mailto:hjelms@ejournal.no)";
string [] cc;
string [] bcc;

if (errorCode.Equals("0"))
{
  string[] attachmentIds = new string[1];
  attachmentIds[0]="62";
  string messageId;
  string error = ticketService.addMessage3(sessionKey,
   "",             // Empty body
   replyTemplateId,
   "1602",         //ticketId
   "1",            //internal message  
   attachmentIds, 
   true,           //send notification
   to,
   cc,
   bcc,
   out messageId);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
