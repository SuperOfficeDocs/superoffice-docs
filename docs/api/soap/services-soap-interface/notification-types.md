---
title: services_soap_notifications
description: Services SOAP interface notifications
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

The following is a list of all types of notification and their numerical representation:

| Name | Value | Description |
|---|---|---|
| NewTicket | 0x0001 | You have a new request |
| NewTicketMessage | 0x0002 | You have a new message on a request |
| TicketAlert | 0x0004 | One of your requests has been escalated |
| TicketActivated | 0x0008 | One of your requests has been activated |
| ChatAlert | 0x0010 | There is a customer in the chat queue |
| ActiveTickets | 0x0020 | Not used for this purpose |
| TicketTakeOver | 0x0040 | Your request has been taken over |
| ChatMessageAlert | 0x0080 | You have a new chat message |
| ChatSessionTransfered | 0x0100 | Somebody transferred a chat session to you |
