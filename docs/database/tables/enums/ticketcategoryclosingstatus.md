---
uid: enum-ticketcategoryclosingstatus
title: Enum values for TicketCategoryClosingStatus
description: Lists the enum values for TicketCategoryClosingStatus.
so.generated: true
keywords:
  - "database"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# TicketCategoryClosingStatus Enum

An integer indicating if new messages should have the &amp;apos;close request&amp;apos; in this category checked as default, or if the users preferences should be selected.

| Name | Value | Description |
|------|-------|-------------|
|UserDefined|0|The ticket status should respect the user defined behaviour|
|Active|1|Indicates that the ticket status should be active as default|
|Closed|2|Indicates that the ticket status should be closed as default|
|Postponed|3|Indicates that the ticket status should be postponed as default|

## Usage

* [ej_category](../ej-category.md).closing_status - This table contains categories, in which tickets are categorized. The categories are organized in a hierarchial manner.
* [ej_category](../ej-category.md).msg_closing_status - This table contains categories, in which tickets are categorized. The categories are organized in a hierarchial manner.
