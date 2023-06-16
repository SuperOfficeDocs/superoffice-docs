---
uid: table-invoice_type
title: invoice_type table
description: A invoiceable item category (a product or service) that provides default invoice line values
so.generated: true
keywords: database table invoice_type
so.topic: reference
so.envir: onsite, online
---

# invoice\_type Table (361)

A invoiceable item category (a product or service) that provides default invoice line values

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|name|A name for this invoice type|String(255)| |
|description|A description of this invoice type|String(255)|&#x25CF;|
|price\_pr\_unit|Price per unit|Int| |
|flags|Various flags|UInt|&#x25CF;|


![invoice_type table relationship diagram](./media/invoice_type.png)

[!include[details](./includes/invoice-type.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[invoice\_entry](invoice-entry.md)  |This table contain all invoices, connected to a message |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

