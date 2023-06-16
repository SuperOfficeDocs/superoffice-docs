---
uid: table-SearchCatHeadingLink
title: SearchCatHeadingLink table
description: Heading link table for SearchCat, for MDO headers
so.generated: true
keywords: database table SearchCatHeadingLink
so.topic: reference
so.envir: onsite, online
---

# SearchCatHeadingLink Table (108)

Heading link table for SearchCat, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|searchcatheadinglink\_id|Primary key|PK| |
|searchcat\_id|Link to SearchCat list table|FK [SearchCat](searchcat.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SearchCatHeadingLink table relationship diagram](./media/SearchCatHeadingLink.png)

[!include[details](./includes/searchcatheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|searchcatheadinglink\_id |PK |Clustered, Unique |
|searchcat\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[SearchCat](searchcat.md)  |SearchCat list table |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

