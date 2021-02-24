---
# Mandatory fields.
title: webhook_contact_event
description: Contact events
author:
so.date:
keywords: automation
so.topic: reference         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Contact webhook events

These webhook events are fired when contact rows are changed:

* `contact.created`
* `contact.changed`
* `contact.softdeleted` - when deleted
* `contact.deleted`

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
  "WebhookName":"Name you provided"
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
