---
uid: table-legal-html-tags
title: legal\_html\_tags table
description: This table is used as a list of all legal HTML tags. HTML tags not in this list                  will be ignored when viewing html versions of messages
so.generated: true
keywords:
  - "database"
  - "legal_html_tags"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# legal\_html\_tags Table (353)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|html\_tag|The legal HTML tag |String(255)| |


![legal_html_tags table relationship diagram](./media/legal_html_tags.png)

[!include[details](./includes/legal-html-tags.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

