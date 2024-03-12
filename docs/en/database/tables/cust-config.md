---
uid: table-cust_config
title: cust_config table
description: This table contains JSON structures used for customizing the customer center
so.generated: true
keywords: database table cust_config
so.topic: reference
so.envir: onsite, online
---

# cust\_config Table (477)

This table contains JSON structures used for customizing the customer center

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|cust\_config\_id|Primary key|PK| |
|type|What kind of data is in this row|Enum [ConfigType](enums/configtype.md)|&#x25CF;|
|config|A JSON-formatted config|Clob|&#x25CF;|
|cust\_lang\_id|The customer language which this config belongs to. 0 indicates that the config is global|FK [cust_lang](cust-lang.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![cust_config table relationship diagram](./media/cust_config.png)

[!include[details](./includes/cust-config.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|cust\_config\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[cust\_lang](cust-lang.md)  |This table contains entries for customer languages. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

