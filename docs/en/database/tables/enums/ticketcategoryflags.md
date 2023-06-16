---
uid: enum-ticketcategoryflags
title: Enum values for TicketCategoryFlags
description: Lists the enum values for TicketCategoryFlags.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TicketCategoryFlags Enum

A bitmask representing flags for this category.

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|No flags set|
|Internal|1|The category is set to internal and is not available in the Customer Centre|
|OnlyLoggedInUsers|2|Only assign requests to logged in users|
|DefaultToCategoryMaster|4|Assign to category administrator if no one is available|
|ListInMain|8|Show category in status view|
|RedelegateNewMsg|16|Reassign requests on new message if user is not present|
|DelegateToOurContact|32|Assign to our service contact if available|
|PropagateReplyTemplate|64|Merge outbound e-mails for this category with reply template|
|MembersOnly|128|Only members have access to requests in this category|
|NotifyMembers|256|Send notification to members about new request|
|AcceptWhenReplying|512|Take ownership by default when replying|

## Usage

* [ej_category](../ej-category.md).flags - This table contains categories, in which tickets are categorized. The categories are organized in a hierarchial manner.
