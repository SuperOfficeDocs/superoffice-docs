---
uid: table-dbi_agent
title: dbi_agent table
description: DBI agent settings
so.generated: true
keywords:
  - "database"
  - "dbi_agent"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# dbi\_agent Table (381)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|name|Agent name|String(255)|&#x25CF;|
|id\_string|A field for an id_string which may be used to access the dbi agent|String(255)| |
|protocol|Agent communcication protocol |protocol|&#x25CF;|
|path|Path to agent URL or file path|String(255)|&#x25CF;|


![dbi_agent table relationship diagram](./media/dbi_agent.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

