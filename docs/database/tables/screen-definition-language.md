---
uid: table-screen_definition_language
title: screen_definition_language table
description: Custom language variables used for screens
so.generated: true
keywords:
  - "database"
  - "screen_definition_language"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# screen\_definition\_language Table (374)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|screen\_definition|The screen-definition this element belongs to|FK [screen_definition](screen-definition.md)|&#x25CF;|
|language|Language &amp;apos;no&amp;apos;, &amp;apos;en&amp;apos;, etc|String(5)|&#x25CF;|
|variable\_name|Variable name|String(255)|&#x25CF;|
|variable\_value|Variable value|Clob|&#x25CF;|


![screen_definition_language table relationship diagram](./media/screen_definition_language.png)

[!include[details](./includes/screen-definition-language.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|screen\_definition |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

