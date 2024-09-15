---
uid: enum-bloblinktype
title: Enum values for BlobLinkType
description: Lists the enum values for BlobLinkType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# BlobLinkType Enum

The link type

| Name | Value | Description |
|------|-------|-------------|
|PersonImage|1|Portrait picture of a person|
|ProjectImage|2|Picture bound to a project|
|EventImage|3|Picture used for a project of type Event, in the Audience client|
|Thumbnail|4|Generic thumbnail - not used?|
|StatusMonitorImage|5|Watermark image for a Status Monitor in Sales Intelligence|
|BatchTask|6|Information related to a BatchTask in NetServer|
|ProductImage|7|Image (possibly more than one, differentiated by rank) of a Product; exactly one row should have rank=1|
|ProductThumbnail|8|Thumbnail image for a product, only one allowed per product|
|QuoteLineImage|9|Image (possibly more than one, differentiated by rank) of a Product image for a quote line, only one allowed per quote line|
|QuoteLineThumbnail|10|Thumbnail image for a quote line, only one allowed per quote line|
|AccessToken|11|Access Token used by Cloud Documents for accessing external services|
|RefreshToken|12|Refresh Token used by Cloud Documents for accessing external services|
|Dashboard|13|Dashboard|
|DashboardTile|14|Dashboard tile|
|ChatTopicImage|15|Chat topic image|
|FormsBackgroundImage|16|Forms background image|
|ContactImage|17|Contact logo image|
|DashboardHtmlTileData|18|HTML data for dashboard tiles|
|ExtraTableIcon|19|Extra table icon|

## Usage

* [BinaryObjectLink](../binaryobjectlink.md).linkType - Link table, connects a BinaryObject with one or more owners
