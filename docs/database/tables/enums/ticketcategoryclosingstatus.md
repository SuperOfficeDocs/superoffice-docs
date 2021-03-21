---
uid: enum-ticketcategoryclosingstatus
title: Enum values for TicketCategoryClosingStatus
description: Lists the enum values for TicketCategoryClosingStatus.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# TicketCategoryClosingStatus Enum

An integer indicating if new messages should have the &amp;apos;close request&amp;apos; in this category checked as default, or if the users preferences should be selected.

* UserDefined = 0
* Active = 1
* Closed = 2
* Postponed = 3

## Usage

* [ej_category](../ej-category.md).closing_status - This table contains categories, in which tickets are categorized. The categories are organized in a hierarchial manner.
* [ej_category](../ej-category.md).msg_closing_status - This table contains categories, in which tickets are categorized. The categories are organized in a hierarchial manner.
