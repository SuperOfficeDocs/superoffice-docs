---
uid: table-ErpListItemMapping
title: ErpListItemMapping table
description: Defines a mapping of ERP to CRM fields, per connection and actor type
so.generated: true
keywords: database table ErpListItemMapping
so.topic: reference
so.envir: onsite, online
---

# ErpListItemMapping Table (424)

Defines a mapping of ERP to CRM fields, per connection and actor type

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|erplistitemmapping\_id|Primary key|PK| |
|ErpFieldId|Link to the Erp field (and implicitly to crm list and Erp Connection)|FK [ErpField](erpfield.md)| |
|ErpItemKey|The unique key in the ERP system for this list item|String(254)| |
|CrmItemKey|The unique key in the CRM database for this list item (list/table is identified by the ListReference in ErpField)|Int|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ErpListItemMapping table relationship diagram](./media/ErpListItemMapping.png)

[!include[details](./includes/erplistitemmapping.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|erplistitemmapping\_id |PK |Clustered, Unique |
|ErpFieldId, ErpItemKey |FK, String(254) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ErpField](erpfield.md)  |Store the metadata describing the fields that belong to an actor/connection combination, as described by the Erp Connector |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

