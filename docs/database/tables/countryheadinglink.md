---
uid: table-CountryHeadingLink
title: CountryHeadingLink table
description: Heading link table for Country, for MDO headers
so.generated: true
keywords:
  - "database"
  - "CountryHeadingLink"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# CountryHeadingLink Table (21)

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

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|countryheadinglink\_id |PK |Clustered, Unique |
|country\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

