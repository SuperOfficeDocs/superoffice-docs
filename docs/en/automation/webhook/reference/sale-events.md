---
uid: webhook_sales_event
title: Sale webhook events
description: Sales events
keywords: sale webhook
author: SuperOffice Product and Engineering
date: 07.07.2025
content_type: reference
category: automation
topic: webhook
---

# Sale webhook events

These webhook events are fired when `sale` rows are changed:

* `sale.created`
* `sale.changed`
* `sale.deleted`
* `sale.sold` - when sale status is changed to *sold*
* `sale.lost` - when sale status is changed to *lost*
* `sale.completed` - when sale.completed is changed to *completed*

See also [quote events][1]

## FieldValues for sale events

The following fields are included in the `FieldValues` property of the webhook payload for sale events:

* `activeLinks` - active links
* `appointment_id` - ID of the appointment
* `associate_id` - ID of the associate who created the sale
* `comptr_id` - ID of the competitor
* `contact_id` - ID of the contact
* `credited_id` - ID of the credited sale
* `currency_id` - ID of the currency
* `done` - sale is done
* `group_idx` - ID of the group
* `person_id` - ID of the person
* `probability_idx` - probability index
* `project_id` - ID of the project
* `reason_id` - ID of the reason
* `reasonSold_id` - ID of the reason sold
* `reasonStalled_id` - ID of the reason stalled
* `registered` - date of the sale registration
* `registered_associate_id` - ID of the associate who registered the sale
* `saleTypeCat_id` - ID of the sale type category
* `saleType_id` - ID of the sale type
* `saledate` - date of the sale
* `source_id` - ID of the source
* `status` - status of the sale
* `updated` - date of the last update
* `updated_associate_id` - ID of the associate who last updated the sale
* `userdef2_id` - user-defined field 2
* `userdef_id` - user-defined field 1

## Sale.Created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: sale.created
X-Superoffice-Eventid: 1fc5752a-6de8-412d-847a-12d5529a0ec6
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "1fc5752a-6de8-412d-847a-12d5529a0ec6",
  "Timestamp": "2018-04-24T08:13:02.8352175Z",
  "Changes": [
    "sale_id",
    "status",
    "nddAppointment_id",
    "postitText_id",
    "appointment_id",
    "activeLinks",
    "saledate",
    "source_id",
    "done",
    "updatedCount",
    "reasonStalled_id",
    "contact_id",
    "activeErpLinks",
    "registered",
    "associate_id",
    "comptr_id",
    "userdef_id",
    "currency_id",
    "heading",
    "credited_id",
    "updated",
    "project_id",
    "reopenDate",
    "earning",
    "probability",
    "nextDueDate",
    "reasonSold_id",
    "person_id",
    "earning_percent",
    "group_idx",
    "saleTypeCat_id",
    "visibility",
    "text_id",
    "number1",
    "amount",
    "registered_associate_id",
    "updated_associate_id",
    "userdef2_id",
    "saleType_id",
    "source",
    "probability_idx",
    "reason_id"
  ],
  "Event": "sale.created",
  "PrimaryKey": 527331,
  "Entity": "sale",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 37201,
  "WebhookName": "Name you provided",
  "FieldValues": {
    "activeLinks": 0,
    "appointment_id": 0,
    "associate_id": 5,
    "comptr_id": 0,
    "contact_id": 5,
    "credited_id": 0,
    "currency_id": 36,
    "done": 1,
    "group_idx": 2,
    "person_id": 8,
    "probability_idx": 1,
    "project_id": 0,
    "reason_id": 0,
    "reasonSold_id": 0,
    "reasonStalled_id": 0,
    "registered": "2020-01-20T13:39:40",
    "registered_associate_id": 5,
    "saleTypeCat_id": 3,
    "saleType_id": 3,
    "saledate": "2020-02-13T00:00:00",
    "source_id": 4,
    "status": 1,
    "updated": "2025-05-14T15:56:39.5450964+02:00",
    "updated_associate_id": 5,
    "userdef2_id": 0,
    "userdef_id": 0
  }
}
```

## Sale.Changed

```json
{
  "EventId": "576086e3-5261-426b-a84b-26ca7f5b65e8",
  "Timestamp": "2018-04-24T08:01:15.8506935Z",
  "Changes": [
    "sale_id",
    "earning",
    "probability",
    "earning_percent",
    "amount",
    "probability_idx",
    "updated",
    "updated_associate_id",
    "updatedCount"
  ],
  "Event": "sale.changed",
  "PrimaryKey": 1467783,
  "Entity": "sale",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 316,
  "WebhookName":"Name you provided",
  "FieldValues": {
    "activeLinks": 0,
    "appointment_id": 0,
    "associate_id": 5,
    "comptr_id": 0,
    "contact_id": 5,
    "credited_id": 0,
    "currency_id": 36,
    "done": 1,
    "group_idx": 2,
    "person_id": 8,
    "probability_idx": 1,
    "project_id": 0,
    "reason_id": 0,
    "reasonSold_id": 0,
    "reasonStalled_id": 0,
    "registered": "2020-01-20T13:39:40",
    "registered_associate_id": 5,
    "saleTypeCat_id": 3,
    "saleType_id": 3,
    "saledate": "2020-02-13T00:00:00",
    "source_id": 4,
    "status": 1,
    "updated": "2025-05-14T15:56:39.5450964+02:00",
    "updated_associate_id": 5,
    "userdef2_id": 0,
    "userdef_id": 0
  }
}
```

## Sale.Deleted

```json
{
  "EventId":"88f91933-edce-4c1a-8ded-ade8e2f72434",
  "Timestamp":"2018-04-05T08:28:01.5732501Z",
  "Changes":[],
  "Values": {
    "associate_id": 4039840,
    "contact_id": 43,
    "person_id": 64,
    "project_id": 178105
  },
  "Event":"sale.deleted",
  "PrimaryKey":18,
  "Entity":"sale",
  "ContextIdentifier":"Cust54321",
  "ChangedByAssociateId":5,
  "WebhookName":"Name you provided",
  "FieldValues": {
    "activeLinks": 0,
    "appointment_id": 0,
    "associate_id": 5,
    "comptr_id": 0,
    "contact_id": 5,
    "credited_id": 0,
    "currency_id": 36,
    "done": 1,
    "group_idx": 2,
    "person_id": 8,
    "probability_idx": 1,
    "project_id": 0,
    "reason_id": 0,
    "reasonSold_id": 0,
    "reasonStalled_id": 0,
    "registered": "2020-01-20T13:39:40",
    "registered_associate_id": 5,
    "saleTypeCat_id": 3,
    "saleType_id": 3,
    "saledate": "2020-02-13T00:00:00",
    "source_id": 4,
    "status": 1,
    "updated": "2025-05-14T15:56:39.5450964+02:00",
    "updated_associate_id": 5,
    "userdef2_id": 0,
    "userdef_id": 0
  }
}
```

## Sale.Sold

There are no field values for this event. Use the changed event instead.

```json
{
  "EventId":"88f91933-edce-4c1a-8ded-ade8e2f72434",
  "Timestamp":"2018-04-05T08:28:01.5732501Z",
  "Changes":[
    "sale_id",
    "status",
    "updated",
    "updated_associate_id"
  ],
  "Event":"sale.sold",
  "PrimaryKey":18,
  "Entity":"sale",
  "ContextIdentifier":"Cust54321",
  "ChangedByAssociateId":5,
  "WebhookName":"Name you provided"
}
```

## Sale.Lost

There are no field values for this event. Use the changed event instead.

```json
{
  "EventId":"88f91933-edce-4c1a-8ded-ade8e2f72434",
  "Timestamp":"2018-04-05T08:28:01.5732501Z",
  "Changes":[
    "sale_id",
    "status",
    "updated",
    "updated_associate_id"
  ],
  "Event":"sale.lost",
  "PrimaryKey":18,
  "Entity":"sale",
  "ContextIdentifier":"Cust54321",
  "ChangedByAssociateId":5,
  "WebhookName":"Name you provided"
}
```

## Sale.Completed

```json
{
  "EventId":"88f91933-edce-4c1a-8ded-ade8e2f72434",
  "Timestamp":"2018-04-05T08:28:01.5732501Z",
  "Changes":[
    "sale_id",
    "done",
    "updated",
    "updated_associate_id"
  ],
  "Event":"sale.completed",
  "PrimaryKey":18,
  "Entity":"sale",
  "ContextIdentifier":"Cust54321",
  "ChangedByAssociateId":5,
  "WebhookName":"Name you provided"
}
```

<!-- Referenced links -->
[1]: quote-events.md
