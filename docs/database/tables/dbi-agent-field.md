---
uid: table-dbi-agent-field
title: dbi\_agent\_field table
description: DBI agent fields
so.generated: true
keywords:
  - "database"
  - "dbi_agent_field"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# dbi\_agent\_field Table (382)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|agent\_id|The agent owning this field|FK [dbi-agent](dbi-agent.md)| |
|field\_name|Field name|String(255)|&#x25CF;|


![dbi_agent_field table relationship diagram](./media/dbi_agent_field.png)

[!include[details](./includes/dbi-agent-field.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|agent\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

