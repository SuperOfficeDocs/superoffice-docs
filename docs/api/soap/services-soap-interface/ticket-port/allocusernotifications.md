---
title: cs_soap_ports_ticket_allocusernotifications
description: Services SOAP interface ticket reference 
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# allocUserNotifications

## Description

To avoid that several clients receive user notifications (new request, new chat message, new message on existing request, and so on) a subscription system is introduced. If you supply a valid session key to this method, you will receive a notification key that you need to supply when requesting new notifications. This key will only be valid for 5 minutes and is renewed every time it is used.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| source | A string identifying your client ("MySoapClient") |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| notificationKey | A notification key to be used in `getUserNotfications()` and similar |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0")
{
  string notifyKey;
  allocUserNotifications(sessionKey, "MyClient",out notifyKey);
  ticket.NotificationStruct[] notifications;
  getUserNotfications(sessionKey, notifyKey, out notifications);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
