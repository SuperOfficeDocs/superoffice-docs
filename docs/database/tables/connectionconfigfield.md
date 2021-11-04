---
uid: table-ConnectionConfigField
title: ConnectionConfigField table
description: Configuration data for Erp and Quote Connections
so.generated: true
keywords:
  - "database"
  - "ConnectionConfigField"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ConnectionConfigField Table (421)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|connectionconfigfield\_id|Primary key|PK| |
|ErpConnectionId|Erp connection, if this row belongs to an ERP Connector|FK [ErpConnection](erpconnection.md)|&#x25CF;|
|QuoteConnectionId|Quote connection, if this row belongs to a Quote Connector|FK [QuoteConnection](quoteconnection.md)|&#x25CF;|
|FieldKey|The key that identifies the field, taken from the connector&apos;s metadata|String(254)|&#x25CF;|
|FieldValue|The field value, formatted for transport as a string using CultureDataFormatter|String(1023)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ConnectionConfigField table relationship diagram](./media/ConnectionConfigField.png)

[!include[details](./includes/connectionconfigfield.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|connectionconfigfield\_id |PK |Clustered, Unique |
|ErpConnectionId |FK |Index |
|QuoteConnectionId |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

