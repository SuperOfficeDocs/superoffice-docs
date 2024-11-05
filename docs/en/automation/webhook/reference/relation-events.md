---
title:Relation webhook events
uid: webhook_relation_event
description: Relation events
author: ChristianM
date: 2024-11-04
keywords: automation
topic: reference
# envir:
# client:
---

# Relation webhook events

These webhook events are fired when `relation` rows are changed:

* `relation.created`
* `relation.changed`
* `relation.deleted`

## Relation.created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: relation.created
X-Superoffice-Eventid: 720b0f15-03b4-42e1-947f-ca1ed10addff
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "639c5fb9-6e5c-4ff6-81d0-6930007785ad",
  "Timestamp": "2024-11-05T09:49:18.4607724Z",
  "Changes": [
    "relation_id",
    "group_idx",
    "reldef_id",
    "destination_table",
    "destination_record",
    "registered",
    "endDate",
    "source_table",
    "reversed",
    "startDate",
    "associateId",
    "updated",
    "source_record",
    "updated_associate_id",
    "relcomment",
    "relFlags",
    "updatedCount",
    "registered_associate_id"
  ],
  "Event": "relation.created",
  "PrimaryKey": 85,
  "Entity": "relation",
  "ContextIdentifier": "Cust12345",
  "ChangedByAssociateId": 18,
  "WebhookName": "Name you provided"
}
```

## Relation.changed

```json
{
  "EventId": "8acb81db-8333-4ae9-ba03-707b4761eb77",
  "Timestamp": "2024-11-05T09:44:24.7081605Z",
  "Changes": [
    "relation_id",
    "updated",
    "relcomment",
    "updated_associate_id"
  ],
  "Event": "relation.changed",
  "PrimaryKey": 3,
  "Entity": "relation",
  "ContextIdentifier": "Cust12345",
  "ChangedByAssociateId": 18,
  "WebhookName": "Name you provided"
}
```

## Relation.deleted

```json
{
  "EventId": "2f3de03c-118f-4f9e-a3fa-b14a0e63f52a",
  "Timestamp": "2024-11-05T09:54:40.0200499Z",
  "Changes": [],
  "Values": {
    "relation_id": 3,
    "registered_associate_id": 18,
    "updated_associate_id": 18
  },
  "Event": "relation.deleted",
  "PrimaryKey": 3,
  "Entity": "relation",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 18,
  "WebhookName": "Name you provided"
}
```
