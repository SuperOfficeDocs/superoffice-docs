---
# Mandatory fields.
title: webhook_sales_event
description: Sales events
author:
so.date:
keywords: automation
so.topic: reference         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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
  "WebhookName": "Name you provided"
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
  "WebhookName":"Name you provided"
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
  "WebhookName":"Name you provided"
}
```

## Sale.Sold

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
