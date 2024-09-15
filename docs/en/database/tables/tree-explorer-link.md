---
uid: table-tree_explorer_link
title: tree_explorer_link table
description: This table stores the link of entries in a tree-explorer
so.generated: true
keywords: database table tree_explorer_link
so.topic: reference
so.envir: onsite, online
---

# tree\_explorer\_link Table (400)

This table stores the link of entries in a tree-explorer

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|entry\_id|The id of the entry|FK [tree_explorer_entry](tree-explorer-entry.md)| |
|icon|The icon of the entry|String(255)|&#x25CF;|
|href|The href of the entry|String(255)|&#x25CF;|
|target|The target of the href of the entry|String(255)|&#x25CF;|
|tooltip|The tooltip of the entry|Clob|&#x25CF;|
|session\_key|The session this link belong to|String(255)|&#x25CF;|


![tree_explorer_link table relationship diagram](./media/tree_explorer_link.png)

[!include[details](./includes/tree-explorer-link.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|entry\_id |FK |Index |
|session\_key |String(255) |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[tree\_explorer\_entry](tree-explorer-entry.md)  |This table stores the entries in a tree-explorer |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

