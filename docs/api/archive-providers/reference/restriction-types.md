---
title: archive_restriction_types
description: Archive provider restriction types
author: Tony Yates
so.date: 05.11.2016
keywords:
so.topic: reference
---

# Archive provider RestrictionTypes

The fields in an archive provider's restriction are constrained using operators.

The restrictions used vary according to the `ArchiveColumnInfo.RestrictionType` specified by the archive provider in its available columns.

You would use the `RestrictionOperations.GetOperatorsForType` method to find out these values at run-time, but here are the default values provided by SuperOffice.

* **Name**: the programmatic name you use in the `ArchiveRestrictionInfo` operator property.
* **ValueHint**: describes how many values the operator needs, and how the UI should treat them.
    R=Read Only, W=Writeable, +=one or more values (multi-select)
* **Display Name**: the English name you would show in the GUI if you converted the resource ID to a string.

> [!NOTE]
> SuperOffice v.9.2 introduced the concept of **period** in date restrictions. Version 8.x and earlier uses names like today, thisWeek, thisMonth, thisQuarter, and thisYear. The new restrictions group these into `thisPeriod` (W:int;Period) and pass a number representing the granularity to `ArchiveRestrictionInfo`. (See examples at the end.)

**Period in date restrictions (new):**

* day = 1
* week = 2
* month = 3
* quarter = 4
* year = 5

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

**Example:** Restriction for a personId 123

```csharp
new ArchiveRestrictionInfo("personId", "=", 123)
```

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

**Example:** Restriction for a person firstname begins with A

```csharp
new ArchiveRestrictionInfo("firstName", "begins", "A")
```

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

### Version 9.2 and newer

| Name | ValueHint | Display name |
|---|---|---|
| before | W | Before |
| date | W | Equals |
| after | W | After |
| dateBetween | W;W | Between |
| beforeToday | R | Before today |
| today | R | Today |
| afterToday | R | After today |
| thisPeriod | Period | This 1=day/2=week/3=month/4=quarter/5=year |
| thisAndNext | W:int;Period | This and the next N day/week/month/quarter/year |
| nextPeriod | W:int;Period | The next N, excluding current day/week/month/quarter/year |
| thisAndPrevious | W:int;Period | This and the previous N day/week/month/quarter/year |
| previousPeriod | W:int;Period | The previous excluding current N day/week/month/quarter/year |
| thisPreviousAndNext | Period | The current and the previous and next 1=day/2=week/3=month/4=quarter/5=year |

**Example:** Restriction for a registered date = today

```csharp
new ArchiveRestrictionInfo("registered", "today")
```

**Example:** Restriction for a registered date this or last month

```csharp
new ArchiveRestrictionInfo("registered", "thisAndPrevious", 1, 3)
```

### Version 8.x and earlier

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

### Version 9.2 and newer

| Name | ValueHint | Display name |
|---|---|---|
| before | W | Before |
| date | W | Equals |
| after | W | After |
| dateBetween | W;W |Between |
| beforeToday | R | Before today |
| today | R | Today |
| afterToday | R | After today |
| thisPeriod | Period | This 1=day/2=week/3=month/4=quarter/5=year |
| thisAndNext | W:int;Period | This and the next N day/week/month/quarter/year |
| nextPeriod | W:int;Period | The next N day/week/month/quarter/year |
| thisAndPrevious | W:int;Period | This and the previous N day/week/month/quarter/year |
| previousPeriod | W:int;Period | This and the previous N day/week/month/quarter/year |
| thisPreviousAndNext | Period | The current and the previous and next 1=day/2=week/3=month/4=quarter/5=year |

### Version 8.x and earlier

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

## RestrictionType intArray / Tags

| Name | ValueHint | Display name |
|---|---|---|
| intArrayAllOf | W+ | Has all |
| intArrayNotAllOf | W+ | Missing all |
| intArrayOneOf | W+ | Has any |
| intArrayNotAnyOf | W+ | Missing any |

**Example:** Restriction for both tags 12 and 13

```csharp
new ArchiveRestrictionInfo("registered", "intArrayAllOf", CultureDataFormatter.EncodeIntArr(12,13));
```
