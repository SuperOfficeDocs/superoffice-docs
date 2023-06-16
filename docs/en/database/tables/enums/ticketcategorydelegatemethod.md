---
uid: enum-ticketcategorydelegatemethod
title: Enum values for TicketCategoryDelegateMethod
description: Lists the enum values for TicketCategoryDelegateMethod.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TicketCategoryDelegateMethod Enum

An integer indicating the delegation method for this category.

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|The delegate method is unknown, should normally not occure in the database|
|Even|1|Delegate request even among the members of the category|
|Weighted|2|Use weights on each member of the category when delegating requests|
|Unfair|3|The user with the least active request will be delegated the request|
|Not|4|Do not delegate request. Instead set them as unassigned|

## Usage

* [ej_category](../ej-category.md).delegate_method - This table contains categories, in which tickets are categorized. The categories are organized in a hierarchial manner.
