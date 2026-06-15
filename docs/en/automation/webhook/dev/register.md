---
uid: webhook-api-register
title: Register a webhook
description: How to register a webhook using the SuperOffice REST API.
keywords: automation, webhook, register
author: SuperOffice Product and Engineering
date: 06.15.2026
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/automation/webhook/register
language: en
---

# Register a webhook

Send the following request to register a webhook:

```json
POST /api/v1/Webhook HTTP/1.1
Content-Type: application/json

{
  "Name": "Tonys Contact Handler",
  "Events": [
        "contact.created",
        "contact.changed",
        "contact.deleted"
    ],
  "TargetUrl": "https://www.myserver.com/superoffice/webhookhandler",
  "Secret": "Something Super Secret",
  "State": "Active",
  "Type": "webhook"
}
```

This will register the webhook, and check that the `TargetUrl` responds to a test POST. The  `TargetUrl` must:

* be HTTPS
* have a valid TLS certificate.
* respond 200 OK when it receives a POST with a test event.

When the event(s) happen (`contact.changed` for example), then the target URL is notified by HTTP POST using a message like the one shown here:

```json
{
  "EventId": "8337ae4a-1dd6-40fd-8dc7-a050664a0af7",
  "Timestamp": "2018-04-24T07:50:50.6812131Z",
  "Changes": [
    "contact_id",
    "associate_id",
    "department",
    "updated_associate_id",
    "updated",
    "updatedCount"
  ],
  "Event": "contact.changed",
  "PrimaryKey": 994863,
  "Entity": "contact",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 316,
  "WebhookName":"Name you provided"
}
```

## Related content

* [Webhooks panel in Settings and maintenance][1] - create and manage webhooks without writing code

<!-- Referenced links -->
[1]: ../admin/index.md
