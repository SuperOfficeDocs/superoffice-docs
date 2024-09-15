---
uid: enum-sendermailmode
title: Enum values for SenderMailMode
description: Lists the enum values for SenderMailMode.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# SenderMailMode Enum

Type of sender email setting. Always use senderEmailAddress = 0, Use Our contact = 1, Use Support Associate = 2

| Name | Value | Description |
|------|-------|-------------|
|UseDefaultSender|0|Use default sender, saved in template SenderEmailAddress|
|UseOurContact|1|Use persons our contact email address|
|UseSupportContact|2|Use persons support contact.|
|UseLoggedInUser|3|Use logged in user.|

## Usage

* [DocTmpl](../doctmpl.md).senderEmailMode - DocTmpl list table. Describes templates available for writing new documents.
