---
uid: webhook_salestakeholder_event
title: Sale stakeholder webhook events
description: Sale stakeholder events
keywords: stakeholder webhook, salestakeholder
author: SuperOffice Product and Engineering
date: 07.07.2025
content_type: reference
category: automation
topic: webhook
---

# Sale stakeholder webhook events

These webhook events are fired when `salestakeholder` rows are changed:

* `salestakeholder.created`
* `salestakeholder.changed`
* `salestakeholder.deleted`

## FieldValues for sale stakeholder events

The following fields are included in the `FieldValues` property of the webhook payload for sale stakeholder events:

* `contact_id` - ID of the contact
* `person_id` - ID of the person
* `registered` - date of the sale stakeholder registration
* `registered_associate_id` - ID of the associate who registered the sale stakeholder
* `sale_id` - ID of the sale
* `stakeholderrole_id` - ID of the stakeholder role
* `updated` - date of the last update
* `updated_associate_id` - ID of the associate who last updated the sale stakeholder

## SaleStakeholder.created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: salestakeholder.created
X-Superoffice-Eventid: 091d5259-5a48-4fe2-9fe0-9d1160e6868a
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "091d5259-5a48-4fe2-9fe0-9d1160e6868a",
  "Timestamp": "2018-04-24T08:42:19.4685066Z",
  "Changes": [
    "salestakeholder_id",
    "rank",
    "sale_id",
    "stakeholderrole_id",
    "registered",
    "updated",
    "updated_associate_id",
    "person_id",
    "comment",
    "updatedCount",
    "registered_associate_id",
    "contact_id"
  ],
  "Event": "salestakeholder.created",
  "PrimaryKey": 3579,
  "Entity": "salestakeholder",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName":"Name you provided",
  "FieldValues": {
    "contact_id": 1,
    "person_id": 4,
    "registered": "2025-05-14T16:11:02.4593434+02:00",
    "registered_associate_id": 5,
    "sale_id": 8,
    "stakeholderrole_id": 1,
    "updated": "0001-01-01T00:00:00",
    "updated_associate_id": 0
  }
}
```

## SaleStakeholder.changed

```json
{
  "EventId": "576086e3-5261-426b-a84b-26ca7f5b65e8",
  "Timestamp": "2018-04-24T08:01:15.8506935Z",
  "Changes": [
    "salestakeholder_id",
    "stakeholderrole_id",
    "updated",
    "updated_associate_id",
    "comment",
    "updatedCount"
  ],
  "Event": "salestakeholder.changed",
  "PrimaryKey": 1467783,
  "Entity": "salestakeholder",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 316,
  "WebhookName":"Name you provided",
  "FieldValues": {
    "contact_id": 1,
    "person_id": 4,
    "registered": "2025-05-14T16:11:02.4593434+02:00",
    "registered_associate_id": 5,
    "sale_id": 8,
    "stakeholderrole_id": 1,
    "updated": "0001-01-01T00:00:00",
    "updated_associate_id": 0
  }
}
```

## SaleStakeholder.deleted

```json
{
  "EventId":"88f91933-edce-4c1a-8ded-ade8e2f72434",
  "Timestamp":"2018-04-05T08:28:01.5732501Z",
    "Changes":[],
    "Values": {
      "sale_id": 4
  },
  "Event":"salestakeholder.deleted",
  "PrimaryKey":18,
  "Entity":"salestakeholder",
  "ContextIdentifier":"Cust54321",
  "ChangedByAssociateId":5,
  "WebhookName":"Name you provided",
  "FieldValues": {
    "contact_id": 1,
    "person_id": 4,
    "registered": "2025-05-14T16:11:02.4593434+02:00",
    "registered_associate_id": 5,
    "sale_id": 8,
    "stakeholderrole_id": 1,
    "updated": "0001-01-01T00:00:00",
    "updated_associate_id": 0
  }  
}
```
