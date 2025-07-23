---
uid: webhook_contact_event
title: Contact webhook events
description: Contact events
keywords: contact webhook
author: SuperOffice Product and Engineering
date: 07.07.2025
content_type: reference
category: automation
topic: webhook
---

# Contact webhook events

These webhook events are fired when contact rows are changed:

* `contact.created`
* `contact.changed`
* `contact.softdeleted` - when deleted in the user interface.
* `contact.deleted` - when permanently deleted by the system.

## Included FieldValues for contact events

The following fields are included in the `FieldValues` property of the webhook payload for contact events:

* `activeInterests`
* `associate_id`
* `business_idx`
* `category_idx`
* `country_id`
* `deleted`
* `DeletedDate`
* `registered`
* `registered_associate_id`
* `source`
* `updated`
* `userdef2_id`
* `userdef_id`

## Contact.Created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: contact.created
X-Superoffice-Eventid: 8337ae4a-1dd6-40fd-8dc7-a050664a0af7
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "8337ae4a-1dd6-40fd-8dc7-a050664a0af7",
  "Timestamp": "2018-04-24T07:50:50.6812131Z",
  "Changes": [
    "contact_id",
    "activeErpLinks",
    "activeInterests",
    "associate_id",
    "business_idx",
    "category_idx"
    "country_id",
    "dbi_agent_id",
    "dbi_key",
    "dbi_last_modified",
    "dbi_last_syncronized",
    "deleted",
    "department",
    "group_id",
    "kananame",
    "mother_id",
    "name",
    "nomailing",
    "number1",
    "number2",
    "orgNr",
    "registered_associate_id",
    "registered",
    "soundEx",
    "source",
    "supportAssociateId",
    "supportLanguageId",
    "supportPersonId",
    "text_id",
    "ticketPriorityId",
    "tzLocationId",
    "updated_associate_id",
    "updated",
    "updatedCount",
    "userdef_id",
    "userdef2_id",
    "xstop",
  ],
  "Event": "contact.created",
  "PrimaryKey": 994863,
  "Entity": "contact",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 316,
  "WebhookName":"Name you provided",
  "FieldValues": {
    "activeInterests": 0,
    "associate_id": 12,
    "business_idx": 2,
    "category_idx": 4,
    "country_id": 826,
    "deleted": 0,
    "DeletedDate": "0001-01-01T00:00:00",
    "registered": "2020-02-16T17:50:17",
    "registered_associate_id": 5,
    "source": 0,
    "updated": "2025-05-14T10:48:07.8912039+02:00",
    "userdef2_id": 0,
    "userdef_id": 22
  }
}
```

## Contact.changed

```json
{
  "EventId": "8337ae4a-1dd6-40fd-8dc7-a050664a0af7",
  "Timestamp": "2018-04-24T07:50:50.6812131Z",
  "Changes": [
    "contact_id",
    "associate_id",
    "department",
    "updated_associate_id",
    "updated",
    "updatedCount"
  ],
  "Event": "contact.changed",
  "PrimaryKey": 994863,
  "Entity": "contact",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 316,
  "WebhookName":"Name you provided"
}
```

## Contact.Deleted

```json
{
  "EventId": "b24d9089-2d17-419a-a27c-0b0dbcfd58fb",
  "Timestamp": "2018-04-24T07:58:10.9923345Z",
  "Changes": [],
  "Values": {
     "associate_id": 4039840,
     "contact_id": 994863
   },
  "Event": "contact.deleted",
  "PrimaryKey": 994863,
  "Entity": "contact",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 316,
  "WebhookName":"Name you provided"
}
```
