---
uid: invoice_type
title: invoice_type table
description: A invoiceable item category (a product or service) that provides default invoice line values
so.generated: true
keywords:
  - "database"
  - "invoice_type"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# InvoiceType Table (361)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|name|A name for this invoice type|String(255)| |
|description|A description of this invoice type|String(255)|&#x25CF;|
|price\_pr\_unit|Price per unit|Int| |
|flags|Various flags|UInt|&#x25CF;|


![invoice_type table relationship diagram](media\invoice_type.png)

[!include[details](./includes/invoice-type.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

