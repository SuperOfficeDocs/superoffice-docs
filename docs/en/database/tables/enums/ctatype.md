---
uid: enum-ctatype
title: Enum values for CtaType
description: Lists the enum values for CtaType.
generated: true
keywords: database enum
content_type: reference
envir: onsite, online
---

# CtaType Enum

The type of the CTA, which determines how the CTA button renders. Primary/Secondary/Link

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown - rendered as a link, maybe|
|Primary|1|Rendered as a solid color button|
|Secondary|2|Rendered as an outline button|
|Link|3|Rendered as a blue underlined link|

## Usage

* [NewsFeedItemCta](../newsfeeditemcta.md).CtaType - List of Calls-to-Action buttons to attach to a given news item. One item may have multiple CTAs (e.g. Approve + Reject).
