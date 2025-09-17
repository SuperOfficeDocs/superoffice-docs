---
uid: webhook_extratable_event
title: ExtraTable events
description: ExtraTable events
keywords: extratable webhook
author: Eivind Fasting
date: 16.09.2025
content_type: reference
category: automation
topic: webhook
---
# ExtraTable events

These events are fired when ExtraTable rows are changed:

* `{tablename}.created`
* `{tablename}.changed`
* `{tablename}.deleted`

## FieldValues for extratable events

The following fields are included in the `FieldValues` property of the webhook payload for extratable events:

* `id`
* `last_changed`
* `dbi_agent_id`
* `dbi_last_syncronized`
* `dbi_last_modified`

In addition to this all extrafields besides fields of type 'dbString', `dbShort`and `dbStringBlob` are added.

## y_table.created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-SuperOffice-Event: document.created
X-SuperOffice-EventId: 1848cc1f-d395-49ba-9b35-04a9269996d4

{
  "EventId": "6d8edd3a-5272-4eec-8748-8a98f8632640",
  "Timestamp": "2025-09-16T12:22:14.2553829Z",
  "Changes": [
    "id",
    "last_changed",
    "x_int",
    "x_string"
  ],
  "Event": "y_table.created",
  "PrimaryKey": 6,
  "Entity": "y_table",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 19,
  "WebhookName": "Name you provided",
  "FieldValues": {
    "id": "[I:6]",
    "last_changed": "[DT:09/16/2025 14:22:14.0000000]",
    "dbi_agent_id": "[I:-1]",
    "dbi_last_syncronized": "[DT:01/01/0001 00:00:00.0000000]",
    "dbi_last_modified": "[DT:01/01/0001 00:00:00.0000000]",
    "x_int": "[I:123]"
  }
}
```

## y_table.changed

```json
{
  "EventId": "126397ea-4418-4d1f-90c6-c97fd31bb26a",
  "Timestamp": "2025-09-16T12:27:20.0991919Z",
  "Changes": [
    "id",
    "x_int",
    "last_changed",
    "x_string"
  ],
  "Event": "y_table.changed",
  "PrimaryKey": 6,
  "Entity": "y_table",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 19,
  "WebhookName": "Name you provided",
  "FieldValues": {
    "id": "[I:6]",
    "last_changed": "[DT:09/16/2025 14:27:20.0000000]",
    "dbi_agent_id": "[I:-1]",
    "dbi_last_syncronized": "[DT:01/01/0001 00:00:00.0000000]",
    "dbi_last_modified": "[DT:01/01/0001 00:00:00.0000000]",
    "x_int": "[I:123]"
  }
}
```

## y_table.deleted

```json
{
  "EventId": "645e6972-c46b-4f28-b481-95e4e18e1ce7",
  "Timestamp": "2025-09-16T12:30:00.2702629Z",
  "Changes": [],
  "Event": "y_table.deleted",
  "PrimaryKey": 3,
  "Entity": "y_table",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 19,
  "WebhookName": "Name you provided",
  "Values": {},
  "FieldValues": {
    "id": 3,
    "last_changed": "2025-09-12T14:33:37",
    "dbi_agent_id": -1,
    "dbi_last_syncronized": "0001-01-01T00:00:00",
    "dbi_last_modified": "0001-01-01T00:00:00",
    "x_int": 213
  }
}
```
