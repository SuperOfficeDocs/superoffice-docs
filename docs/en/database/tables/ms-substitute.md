---
uid: table-ms_substitute
title: ms_substitute table
description: Regexp for extracting info from emails when they enter they system
so.generated: true
keywords: database table ms_substitute
so.topic: reference
so.envir: onsite, online
---

# ms\_substitute Table (313)

Regexp for extracting info from emails when they enter they system

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|ms\_filter\_id||FK [ms_filter](ms-filter.md)| |
|parser\_name|The name of the variable as used in the parser.|String(255)|&#x25CF;|
|the\_regexp|The regular expression searched for.|String(255)|&#x25CF;|
|subst\_type|Enum indicating the target domain for this regexp (customer connection, parser, etc).|subst_type|&#x25CF;|
|flags|Bitmap for flags for this entry.|Int|&#x25CF;|


![ms_substitute table relationship diagram](./media/ms_substitute.png)

[!include[details](./includes/ms-substitute.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|ms\_filter\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ms\_filter](ms-filter.md)  |This table contains email filters. These are the filters allowing you to do advanced parsing of incomming emails. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

