---
title: Associate events
uid: webhook_associate_event
description: Associate events
author:
so.date:
keywords: automation
so.topic: reference
# so.envir:
# so.client:
---

# Associate events

These events are fired when associate rows are changed:

* `associate.created`
* `associate.changed`
* `associate.deleted`

## Associate.created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: associate.created
X-Superoffice-Eventid: 52b8311e-745b-49a0-83eb-a9159635a307
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "52b8311e-745b-49a0-83eb-a9159635a307",
  "Timestamp": "2018-04-24T08:53:40.0597952Z",
  "Changes": [
    "associate_id",
    "rank",
    "checklistlimit",
    "tzLocationId",
    "group_idx",
    "isLocation",
    "locationAddress",
    "name",
    "lastlogin",
    "registered",
    "updated_associate_id",
    "type",
    "tooltip",
    "updated",
    "userFlags",
    "encryptedCheck",
    "person_id",
    "lastlogout",
    "deleted",
    "updatedCount",
    "registered_associate_id",
    "ejuserId"
  ],
  "Event": "associate.created",
  "PrimaryKey": 141424,
  "Entity": "associate",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```

## Associate.changed

```json
{
  "EventId": "3e22506b-839a-4453-af17-634d6a626643",
  "Timestamp": "2018-04-24T08:51:08.6815524Z",
  "Changes": [
    "associate_id",
    "group_idx",
    "updated",
    "updated_associate_id"
  ],
  "Event": "associate.changed",
  "PrimaryKey": 141423,
  "Entity": "associate",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```

## Associate.deleted

```json
{
  "EventId": "e87ac619-c864-4881-89eb-07ca5521ee2c",
  "Timestamp": "2018-04-24T08:18:42.089895Z",
  "Changes": [],
  "Values": {
     "associate_id": 4039840,
     "person_id": 12345
   },
  "Event": "associate.deleted",
  "PrimaryKey": 4039840,
  "Entity": "associate",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```
