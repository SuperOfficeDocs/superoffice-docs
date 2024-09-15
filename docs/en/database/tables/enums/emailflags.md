---
uid: enum-emailflags
title: Enum values for EMailFlags
description: Lists the enum values for EMailFlags.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# EMailFlags Enum

Email flags - answered, deleted, seen, flagged, draft, recent...

| Name | Value | Description |
|------|-------|-------------|
|None|0|0: No flags set|
|Seen|1|1: Mail has been read|
|Deleted|2|2: Mail has been deleted|
|Recent|4|4: Mail is recent|
|Flagged|8|8: Mail is flagged in the GUI|
|Draft|16|16: Mail is an unsent draft|
|Answered|32|32: Mail has been replied to at least once|

## Usage

* [email_item](../email-item.md).flags - Email data
