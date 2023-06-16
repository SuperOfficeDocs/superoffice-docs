---
uid: table-ProbHeadingLink
title: ProbHeadingLink table
description: Heading link table for Prob, for MDO headers
so.generated: true
keywords: database table ProbHeadingLink
so.topic: reference
so.envir: onsite, online
---

# ProbHeadingLink Table (84)

Heading link table for Prob, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|probheadinglink\_id|Primary key|PK| |
|prob\_id|Link to Prob list table|FK [Prob](prob.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProbHeadingLink table relationship diagram](./media/ProbHeadingLink.png)

[!include[details](./includes/probheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|probheadinglink\_id |PK |Clustered, Unique |
|prob\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[Prob](prob.md)  |Prob list table. Probability, used in  sales . |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

