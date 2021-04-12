---
# Mandatory fields.
title: webhook_notification
description: Webhook notification
author: Tony Yates
so.date: 04.06.2018
keywords:
so.topic: reference             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Webhook notification

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
| Person | [Person table][4] |
| Project | [Project table][5] |
| ProjectMember | [ProjectMember table][6] |
| Sale | [Sale table][7] |
| SaleStakeholder | [SaleStakeholder table][8] |

## WebhookPayload headers

| Header name | Description |
| X-SuperOffice-Event | The event name (contact.created, project.changed) |
| X-SuperOffice-EventId | A GUID that uniquely identifies this event. |
| X-SuperOffice-Retry | The number of retries this webhook has been tried to be sent. |
| X-SuperOffice-Signature | The hash/base64 encoded secret. |

## Failed Webhook notification attempts

There are 3 attempts to send a webhook payload during a single cycle. If the first one fails, then the next attempt is delayed by 1 second. If the second one fails, then the third attempt is delayed by 4 seconds. If the third attempt fails, it is removed from this cycle and sent to the back of the queue. All active webhook payloads have a total of 9 consecutive attempts before the state is set to TooManyErrors(3). After that, it's up to the receiver to manage the webhook state, reset the state to Active (1), to begin sending webhook payloads again.

The EventID is the same for each attempt, however, if the HTTP request fails to receive a 200 response for 3 attempts, then the event is discarded, and the webhook `consecutive_errors` count is incremented. When the next consecutive attempt is sent, it will be a new EventID.

<!-- Referenced links -->
[1]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/tables/appointment.md
[2]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/tables/associate.md
[3]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/tables/contact.md
[4]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/tables/person.md
[5]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/tables/project.md
[6]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/tables/projectmember.md
[7]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/tables/sale.md
[8]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/tables/salestakeholder.md
