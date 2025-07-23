---
uid: webhook_activity_event
title: Activity events
description: Activity events
keywords: activity webhook
author: SuperOffice Product and Engineering
date: 07.07.2025
content_type: reference
category: automation
topic: webhook
---

# Activity events

These events are fired when appointment/document rows are changed:

* `activity.created`
* `activity.changed`
* `activity.deleted`

## Included FieldValues for activity events

The following fields are included in the `FieldValues` property of the webhook payload for activity events:

* `activeDate` - date of the activity
* `associate_id` - ID of the associate who created the activity
* `contact_id` - ID of the contact
* `do_by` - date when the activity should be done
* `document_id` - ID of the document
* `endDate` - date when the activity ends
* `modified_appointment_fields` - modified appointment fields
* `mother_id` - ID of the mother activity
* `person_id` - ID of the person
* `private` - private activity
* `project_id` - ID of the project
* `sale_id` - ID of the sale
* `status` - status of the activity
* `task_idx` - task index
* `type` - type of the activity
* `updated` - date of the last update
* `userdef2_id` - user-defined field 2
* `userdef_id` - user-defined field 1

## Activity.created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: activity.created
X-Superoffice-Eventid: 6aa6de53-f5c3-4dc6-af3e-746df45573b8
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "6aa6de53-f5c3-4dc6-af3e-746df45573b8",
  "Timestamp": "2018-04-24T08:13:17.8445662Z",
  "Changes": [
    "appointment_id",
    "suggestedDocumentId",
    "status",
    "task_idx",
    "endDate",
    "document_id",
    "activeLinks",
    "assignedBy",
    "alarm",
    "done",
    "updatedCount",
    "contact_id",
    "emailId",
    "lagTime",
    "priority_idx",
    "associate_id",
    "userdef_id",
    "group_idx",
    "recurrenceRuleId",
    "private",
    "do_by",
    "location",
    "invitedPersonId",
    "registered_associate_id",
    "preferredTZLocation",
    "updated",
    "project_id",
    "rejectReason",
    "sale_id",
    "person_id",
    "activeDate",
    "rejectCounter",
    "color_index",
    "suggestedAppointmentId",
    "leadtime",
    "registered",
    "hasAlarm",
    "alldayEvent",
    "text_id",
    "updated_associate_id",
    "type",
    "userdef2_id",
    "freeBusy",
    "source",
    "isMilestone",
    "mother_id"
  ],
  "Event": "activity.created",
  "PrimaryKey": 4039840,
  "Entity": "activity",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 37201,
  "WebhookName": "Name you provided",
  "FieldValues": {
    "activeDate": "2025-05-14T16:04:09.1213772+02:00",
    "associate_id": 5,
    "contact_id": 1,
    "do_by": "2025-05-14T16:04:09.1213772+02:00",
    "document_id": 168,
    "endDate": "0001-01-01T00:00:00",
    "modified_appointment_fields": 0,
    "mother_id": 0,
    "person_id": 4,
    "private": 0,
    "project_id": 0,
    "sale_id": 8,
    "status": 3,
    "task_idx": 54,
    "type": 4,
    "updated": "0001-01-01T00:00:00",
    "userdef2_id": 0,
    "userdef_id": 0
  }
}
```

## Activity.changed

```json
{
  "EventId": "e87ac619-c864-4881-89eb-07ca5521ee2c",
  "Timestamp": "2018-04-24T08:18:42.089895Z",
  "Changes": [
    "appointment_id",
    "status",
    "done",
    "updated",
    "updated_associate_id",
    "updatedCount"
  ],
  "Event": "activity.changed",
  "PrimaryKey": 4039840,
  "Entity": "activity",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```

## Activity.deleted

```json
{
  "EventId": "e87ac619-c864-4881-89eb-07ca5521ee2c",
  "Timestamp": "2018-04-24T08:18:42.089895Z",
  "Changes": [],
  "Values": {
     "appointment_id": 4039840,
     "contact_id": 1234,
     "person_id": 0,
     "project_id": 178105,
     "sale_id": 0
   },
  "Event": "activity.deleted",
  "PrimaryKey": 4039840,
  "Entity": "activity",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```
