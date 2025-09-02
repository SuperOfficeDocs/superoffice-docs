---
uid: enum-ttlflags
title: Enum values for TtlFlags
description: Lists the enum values for TtlFlags.
generated: true
keywords: database enum
content_type: reference
envir: onsite, online
---

# TtlFlags Enum

Extra information about the operation, as a bit-masked field

| Name | Value | Description |
|------|-------|-------------|
|None|0|No extra information.|
|Imported|1|The data change was caused by an Import operation.|
|MassOperation|2|The data change was done by a Mass Operation.|

## Usage

* [traveltransactionlog](../traveltransactionlog.md).flags - Log of all updates made to the database, that need to be replicated.
