---
uid: ms_substitute
title: ms_substitute table
description: Regexp for extracting info from emails when they enter they system
so.generated: true
keywords:
  - "database"
  - "ms_substitute"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# MsSubstitute Table (313)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|ms\_filter\_id||FK [ms_filter](ms_filter.md)| |
|parser\_name|The name of the variable as used in the parser.|String(255)|&#x25CF;|
|the\_regexp|The regular expression searched for.|String(255)|&#x25CF;|
|subst\_type|Enum indicating the target domain for this regexp (customer connection, parser, etc).|Enum [](enums\Enum.md)|&#x25CF;|
|flags|Bitmap for flags for this entry.|Int|&#x25CF;|


![ms_substitute table relationship diagram](media\ms_substitute.png)

[!include[details](./includes/ms-substitute.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|ms\_filter\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

