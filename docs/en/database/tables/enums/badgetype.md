---
uid: enum-badgetype
title: Enum values for BadgeType
description: Lists the enum values for BadgeType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# BadgeType Enum

Badge to explicitly determine how a message was generated

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Initial message source is unknown|
|Reply|1|Message created as a reply|
|Forward|2|Message created as a forward|
|Comment|3|Message created as an internal comment|
|Incoming|4|Message created as a result of other events processing|
|Outgoing|5|Message created as first outgoing message on ticket|

## Usage

* [ej_message](../ej-message.md).badge - This table contains the messages listed under tickets.
