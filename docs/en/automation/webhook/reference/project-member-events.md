---
uid: webhook_projectmember_event
title: Project member webhook events
description: Project member events
keywords: project member webhook, projectmember
author: SuperOffice Product and Engineering
date: 07.07.2025
content_type: reference
category: automation
topic: webhook
---

# Project member webhook events

These webhook events are fired when `projectmember` rows are changed:

* `projectmember.created`
* `projectmember.changed`
* `projectmember.deleted`

## FieldValues for project member events

The following fields are included in the `FieldValues` property of the webhook payload for project member events:

* `contact_id` - ID of the contact
* `mtype_idx` - type of the project member
* `person_id` - ID of the person
* `project_id` - ID of the project
* `projectmember_id` - ID of the project member
* `registered` - date of the project member registration
* `registered_associate_id` - ID of the associate who registered the project member
* `updated` - date of the last update
* `updated_associate_id` - ID of the associate who last updated the project member

## ProjectMember.created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: projectmember.created
X-Superoffice-Eventid: 720b0f15-03b4-42e1-947f-ca1ed10addff
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "720b0f15-03b4-42e1-947f-ca1ed10addff",
  "Timestamp": "2018-04-24T08:37:20.7371764Z",
  "Changes": [
    "projectmember_id",
    "rank",
    "text_id",
    "mtype_idx",
    "registered",
    "updated",
    "project_id",
    "updated_associate_id",
    "person_id",
    "updatedCount",
    "registered_associate_id",
    "contact_id"
  ],
  "Event": "projectmember.created",
  "PrimaryKey": 642962,
  "Entity": "projectmember",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided",
  "FieldValues": {
    "contact_id": 0,
    "mtype_idx": 4,
    "person_id": 174651,
    "project_id": 327845,
    "projectmember_id": 410041,
    "registered": "2021-08-16T09:28:33",
    "registered_associate_id": 9,
    "updated": "2025-05-14T15:09:02.7234871+02:00",
    "updated_associate_id": 5
  }
}
```

## ProjectMember.changed

```json
{
  "EventId": "576086e3-5261-426b-a84b-26ca7f5b65e8",
  "Timestamp": "2018-04-24T08:01:15.8506935Z",
  "Changes": [
    "projectmember_id",
    "mtype_idx",
    "updated",
    "updated_associate_id",
    "updatedCount"
  ],
  "Event": "projectmember.changed",
  "PrimaryKey": 1467783,
  "Entity": "projectmember",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 316,
  "WebhookName":"Name you provided"
}
```

## ProjectMember.deleted

```json
{
    "EventId":"88f91933-edce-4c1a-8ded-ade8e2f72434",
    "Timestamp":"2018-04-05T08:28:01.5732501Z",
    "Changes":[],
    "Values": {
      "associate_id": 4039840,
      "project_id": 178105
    },
    "Event":"projectmember.deleted",
    "PrimaryKey":18,
    "Entity":"projectmember",
    "ContextIdentifier":"Cust54321",
    "ChangedByAssociateId":5,
    "WebhookName":"Name you provided"
}
```
