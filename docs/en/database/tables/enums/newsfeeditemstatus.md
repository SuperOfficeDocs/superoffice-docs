---
uid: enum-newsfeeditemstatus
title: Enum values for NewsFeedItemStatus
description: Lists the enum values for NewsFeedItemStatus.
generated: true
keywords: database enum
content_type: reference
envir: onsite, online
---

# NewsFeedItemStatus Enum

Indicates if the item is being handled by a CTA. (normal, processing, processed)

| Name | Value | Description |
|------|-------|-------------|
|Normal|0|Normal - nothing special has happened yet.|
|Handling|1|Processing has started - the item is being handled by a CTA|
|Handled|2|Handled - the item has been processed by a CTA|

## Usage

* [NewsFeedItem](../newsfeeditem.md).Status - Contains news feed items - published to one or more users, with one or more language descriptions
