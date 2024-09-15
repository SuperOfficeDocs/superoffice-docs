---
uid: table-CountryHeadingLink
title: CountryHeadingLink table
description: Heading link table for Country, for MDO headers
so.generated: true
keywords: database table CountryHeadingLink
so.topic: reference
so.envir: onsite, online
---

# CountryHeadingLink Table (21)

Heading link table for Country, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|countryheadinglink\_id|Primary key|PK| |
|country\_id|Link to Country list table|FK [country](country.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![CountryHeadingLink table relationship diagram](./media/CountryHeadingLink.png)

[!include[details](./includes/countryheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|countryheadinglink\_id |PK |Clustered, Unique |
|country\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[country](country.md)  |Country information |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

