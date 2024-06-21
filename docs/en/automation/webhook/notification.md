---
uid: webhook_receiving_notification
title: Receiving notifications
description: Webhook notifications
author: AnthonyYates
date: 04.06.2018
keywords:
topic: reference
# envir:
# client:
---

# Receiving notifications

Now that webhooks have been created and saved in SuperOffice, notifications can be sent out when an event occurs. A webhook notification is referred to as a `WebhookPayload`, and contains the following properties:

| Property Name | Description |
|---|---|
| EventId | A GUID that uniquely identifies this event. |
| Timestamp | The datetime when the event occurred. |
| Changes | An array of fields that are connected to the change. |
| Event | The name of the event. |
| PrimaryKey | The entity identity that was affected |
| Entity | The type of entity that was affected, activity, associate, contact, person |
| ContextIdentifier | Customer ID for Online users: "Cust1234". Not used for On-site installations. |
| ChangedByAssociateId | Associate ID of the user that triggered the event. |
| WebhookName | The given name of the webhook. |

A webhook payload for the event `contact.changed` is send as the following JSON message:

```json
UserAgent: NetServer-Webhook/8.2.123.456X-SuperOffice-Signature: abcXyz123==X-SuperOffice-Event: contact.changedX-SuperOffice-EventId: 88f91933-edce-4c1a-8ded-ade8e2f72434{
    "EventId":"88f91933-edce-4c1a-8ded-ade8e2f72434",
    "Timestamp":"2018-04-05T08:28:01.5732501Z",
    "Changes":["contact_id","updated_associate_id","soundEx","updated","name"],
    "Event":"contact.changed",
    "PrimaryKey":18,
    "Entity":"contact",
    "ContextIdentifier":"Cust54321",
    "ChangedByAssociateId":5,
    "WebhookName":"Tonys Contact Handler"
}
```

Notifications are sent out in a fire-and-forget fashion and do not expect a response to these POST requests. There is no way to prevent changes or interrupt the normal workflow of SuperOffice.

> [!NOTE]
> The event name, event ID, and signature are sent as HTTP headers, to help the recipient route and filter the notification without having to parse the body.

## Changes field names

Fields names that appear in a notification `Changes` property are the names of the fields as they appear in the database.

| Entity name | Field source |
|---|---|
| Activity | [Appointment table][1] |
| Associate | [Associate table][2] |
| Contact | [Contact table][3] |
| Chat | [ChatSession table][10] |
| Document | [Document table][12] |
| Person | [Person table][4] |
| Project | [Project table][5] |
| ProjectMember | [ProjectMember table][6] |
| Quote | [Quote table][11] |
| Sale | [Sale table][7] |
| SaleStakeholder | [SaleStakeholder table][8] |
| Ticket | [Ticket table][9] |

## WebhookPayload headers

| Header name | Description |
|-------------|-------------|
| X-SuperOffice-Event | The event name (contact.created, project.changed) |
| X-SuperOffice-EventId | A GUID that uniquely identifies this event. |
| X-SuperOffice-Retry | The number of retries this webhook has been tried to be sent. |
| X-SuperOffice-Signature | The hash/base64 encoded secret. |

## Error Handling for Webhooks

There are three attempts to send a webhook payload during a single cycle. If the first one fails, the next attempt is delayed by 1 second. If the second attempt fails, the third attempt is delayed by 4 seconds. If the third attempt fails, it is removed from this cycle and sent to the back of the queue. All active webhook payloads are given a total of 9 consecutive attempts before the state is changed to `TooManyErrors (3)`.

If the HTTP request fails to receive a 200 response for three attempts, the event associated with those attempts is discarded, and the webhook's `consecutive_errors` count is incremented. The next attempt made will feature a new `EventID`.

### Email Notification on Error

In the event that the `EmailErrors` property is set, when a webhook state is set to `TooManyErrors`, an automatic email will be dispatched to the specified email address. This email will detail the error, the associated `EventID`, `Name` and more details.

The `EventID` remains consistent for each attempt, facilitating accurate tracking and management of webhook events. However, if there are three consecutive failed attempts, the event is discarded, and the next attempt will be associated with a new `EventID`.

Following `TooManyErrors` status, it is the responsibility of the receiver to manage the webhook state. The receiver can reset the state to `Active (1)` to resume the sending of webhook payloads. The `EmailErrors` notification system is designed to promptly inform the receiver of any critical issues that might prevent successful data delivery.



<!-- Referenced links -->
[1]: ../../database/tables/appointment.md
[2]: ../../database/tables/associate.md
[3]: ../../database/tables/contact.md
[4]: ../../database/tables/person.md
[5]: ../../database/tables/project.md
[6]: ../../database/tables/projectmember.md
[7]: ../../database/tables/sale.md
[8]: ../../database/tables/salestakeholder.md
[9]: ../../database/tables/ticket.md
[10]: ../../database/tables/chat-session.md
[11]: ../../database/tables/quote.md
[12]: ../../database/tables/document.md