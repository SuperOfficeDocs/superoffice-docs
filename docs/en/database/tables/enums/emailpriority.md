---
uid: enum-emailpriority
title: Enum values for EMailPriority
description: Lists the enum values for EMailPriority.
generated: true
keywords: database enum
content_type: reference
envir: onsite, online
---

# EMailPriority Enum

Importance of the news item. Low to High. Higher priority items may be shown more prominently in the feed.

| Name | Value | Description |
|------|-------|-------------|
|NoPriority|0||
|Highest|1||
|High|2||
|Normal|3||
|Low|4||
|Lowest|5||

## Usage

* [email_item](../email-item.md).priority - Email data
* [NewsFeedItem](../newsfeeditem.md).Priority - Contains news feed items - published to one or more users, with one or more language descriptions
