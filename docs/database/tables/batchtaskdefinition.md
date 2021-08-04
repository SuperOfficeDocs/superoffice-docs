---
uid: table-batchtaskdefinition
title: batchtaskdefinition table
description: Batch task definitiopns, populated from the SuperOffice.CRM.BatchProcessing.BatchTask attribute
so.generated: true
keywords:
  - "database"
  - "BatchTaskDefinition"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# batchtaskdefinition Table (244)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|BatchTaskDefinition\_id|Primary key|PK| |
|name|Name of task (for monitoring and debugging)|String(254)| |
|description|Description of task (for monitoring and debugging)|String(254)| |
|isMultiPass|Is this a multipass job (inner implementationis run repeatedly by the batch task framework)|Bool| |
|startInterval|Minimum interval between successive starts; starts never overlap|Int| |
|minimumSleepTime|Minimum sleep interval between the end of one run and start of the next one|Int| |
|timeout|Maximum allowed execution time; jobs are killed if they exceed their timeout; 0=no timeout|Int| |
|autoRestartCount|Number of times the whole batch task should be restarted; -1 means infinite, which is useful for things like Travel Gateway that should &apos;always&apos; be available|Int| |
|assemblyVersion|Version of the assembly that contains the code this batch task definition was populated from|String(49)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|&apos;heartbeat&apos; that is updated once a minute by the batch task process|UtcDateTime| |
|updated\_associate\_id|&apos;heartbeat&apos; that is updated once a minute by the batch task process|FK [associate](associate.md)| |
|updatedCount|heartbeat&apos; that is updated once a minute by the batch task process|UShort| |


![BatchTaskDefinition table relationship diagram](./media/BatchTaskDefinition.png)

[!include[details](./includes/BatchTaskDefinition.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|BatchTaskDefinition\_id |PK |Clustered, Unique |
|name |String(254) |Index |
|name, assemblyVersion |String(254), String(49) |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

