---
uid: table-erplistitemmapping
title: erplistitemmapping table
description: Defines a mapping of ERP to CRM fields, per connection and actor type
so.generated: true
keywords:
  - "database"
  - "ErpListItemMapping"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# erplistitemmapping Table (424)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|erplistitemmapping\_id|Primary key|PK| |
|ErpFieldId|Link to the Erp field (and implicitly to crm list and Erp Connection)|FK [erpfield](erpfield.md)| |
|ErpItemKey|The unique key in the ERP system for this list item|String(254)| |
|CrmItemKey|The unique key in the CRM database for this list item (list/table is identified by the ListReference in ErpField)|Int|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ErpListItemMapping table relationship diagram](./media/ErpListItemMapping.png)

[!include[details](./includes/ErpListItemMapping.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|erplistitemmapping\_id |PK |Clustered, Unique |
|ErpFieldId, ErpItemKey |FK, String(254) |Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

