---
title: cs_soap_ports_ticket_addmessage
description: Services SOAP interface ticket reference  addMessage
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# addMessage

## Description

> [!CAUTION]
> Deprecated, see [addMessage3][2] instead.

Adds a message to an existing ticket. If you are creating a new ticket, you need to also call this to add a message to the ticket. If you have file attachments you wish to add to this message, you have to call `addAttachment()` for each of these.

When making a new ticket, a New Ticket notification is sent, so you should normally not send a notification for the `addMessage()` call. This is controlled by the `sendNotification` parameter.

> [!NOTE]
> `addMessage` will not affect `ticket.status`, this can be set using `setTicket`.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| messageBody | The text contained in the body of this message |
| ticketId | The ID of the ticket to attach this message to. |
| sLevel | Security level. 1=Internal, 2=External |
| attachmentIds | A list of the iDs to the attachments linked to this message. |
| sendNotification | A boolean indicating if you wish that the owner is notified that a message has been added to the ticket. |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| messageID | A notification key to be used in `getUserNotfications()` etc. |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0"))
{
  string[] attachmentIds = new string\[1\];
  attachmentIds[0]="62";
  string messageId;
  string error = ticketService.addMessage(sessionKey,
   "her er en meldingstekst\\n\\nmvh\\njulenissen",
   "1602",         //ticketId
   "1",            //internal message  
   attachmentIds, 
   true,           //send notification
   out messageId);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
[2]: addMessage3.md
