---
uid: enum-publishtype
title: Enum values for PublishType
description: Lists the enum values for PublishType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# PublishType Enum

Should this field be published by default?

| Name | Value | Description |
|------|-------|-------------|
|Undefined|0||
|External|1|Published to external persons|

## Usage

* [Task](../task.md).defaultPublishType - Task list table, activity types, like Phone, Meeting
* [DocTmpl](../doctmpl.md).defaultPublishType - DocTmpl list table. Describes templates available for writing new documents.
* [Publish](../publish.md).publishType - Publishing system for external users
