---
uid: table-copilot_data_source
title: copilot_data_source table
description: Stores data sources for each copilot
generated: true
keywords: database table copilot_data_source
content_type: reference
envir: onsite, online
---

# copilot\_data\_source Table (475)

Stores data sources for each copilot

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|copilot\_data\_source\_id|Primary key|PK| |
|copilot\_data\_source\_type|Type of copilot data source|Enum [CopilotDataSourceType](enums/copilotdatasourcetype.md)| |
|name|Name of data source|String(4000)| |
|description|Description of data source|String(4000)|&#x25CF;|
|copilot\_id|The associated copilot|FK [copilot](copilot.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![copilot_data_source table relationship diagram](./media/copilot_data_source.png)

[!include[details](./includes/copilot-data-source.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|copilot\_data\_source\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[copilot](copilot.md)  |Contains all available copilots |
|[copilot\_data\_source\_setting](copilot-data-source-setting.md)  |Stores specific configuration values for each data source |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

