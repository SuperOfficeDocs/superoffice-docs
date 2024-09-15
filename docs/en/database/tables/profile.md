---
uid: table-profile
title: profile table
description: Deprecated. This table contains entries for the user profiles.
so.generated: true
keywords: database table profile
so.topic: reference
so.envir: onsite, online
---

# profile Table (329)

Deprecated. This table contains entries for the user profiles.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|name|This is the name of the profile|String(255)|&#x25CF;|
|user\_id|The id of the user.|FK [ejuser](ejuser.md)| |
|list\_ticket\_header|The fields for listing one ticket. Encoded as CSV string.|Clob|&#x25CF;|
|list\_tickets\_header|Depricated|String(255)|&#x25CF;|
|list\_customers\_header|Depricated|String(255)|&#x25CF;|
|list\_companies\_header|Depricated|String(255)|&#x25CF;|
|list\_tickets\_header2|The fields for listing several tickets. Encoded as CSV string.|Clob|&#x25CF;|
|list\_customers\_header2|The fields for listing customers. Encoded as CSV string.|Clob|&#x25CF;|
|list\_companies\_header2|The fields for listing companies. Encoded as CSV string.|Clob|&#x25CF;|


![profile table relationship diagram](./media/profile.png)

[!include[details](./includes/profile.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|user\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ejuser](ejuser.md)  |This table contains entries for the users of the system. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

