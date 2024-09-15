---
uid: table-workflow_root_step_link
title: workflow_root_step_link table
description: Link root steps to the workflow
so.generated: true
keywords: database table workflow_root_step_link
so.topic: reference
so.envir: onsite, online
---

# workflow\_root\_step\_link Table (521)

Link root steps to the workflow

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|workflow\_root\_step\_link\_id|Primary key|PK| |
|workflow\_id|The workflow to connect to|FK [workflow](workflow.md)|&#x25CF;|
|workflow\_step\_id|A workflow step connected to the option|FK [workflow_step](workflow-step.md)|&#x25CF;|
|Rank|Step order|Int|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![workflow_root_step_link table relationship diagram](./media/workflow_root_step_link.png)

[!include[details](./includes/workflow-root-step-link.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|workflow\_root\_step\_link\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[workflow](workflow.md)  |SuperOffice specific info about a workflow |
|[workflow\_step](workflow-step.md)  |A set of steps related to a workflow. |


## Replication Flags

* None

## Security Flags

* Sentry controls access to items in this table using user's Role and data rights matrix on the table's parent.

