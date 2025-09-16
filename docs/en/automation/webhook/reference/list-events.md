---
uid: webhook_list_event
title: List events
description: List events
keywords: list webhook
author: Eivind Fasting
date: 16.09.2025
content_type: reference
category: automation
topic: webhook
---

# List events

Lists in SuperOffice can be both system-defined and user-defined.
Most lists(both system-defined and user-defined) in SuperOffice are registered in the [UDListDefinition Table][1].

## System-defined

All system-defined lists which have a`UDListDefinition_id` can be subscribed to through both the `UDListDefinition_id` and the `List name`.
This means that these events are fired when system-defined lists rows are changed:

* `list.{listName}.created`
* `list.{listName}.changed`
* `list.{listName}.softdeleted`

* `list.{UDListDefinition_id}.created`
* `list.{UDListDefinition_id}.changed`
* `list.{UDListDefinition_id}.softdeleted`

The exceptions (lists without `UDListDefinition_id``) to this are:

* [ej_category][2]
* [TicketPriority][3]
* [TicketStatus][4]
* [TicketType][5]
* [ConsentPurpose][6]
* [ConsentSource][7]
* [PriceList][8]

These lists can only be subscribed to through the listName:

* `list.{listName}.created`
* `list.{listName}.changed`
* `list.{listName}.softdeleted`

The following table contains all the events for system-defined list, using listName:

| List Name            | Created Subscription         | Changed Subscription         | SoftDeleted Subscription         |
|----------------------|------------------------------|------------------------------|----------------------------------|
| amountclass          | list.amountclass.created     | list.amountclass.changed     | list.amountclass.softdeleted     |
| associate            | list.associate.created       | list.associate.changed       | list.associate.softdeleted       |
| business             | list.business.created        | list.business.changed        | list.business.softdeleted        |
| category             | list.category.created        | list.category.changed        | list.category.softdeleted        |
| comptr               | list.comptr.created          | list.comptr.changed          | list.comptr.softdeleted          |
| contint              | list.contint.created         | list.contint.changed         | list.contint.softdeleted         |
| country              | list.country.created         | list.country.changed         | list.country.softdeleted         |
| credited             | list.credited.created        | list.credited.changed        | list.credited.softdeleted        |
| currency             | list.currency.created        | list.currency.changed        | list.currency.softdeleted        |
| deliveryterms        | list.deliveryterms.created   | list.deliveryterms.changed   | list.deliveryterms.softdeleted   |
| deliverytype         | list.deliverytype.created    | list.deliverytype.changed    | list.deliverytype.softdeleted    |
| doctmpl              | list.doctmpl.created         | list.doctmpl.changed         | list.doctmpl.softdeleted         |
| extapp               | list.extapp.created          | list.extapp.changed          | list.extapp.softdeleted          |
| intent               | list.intent.created          | list.intent.changed          | list.intent.softdeleted          |
| mrmrs                | list.mrmrs.created           | list.mrmrs.changed           | list.mrmrs.softdeleted           |
| paymentterms         | list.paymentterms.created    | list.paymentterms.changed    | list.paymentterms.softdeleted    |
| paymenttype          | list.paymenttype.created     | list.paymenttype.changed     | list.paymenttype.softdeleted     |
| persint              | list.persint.created         | list.persint.changed         | list.persint.softdeleted         |
| perspos              | list.perspos.created         | list.perspos.changed         | list.perspos.softdeleted         |
| pmembtype            | list.pmembtype.created       | list.pmembtype.changed       | list.pmembtype.softdeleted       |
| priceunit            | list.priceunit.created       | list.priceunit.changed       | list.priceunit.softdeleted       |
| priority             | list.priority.created        | list.priority.changed        | list.priority.softdeleted        |
| prob                 | list.prob.created            | list.prob.changed            | list.prob.softdeleted            |
| productcategory      | list.productcategory.created | list.productcategory.changed | list.productcategory.softdeleted |
| productfamily        | list.productfamily.created   | list.productfamily.changed   | list.productfamily.softdeleted   |
| producttype          | list.producttype.created     | list.producttype.changed     | list.producttype.softdeleted     |
| projstatus           | list.projstatus.created      | list.projstatus.changed      | list.projstatus.softdeleted      |
| projtype             | list.projtype.created        | list.projtype.changed        | list.projtype.softdeleted        |
| quoteapprreason      | list.quoteapprreason.created | list.quoteapprreason.changed | list.quoteapprreason.softdeleted |
| quotedenyreason      | list.quotedenyreason.created | list.quotedenyreason.changed | list.quotedenyreason.softdeleted |
| reason               | list.reason.created          | list.reason.changed          | list.reason.softdeleted          |
| reasonsold           | list.reasonsold.created      | list.reasonsold.changed      | list.reasonsold.softdeleted      |
| reasonstalled        | list.reasonstalled.created   | list.reasonstalled.changed   | list.reasonstalled.softdeleted   |
| rejectreason         | list.rejectreason.created    | list.rejectreason.changed    | list.rejectreason.softdeleted    |
| relationdefinition   | list.relationdefinition.created | list.relationdefinition.changed | list.relationdefinition.softdeleted |
| saletype             | list.saletype.created        | list.saletype.changed        | list.saletype.softdeleted        |
| saletypecat          | list.saletypecat.created     | list.saletypecat.changed     | list.saletypecat.softdeleted     |
| salutation           | list.salutation.created      | list.salutation.changed      | list.salutation.softdeleted      |
| searchcat            | list.searchcat.created       | list.searchcat.changed       | list.searchcat.softdeleted       |
| source               | list.source.created          | list.source.changed          | list.source.softdeleted          |
| stakeholderrole      | list.stakeholderrole.created | list.stakeholderrole.changed | list.stakeholderrole.softdeleted |
| subscriptionunit     | list.subscriptionunit.created| list.subscriptionunit.changed| list.subscriptionunit.softdeleted|
| tags                 | list.tags.created            | list.tags.changed            | list.tags.softdeleted            |
| task                 | list.task.created            | list.task.changed            | list.task.softdeleted            |
| taskmenu             | list.taskmenu.created        | list.taskmenu.changed        | list.taskmenu.softdeleted        |
| udlist               | list.udlist.created          | list.udlist.changed          | list.udlist.softdeleted          |
| consentpurpose       | list.consentpurpose.created  | list.consentpurpose.changed  | list.consentpurpose.softdeleted  |
| consentsource        | list.consentsource.created   | list.consentsource.changed   | list.consentsource.softdeleted   |
| legalbase            | list.legalbase.created       | list.legalbase.changed       | list.legalbase.softdeleted       |
| pricelist            | list.pricelist.created       | list.pricelist.changed       | list.pricelist.softdeleted       |
| saletypestagelink    | list.saletypestagelink.created | list.saletypestagelink.changed | list.saletypestagelink.softdeleted |
| ejcategory           | list.ejcategory.created      | list.ejcategory.changed      | list.ejcategory.softdeleted      |
| ticketpriority       | list.ticketpriority.created  | list.ticketpriority.changed  | list.ticketpriority.softdeleted  |
| ticketstatus         | list.ticketstatus.created    | list.ticketstatus.changed    | list.ticketstatus.softdeleted    |
| tickettype           | list.tickettype.created      | list.tickettype.changed      | list.tickettype.softdeleted      |
| usergroup            | list.usergroup.created       | list.usergroup.changed       | list.usergroup.softdeleted       |
| udlistdefinition     | list.udlistdefinition.created| list.udlistdefinition.changed| list.udlistdefinition.softdeleted|

## User-defined

These events are fired when user-defined list rows are changed:

* `list.{UDListDefinition_id}.created`
* `list.{UDListDefinition_id}.changed`
* `list.{UDListDefinition_id}.softdeleted`

The [UDListDefinition Table][1] contains the `UDListDefinition_id` for all user-defined lists.

## Example system-defined

This example subscribes to events on the category list

### List.category.created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: associate.created
X-Superoffice-Eventid: 52b8311e-745b-49a0-83eb-a9159635a307
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "21b5ddd7-e487-4a86-a819-f35d0c696b00",
  "Timestamp": "2025-09-16T07:24:33.27583Z",
  "Changes": [
    "Category_id",
    "updated",
    "name",
    "CategoryFamily_id",
    "registered_associate_id",
    "rank",
    "deleted",
    "tooltip",
    "category_group",
    "updated_associate_id",
    "enable_lead_status",
    "registered",
    "updatedCount"
  ],
  "Event": "list.category.created",
  "PrimaryKey": 8,
  "Entity": "list.category",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 19,
  "WebhookName": "Name you provided",
  "FieldValues": {}
}
```

### list.category.changed

```json
{
  "EventId": "e04c6d45-876f-401f-b8b8-53c411657d2f",
  "Timestamp": "2025-09-16T07:25:53.8619128Z",
  "Changes": [
    "Category_id",
    "deleted",
    "rank",
    "updated",
    "updated_associate_id",
    "name",
    "tooltip"
  ],
  "Event": "list.category.changed",
  "PrimaryKey": 8,
  "Entity": "list.category",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 19,
  "WebhookName": "Name you provided",
  "FieldValues": {}
}
```

### list.category.softdeleted

```json
{
  "EventId": "194dbe4d-00fa-46b9-a55e-3cf8a68df6be",
  "Timestamp": "2025-09-16T07:32:39.4080972Z",
  "Changes": [
    "Category_id",
    "deleted",
    "rank",
    "updated",
    "updated_associate_id",
    "name",
    "tooltip"
  ],
  "Event": "list.category.softdeleted",
  "PrimaryKey": 8,
  "Entity": "list.category",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 19,
  "WebhookName": "Name you provided",
  "FieldValues": {}
}
```

## Example user-defined

This example subscribes to events on a user-defined list with `UDListDefinition_id` equals `110`.

### List.110.created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: associate.created
X-Superoffice-Eventid: 52b8311e-745b-49a0-83eb-a9159635a307
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "589d6601-2c9b-4bf6-a654-7473d470665d",
  "Timestamp": "2025-09-16T12:15:35.2321753Z",
  "Changes": [
    "UDList_id",
    "deleted",
    "registered",
    "name",
    "rank",
    "updated",
    "registered_associate_id",
    "updated_associate_id",
    "UDListDefinition_id",
    "updatedCount",
    "tooltip"
  ],
  "Event": "list.110.created",
  "PrimaryKey": 14,
  "Entity": "list.110",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 19,
  "WebhookName": "Name you provided",
  "FieldValues": {}
}
```

### list.110.changed

```json
{
  "EventId": "2472145d-0549-48a1-8a1f-95d47089e631",
  "Timestamp": "2025-09-16T12:16:24.9685045Z",
  "Changes": [
    "UDList_id",
    "deleted",
    "rank",
    "updated",
    "updated_associate_id",
    "name",
    "tooltip"
  ],
  "Event": "list.110.changed",
  "PrimaryKey": 14,
  "Entity": "list.110",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 19,
  "WebhookName": "Name you provided",
  "FieldValues": {}
}
```

### list.110.softdeleted

```json
{
  "EventId": "ff13176b-2c99-4020-8760-db4ca743a8e9",
  "Timestamp": "2025-09-16T12:16:59.0635207Z",
  "Changes": [
    "UDList_id",
    "deleted",
    "rank",
    "updated",
    "updated_associate_id",
    "name",
    "tooltip"
  ],
  "Event": "list.110.softdeleted",
  "PrimaryKey": 14,
  "Entity": "list.110",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 19,
  "WebhookName": "Name you provided",
  "FieldValues": {}
}
```

<!-- Reference links -->
[1]: ../../../database/tables/udlistdefinition.md
[2]: ../../../database/tables/ej-category.md
[3]: ../../../database/tables/ticket-priority.md
[4]: ../../../database/tables/ticket-status.md
[5]: ../../../database/tables/ticket-type.md
[6]: ../../../database/tables/consentpurpose.md
[7]: ../../../database/tables/consentsource.md
[8]: ../../../database/tables/pricelist.md
