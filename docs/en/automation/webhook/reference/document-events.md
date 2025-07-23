---
uid: webhook_document_event
title: Document events
description: Document events
keywords: document webhook
author: SuperOffice Product and Engineering
date: 07.07.2025
content_type: reference
category: automation
topic: webhook
---
# Document events

These events are fired when appointment/document rows are changed, or when document contents are changed:

* `document.created`
* `document.changed` - document properties changed
* `document.deleted`
* `document.edited` - document content has changed

## FieldValues for document events

The following fields are included in the `FieldValues` property of the webhook payload for document events:

* `application_id`
* `appointment_id`
* `document_id`
* `registered`
* `registered_associate_id`
* `updated`
* `updated_associate_id`
* `userdef2_id`
* `userdef_id`

## Document.created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-SuperOffice-Event: document.created
X-SuperOffice-EventId: 1848cc1f-d395-49ba-9b35-04a9269996d4

{
  "EventId": "1848cc1f-d395-49ba-9b35-04a9269996d4",
  "Timestamp": "2018-07-05T11:58:18.5809908Z",
  "Changes": [
    "document_id",
    "updated",
    "header",
    "name",
    "searchname",
    "userdef2_id",
    "attention",
    "registered_associate_id",
    "your_ref",
    "archiveProvider",
    "application_id",
    "updated_associate_id",
    "text_id",
    "extref",
    "appointment_id",
    "registered",
    "userdef_id",
    "updatedCount",
    "our_ref"
  ],
  "Event": "document.created",
  "PrimaryKey": 66,
  "Entity": "document",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 18,
  "WebhookName": "Name you provided",
  "FieldValues": {
    "application_id": 0,
    "appointment_id": 301,
    "document_id": 166,
    "registered": "2025-02-12T14:35:27",
    "registered_associate_id": 5,
    "updated": "2025-05-14T14:53:50.6738629+02:00",
    "updated_associate_id": 5,
    "userdef2_id": 0,
    "userdef_id": 0
  }
}
```

## Document.changed

This can be triggered by changes to the document or appointment records (or both), so you may get appointment or document fields in the `Changes` list.

```json
{
  "EventId": "e87ac619-c864-4881-89eb-07ca5521ee2c",
  "Timestamp": "2018-04-24T08:18:42.089895Z",
  "Changes": [
    "status",
    "done",
    "updated",
    "updated_associate_id",
    "updatedCount"
  ],
  "Event": "document.changed",
  "PrimaryKey": 66,
  "Entity": "document",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```

## Document.deleted

```json
{
  "EventId": "e87ac619-c864-4881-89eb-07ca5521ee2c",
  "Timestamp": "2018-04-24T08:18:42.089895Z",
  "Changes": [],
  "Values": {
     "document_id": 66,
     "appointment_id": 69
   },
  "Event": "document.deleted",
  "PrimaryKey": 66,
  "Entity": "document",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```

## Document.edited

When the document contents change.

```json
{
  "EventId": "e87ac619-c864-4881-89eb-07ca5521ee2c",
  "Timestamp": "2018-04-24T08:18:42.089895Z",
  "Changes": [],
  "Event": "document.edited",
  "PrimaryKey": 66,
  "Entity": "document",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```
