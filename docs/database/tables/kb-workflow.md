---
uid: table-kb_workflow
title: kb_workflow table
description: Knowledge base workflow steps
so.generated: true
keywords:
  - "database"
  - "kb_workflow"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# kb\_workflow Table (292)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|next|The next workflow phase.|FK [kb_workflow](kb-workflow.md)| |
|previous|The previous workflow phase.|FK [kb_workflow](kb-workflow.md)| |
|name||String(255)|&#x25CF;|


![kb_workflow table relationship diagram](./media/kb_workflow.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|next |FK |Index |
|previous |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

