---
uid: table-NewsFeedItemCta
title: NewsFeedItemCta table
description: List of Calls-to-Action buttons to attach to a given news item. One item may have multiple CTAs (e.g. Approve + Reject).
generated: true
keywords: database table NewsFeedItemCta
content_type: reference
envir: onsite, online
---

# NewsFeedItemCta Table (507)

List of Calls-to-Action buttons to attach to a given news item. One item may have multiple CTAs (e.g. Approve + Reject).

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|newsfeeditemcta\_id|Primary key|PK| |
|newsfeeditem\_id|Foreign key to NewsFeedItem that this description belongs to.|FK [NewsFeedItem](newsfeeditem.md)| |
|SortOrder|Sort order for the CTA buttons. CTAs with lower sort order should be rendered first.|Int| |
|Title|The title of the CTA button. E.g. &apos;Approve&apos;, &apos;Reject&apos;, &apos;View details&apos;. Multi-language string supported: &apos;US:&quot;english&quot;;NO:&quot;norsk&quot;&apos;.|String(400)| |
|Identifier|An identifier for the CTA, which will be sent back to the application when the user clicks the CTA button. E.g. &apos;approve_button/234&apos;, &apos;reject/53fw1&apos;, &apos;5235faq143=&apos;. Where to route is determined by the ApplicationId on the NewsFeedItem|String(200)| |
|CtaType|The type of the CTA, which determines how the CTA button renders. Primary/Secondary/Link|Enum [CtaType](enums/ctatype.md)| |
|CtaFlavor|The flavor of the CTA, which determines the style the CTA button renders its type. Info/Warning/Error/Accept/Reject|Enum [CtaFlavor](enums/ctaflavor.md)| |


![NewsFeedItemCta table relationship diagram](./media/NewsFeedItemCta.png)

[!include[details](./includes/newsfeeditemcta.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|newsfeeditem\_id, SortOrder |FK, Int |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[NewsFeedItem](newsfeeditem.md)  |Contains news feed items - published to one or more users, with one or more language descriptions |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

