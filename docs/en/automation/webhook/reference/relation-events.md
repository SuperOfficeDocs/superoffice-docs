---
title: Relation events
uid: webhook_relation_event
description: Relation events
author: AnthonyYates
date: 5.11.2024
keywords: automation
topic: reference
---

# Relation events

These events are fired when Relation rows are changed:

* `relation.created`
* `relation.changed`
* `relation.deleted`

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
  "WebhookName": "Relation Webhook"
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
