---
uid: webhook_project_event
title: Project events
description: Project events
keywords: project webhook
author: SuperOffice Product and Engineering
date: 07.07.2025
content_type: reference
category: automation
topic: webhook
---

# Project events

These events are fired when project rows are changed:

* `project.created`
* `project.changed`
* `project.deleted`

## Included FieldValues for project events

The following fields are included in the `FieldValues` property of the webhook payload for project events:

* `activeLinks` - active links
* `associate_id` - ID of the associate who created the project
* `done` - project is done
* `registered` - end date of the project
* `registered_associate_id` - ID of the group the project belongs to
* `status_idx` - status of the project
* `type_idx` - type of the project
* `updated` - date of the last update
* `updated_associate_id` - ID of the associate who last updated the project
* `userdef2_id` - user-defined field
* `userdef_id` - user-defined field

## Project.created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: project.created
X-Superoffice-Eventid: e87ac619-c864-4881-89eb-07ca5521ee2c
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "e87ac619-c864-4881-89eb-07ca5521ee2c",
  "Timestamp": "2018-04-24T08:18:42.089895Z",
  "Changes": [
    "project_id",
    "text_id",
    "tzLocationId",
    "postitText_id",
    "activeErpLinks",
    "userdef2_id",
    "status_idx",
    "nmdAppointment_id",
    "registered",
    "endDate",
    "type_idx",
    "source",
    "activeLinks",
    "associate_id",
    "group_id",
    "done",
    "soundEx",
    "updated",
    "userdef_id",
    "updated_associate_id",
    "project_number",
    "nextMilestoneDate",
    "updatedCount",
    "registered_associate_id",
    "name"
  ],
  "Event": "project.created",
  "PrimaryKey": 178105,
  "Entity": "project",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided",
  "FieldValues": {
    "activeLinks": 0,
    "associate_id": 5,
    "done": 0,
    "registered": "2021-08-13T17:53:18",
    "registered_associate_id": 9,
    "status_idx": 2,
    "type_idx": 2,
    "updated": "2025-05-14T15:03:04.0652995+02:00",
    "updated_associate_id": 5,
    "userdef2_id": 0,
    "userdef_id": 0
  }
}
```

## Project.changed

```json
{
  "EventId": "e87ac619-c864-4881-89eb-07ca5521ee2c",
  "Timestamp": "2018-04-24T08:18:42.089895Z",
  "Changes": [
    "project_id",
    "endDate",
    "type_idx",
    "associate_id",
    "group_id",
    "updated",
    "updated_associate_id",
    "updatedCount"
  ],
  "Event": "project.changed",
  "PrimaryKey": 178105,
  "Entity": "project",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```

## Project.deleted

```json
{
  "EventId": "e87ac619-c864-4881-89eb-07ca5521ee2c",
  "Timestamp": "2018-04-24T08:18:42.089895Z",
  "Changes": [],
  "Values": {
    "associate_id": 4039840,
    "project_id": 178105
  },
  "Event": "project.deleted",
  "PrimaryKey": 178105,
  "Entity": "project",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```
