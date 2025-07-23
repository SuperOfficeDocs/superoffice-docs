---
uid: webhook_relation_event
title: Relation events
description: Relation events
keywords: relation webhook
author: AnthonyYates
date: 5.11.2024
content_type: reference
category: automation
topic: webhook
---

# Relation events

These events are fired when Relation rows are changed:

* `relation.created`
* `relation.changed`
* `relation.deleted`

## FieldValues for relation events

The following fields are included in the `FieldValues` property of the webhook payload for relation events:

* `associate_id` - ID of the associate who created the relation
* `destination_record` - ID of the destination record
* `destination_table` - ID of the destination table
* `registered` - date of the relation registration
* `registered_associate_id` - ID of the associate who registered the relation
* `reldef_id` - ID of the relation definition
* `source_record` - ID of the source record
* `source_table` - ID of the source table
* `updated` - date of the last update
* `updated_associate_id` - ID of the associate who last updated the relation

## Relation.created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: relation.created
X-Superoffice-Eventid: e87ac619-c864-4881-89eb-07ca5521ee2c
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "abca7e30-5fd4-41d3-849a-16f51c927ecb",
  "Timestamp": "2024-11-05T11:25:24.0528404Z",
  "Changes": [
    "relation_id",
    "source_table",
    "updated",
    "reversed",
    "destination_table",
    "registered_associate_id",
    "group_idx",
    "reldef_id",
    "startDate",
    "updated_associate_id",
    "updatedCount",
    "associateId",
    "source_record",
    "relFlags",
    "registered",
    "relcomment",
    "endDate",
    "destination_record"
  ],
  "Event": "relation.created",
  "PrimaryKey": 20,
  "Entity": "relation",
  "ContextIdentifier": "Cust26759",
  "ChangedByAssociateId": 5,
  "WebhookName": "Relation Webhook",
  "FieldValues": {
    "associateId": 5,
    "destination_record": 2,
    "destination_table": 5,
    "registered": "2025-05-14T16:07:50.9437543+02:00",
    "registered_associate_id": 5,
    "reldef_id": 7,
    "source_record": 1,
    "source_table": 5,
    "updated": "0001-01-01T00:00:00",
    "updated_associate_id": 0
  }
}
```

## Relation.changed

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: relation.changed
X-Superoffice-Eventid: e87ac619-c864-4881-89eb-07ca5521ee2c
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "aeb900dd-344b-403e-a365-7a2708bc71c1",
  "Timestamp": "2024-11-05T11:26:29.6996142Z",
  "Changes": [
    "relation_id",
    "reldef_id",
    "updated_associate_id",
    "updated",
    "relcomment"
  ],
  "Event": "relation.changed",
  "PrimaryKey": 20,
  "Entity": "relation",
  "ContextIdentifier": "Cust26759",
  "ChangedByAssociateId": 5,
  "WebhookName": "Relation Webhook"
}
```

## Relation.deleted

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: relation.deleted
X-Superoffice-Eventid: e87ac619-c864-4881-89eb-07ca5521ee2c
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "e87ac619-c864-4881-89eb-07ca5521ee2c",
  "Timestamp": "2018-04-24T08:18:42.089895Z",
  "Changes": [],
  "Values": {
    "associate_id": 40,
    "relation_id": 178105
  },
  "Event": "relation.deleted",
  "PrimaryKey": 178105,
  "Entity": "relation",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Relation Webhook"
}
```
