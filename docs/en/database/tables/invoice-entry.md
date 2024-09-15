---
uid: table-invoice_entry
title: invoice_entry table
description: This table contain all invoices, connected to a message
so.generated: true
keywords: database table invoice_entry
so.topic: reference
so.envir: onsite, online
---

# invoice\_entry Table (360)

This table contain all invoices, connected to a message

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|message\_id|The message.id this invoice entry is connected to.|FK [ej_message](ej-message.md)| |
|description|A description of the invoice entry|String(255)|&#x25CF;|
|type|The type of this invoice entry|FK [invoice_type](invoice-type.md)| |
|quantity|Number of units|Double| |
|price\_pr\_unit|Price per unit. This is copied from the invoice_type when created so that changes to the price in the future does not affect this one.|Int| |
|discount|Discount for this invoice entry|Int| |
|date\_invoiced|The date for the invoice entry|DateTime| |
|discount\_money|Discount for this invoice entry in money|Int| |
|ie\_sum|The sum of the invoice entry|Int| |


![invoice_entry table relationship diagram](./media/invoice_entry.png)

[!include[details](./includes/invoice-entry.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|message\_id |FK |Index |
|type |FK |Index |
|date\_invoiced |DateTime |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ej\_message](ej-message.md)  |This table contains the messages listed under tickets. |
|[invoice\_type](invoice-type.md)  |A invoiceable item category (a product or service) that provides default invoice line values |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

