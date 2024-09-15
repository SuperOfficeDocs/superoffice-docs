---
uid: table-user_candidate
title: user_candidate table
description: This table will hold user candidate secrets
so.generated: true
keywords: database table user_candidate
so.topic: reference
so.envir: onsite, online
---

# user\_candidate Table (389)

This table will hold user candidate secrets

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|person\_id|Foreign key. Id of a person representing Customer Center User.|FK [person](person.md)| |
|secret\_key|Username of a Customer Centre User.|String(255)|&#x25CF;|
|secret\_value|Password of a Customer Centre User.|String(255)|&#x25CF;|


![user_candidate table relationship diagram](./media/user_candidate.png)

[!include[details](./includes/user-candidate.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|person\_id |FK |Index |
|secret\_key |String(255) |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[person](person.md)  |Persons in a company or an organizations. All associates have a corresponding person record |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

