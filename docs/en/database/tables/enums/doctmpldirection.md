---
uid: enum-doctmpldirection
title: Enum values for DocTmplDirection
description: Lists the enum values for DocTmplDirection.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# DocTmplDirection Enum

1 = incoming, 2 = outgoing, see EAppntDirection

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|The direction of documents from this template is unknown/undecided|
|Incoming|1|Document template for incoming documents|
|Outgoing|2|Document template is used for outgoing documents|
|SaintAll|3|All' choice for Saint. This is NOT an acceptable value for a task definition, but is used by the Saint system for indexing all directions|

## Usage

* [DocTmpl](../doctmpl.md).direction - DocTmpl list table. Describes templates available for writing new documents.
