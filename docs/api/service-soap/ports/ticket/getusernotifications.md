---
title: getUserNotifications
uid: cs_soap_ports_ticket_getusernotifications
description: Services SOAP interface ticket reference getUserNotifications
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getUserNotifications

## Description

Will retrieve all notifications to the current user that has been generated since the last call to this method, from this or any other client application.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| notificationKey | A subscription key retrieved by the `allocUserNotification()` method |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| userNotifications | All notifications with the following fields:<br>type (of notification<br>createdBy (the ID of the user that generated this notification)<br>ticketId (the ticketId associated with this notification if any)<br>message (the text message) |

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
[1]: ../../error-codes.md
