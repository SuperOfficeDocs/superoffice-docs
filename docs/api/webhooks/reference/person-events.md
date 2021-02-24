---
# Mandatory fields.
title: webhook_person_event
description: Person events
author:
so.date:
keywords: automation
so.topic: reference         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---
# Person webhook events

These webhook events are fired when person rows are changed:

* `person.created`
* `person.changed`
* `person.deleted`
* `person.consented` - when consent is added or changed.
* `person.unconsented` - when consent is removed or marked as withdrawn.

## Person.created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: person.created
X-Superoffice-Eventid: 576086e3-5261-426b-a84b-26ca7f5b65e8
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "576086e3-5261-426b-a84b-26ca7f5b65e8",
  "Timestamp": "2018-04-24T08:01:15.8506935Z",
  "Changes": [
    "person_id",
    "usepersonaddress",
    "dbi_last_modified",
    "group_id",
    "post2",
    "department",
    "activeInterests",
    "dbi_agent_id",
    "gender",
    "country_id",
    "contact_id",
    "activeErpLinks",
    "year_of_birth",
    "userdef2_id",
    "phone_present",
    "initials",
    "userdef_id",
    "rank",
    "retired",
    "updatedCount",
    "dbi_last_syncronized",
    "sentInfo",
    "post1",
    "registered_associate_id",
    "person_number",
    "dbi_key",
    "middleName",
    "text_id",
    "updated",
    "ticketPriorityId",
    "kanalname",
    "month_of_birth",
    "lastname",
    "position_idx",
    "business_idx",
    "kanafname",
    "registered",
    "title",
    "supportLanguageId",
    "tzLocationId",
    "post3",
    "nomailing",
    "blockEmarketing",
    "firstname",
    "updated_associate_id",
    "supportAssociateId",
    "day_of_birth",
    "showContactTickets",
    "associate_id",
    "source",
    "mrmrs",
    "category_idx",
    "DeletedDate",
    "salutation"
  ],
  "Event": "person.created",
  "PrimaryKey": 1467783,
  "Entity": "person",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 316,
  "WebhookName":"Name you provided"
}
```

## Person.changed

```json
{
  "EventId": "576086e3-5261-426b-a84b-26ca7f5b65e8",
  "Timestamp": "2018-04-24T08:01:15.8506935Z",
  "Changes": [
    "person_id",
    "year_of_birth",
    "person_number",
    "position_idx",
    "title",
    "updated",
    "updated_associate_id",
    "updatedCount"
  ],
  "Event": "person.changed",
  "PrimaryKey": 1467783,
  "Entity": "person",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 316,
  "WebhookName":"Name you provided"
}
```

## Person.deleted

```json
{
    "EventId":"88f91933-edce-4c1a-8ded-ade8e2f72434",
    "Timestamp":"2018-04-05T08:28:01.5732501Z",
    "Changes":[],
    "Values": {
      "associate_id": 4039840,
      "contact_id": 9,
      "person_id": 18
    },
    "Event":"person.deleted",
    "PrimaryKey":18,
    "Entity":"person",
    "ContextIdentifier":"Cust54321",
    "ChangedByAssociateId":5,
    "WebhookName":"Name you provided"
}
```

## Person.consented

```json
{
  "EventId": "576086e3-5261-426b-a84b-26ca7f5b65e8",
  "Timestamp": "2018-04-24T08:01:15.8506935Z",
  "Changes": [
    "consentperson_id",
    "comment",
    "updated_associate_id",
    "consentSource_id",
    "updated",
    "legalBase_id"
  ],
  "Event": "person.consented",
  "PrimaryKey": 18,
  "Entity": "person",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 316,
  "WebhookName":"Name you provided"
}
```

## Person.unconsented

```json
{
    "EventId":"88f91933-edce-4c1a-8ded-ade8e2f72434",
    "Timestamp":"2018-04-05T08:28:01.5732501Z",
    "Changes":[],
    "Event":"person.unconsented",
    "PrimaryKey":18,
    "Entity":"person",
    "ContextIdentifier":"Cust54321",
    "ChangedByAssociateId":5,
    "WebhookName":"Name you provided"
}
```
