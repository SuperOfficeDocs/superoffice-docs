---
uid: enum-ctaflavor
title: Enum values for CtaFlavor
description: Lists the enum values for CtaFlavor.
generated: true
keywords: database enum
content_type: reference
envir: onsite, online
---

# CtaFlavor Enum

The flavor of the CTA, which determines the style the CTA button renders its type. Info/Warning/Error/Accept/Reject

| Name | Value | Description |
|------|-------|-------------|
|Normal|0|Plain - no special style|
|Info|1|Blue info icon|
|Warning|2|Yellow warning icon|
|Error|3|Red error icon|
|Accept|4|Green check icon|
|Reject|5|Red x icon|

## Usage

* [NewsFeedItemCta](../newsfeeditemcta.md).CtaFlavor - List of Calls-to-Action buttons to attach to a given news item. One item may have multiple CTAs (e.g. Approve + Reject).
