---
uid: table-kb_solution_finder
title: kb_solution_finder table
description: Knowledge base problem solving wizard, categories and subcategories for drilling down
so.generated: true
keywords: database table kb_solution_finder
so.topic: reference
so.envir: onsite, online
---

# kb\_solution\_finder Table (294)

Knowledge base problem solving wizard, categories and subcategories for drilling down

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|parent\_id|The parent of this solution finder.|FK [kb_solution_finder](kb-solution-finder.md)| |
|name||String(255)|&#x25CF;|
|body|The body for the solution finder. HTML format.|Clob|&#x25CF;|


![kb_solution_finder table relationship diagram](./media/kb_solution_finder.png)

[!include[details](./includes/kb-solution-finder.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|parent\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[kb\_solution\_finder](kb-solution-finder.md)  |Knowledge base problem solving wizard, categories and subcategories for drilling down |
|[kb\_solution\_finder\_entry](kb-solution-finder-entry.md)  |Knowledge base problem solving wizard, items in a category linking to a knowledge base entry |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

