---
uid: enum-ticketcategoryflags
title: Enum values for TicketCategoryFlags
description: Lists the enum values for TicketCategoryFlags.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# TicketCategoryFlags Enum

A bitmask representing flags for this category.

* Unknown = 0
* Internal = 1
* OnlyLoggedInUsers = 2
* DefaultToCategoryMaster = 4
* ListInMain = 8
* RedelegateNewMsg = 16
* DelegateToOurContact = 32
* PropagateReplyTemplate = 64
* MembersOnly = 128
* NotifyMembers = 256
* AcceptWhenReplying = 512

## Usage

* [ej_category](../ej-category.md).flags - This table contains categories, in which tickets are categorized. The categories are organized in a hierarchial manner.
