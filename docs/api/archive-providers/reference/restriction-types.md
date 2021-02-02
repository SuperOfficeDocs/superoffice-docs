---
title: archive_restriction_types
description: Archive provider restriction types
author: Tony Yates
so.date: 05.11.2016
keywords:
so.topic: reference
---

# Archive provider restriction types

The fields in an archive provider's restriction are constrained using operators.

The restrictions used vary according to the `ArchiveColumnInfo.RestrictionType` specified by the archive provider in its available columns.

You would use the `RestrictionOperations.GetOperatorsForType` method to find out these values at run-time, but here are the default values provided by SuperOffice.

* **Name**: the programmatic name you use in the ArchiveRestrictionInfo operator property.
* **ValueHint**: describes how many values the operator needs, and how the UI should treat them.
    R=Read Only, W=Writeable, +=one or more values (multi-select)
* **Display Name**: the English name you would show in the GUI if you converted the resource ID to a string.

## bool

| Name | ValueHint | Display name |
|---|---|---|
| set | W | Is |

## int

| Name | ValueHint | Display name |
|---|---|---|
| equals | W | (=) |
| greater| W | (>) |
| less | W | (\<) |
| unequals| W | (\<>) |
| between | W;W | Between |

## decimal

| Name | ValueHint | Display name |
|---|---|---|
| equals | W | (=) |
| greater | W | (>) |
| less| W | (\<) |
| unequals | W | (\<>) |
| between | W;W | Between |

## string

| Name | ValueHint | Display name |
|---|---|---|
| begins | W | Starts with |
| contains | W | Contains |
| is | W | Equals |
| notBegins | W | Does not begin with |
| notContains | W | Does not contain |
| isNot | W | Is not |

## associate

| Name | ValueHint | Display name |
|---|---|---|
| currentAssociate | R | Current user |
| associateIsOneOf | W+ | Is one of |
| associateIsNotOneOf | W+ | Is not one of |

## listAny

| Name | ValueHint | Display name |
|---|---|---|
| oneOf | W+ | Is one of |
| notOneOf | W+ | Is not one of |

## datetime

Both the date and time are used.

| Name | ValueHint | Display name |
|---|---|---|
| afterTime | W | After or equal to Datetime |
| beforeTime | W | Before Datetime |
| dateTime | W | Exact Datetime |

## date

Only the date part is used.

| Name | ValueHint | Display name |
|---|---|---|
| before | W | Before |
| date | W | Equals |
| after | W | After |
| dateBetween | W;W | Between |
| beforeToday | R | Before today |
| today | R | Today |
| afterToday | R | After today |
| lastWeek | R;R | Last week |
| thisWeek | R;R | This week |
| nextWeek | R;R | Next week |
| lastMonth | R;R | Last month |
| thisMonth | R;R | This month |
| nextMonth | R;R | Next month |
| lastQuarter | R;R | Last quarter |
| thisQuarter | R;R | This quarter |
| nextQuarter | R;R | Next quarter |
| thisHalf | R;R | This half |
| thisYear | R;R | This year |

## unlimitedDate

| Name | ValueHint | Display name |
|---|---|---|
| before | W | Before |
| date | W | Equals |
| after | W | After |
| dateBetween | W;W | Between |
| beforeToday | R | Before today |
| today | R | Today |
| afterToday | R | After today |
| lastWeek | R;R | Last week |
| thisWeek | R;R | This week |
| nextWeek | R;R | Next week |
| lastMonth | R;R | Last month |
| thisMonth | R;R | This month |
| nextMonth | R;R | Next month |
| lastQuarter | R;R | Last quarter |
| thisQuarter | R;R | This quarter |
| nextQuarter | R;R | Next quarter |
| thisHalf | R;R | This half |
| thisYear | R;R | This year |
