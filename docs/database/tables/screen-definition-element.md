---
uid: table-screen-definition-element
title: screen\_definition\_element table
description: An element in a configurable screen
so.generated: true
keywords:
  - "database"
  - "screen_definition_element"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# screen\_definition\_element Table (372)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|name|A name (handle) for this element.|String(255)|&#x25CF;|
|screen\_definition|The screen-definition this element belongs to|FK [screen-definition](screen-definition.md)|&#x25CF;|
|element\_type|An enum for which HtmlElement type this is.|element-type|&#x25CF;|
|description|A description of this field|String(255)|&#x25CF;|
|creation\_script|The script used to create this element|Clob|&#x25CF;|
|order\_pos|The sorted position of this screen in this chooser|Int|&#x25CF;|
|base\_table|Name of the table used as a base for element profile configuration|String(255)|&#x25CF;|
|hide|If TRUE the element will be hidden from the user|Bool| |


![screen_definition_element table relationship diagram](./media/screen_definition_element.png)

[!include[details](./includes/screen-definition-element.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|screen\_definition |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

