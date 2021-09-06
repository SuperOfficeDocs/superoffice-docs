---
uid: table-user-candidate
title: user\_candidate table
description: This table will hold user candidate secrets
so.generated: true
keywords:
  - "database"
  - "user_candidate"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# user\_candidate Table (389)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|person\_id||FK [person](person.md)| |
|secret\_key||String(255)|&#x25CF;|
|secret\_value||String(255)|&#x25CF;|


![user_candidate table relationship diagram](./media/user_candidate.png)

[!include[details](./includes/user-candidate.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|person\_id |FK |Index |
|secret\_key |String(255) |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

