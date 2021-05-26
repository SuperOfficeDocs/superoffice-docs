---
title: Criteria operators
description: Defines what operators are used with which data types and describes how they are used.
author: {AnthonyYates}
keywords: NewSelection, Selection, Find
so.topic: article
so.envir: cloud, onsite
so.client: web
---

# Operators and data types

Different data types can have different operators.

| Data type       | Operator |
|-----------------|----------|
| All types       | equals, isNull, isNotNull |
| Bool            | set |
| Int, Decimal    | equals, = , unequals, !=, less, <, greater, >, between |
| String          | begins, contains, is, notBegins, notContains, isNot |
| Date            | See below |
| DateTime        | See below |
| Associate       | associateIsOneOf, associateIsNotOneOf, currentAssociate |
| Lists           | equals, oneOf, notOneOf |
| intArray, Tags  | intArrayAllOf, intArrayNotAllOf, intArrayOneOf, intArrayNotAnyOf |

## Date and DateTime

**Relative operators** refer to the current date. For the `Date` and `DateTime` restriction types, these operators have changed and some are now considered legacy.

**Common Date and DateTime operators:**

| Data type | Operator |
|-----------|----------|
| Date      | after, afterToday, before, beforeToday, between, date, from, equals, to, today |
| DateTime  | dateTime, beforeTime, afterTime |

### Legacy operators

| Data type | Operator |
|-----------|----------|
| Weeks     | lastWeek, thisWeek, nextWeek |
| Months    | lastMonth, thisMonth, nextMonth |
| Quarter   | lastQuarter, thisQuarter, nextQuarter |
| Year      | thisHalf, thisYear |

> [!NOTE]
> The old operators still exist within the code and will work. However, their use is **strongly discouraged**.
>
> If saved through the criteria API, they will be converted to the new, equivalent operators and values.

### New operators

Instead of having period-specific operators, they are now more generic. Each relative operator takes 2 arguments; the number of periods and the period type.

* thisPeriod
* thisAndNext
* thisAndPrevious
* nextPeriod
* previousPeriod
* thisPreviousAndNext

| Period Types | |
|-- |:---------|
| 1 | days     |
| 2 | weeks    |
| 3 | months   |
| 4 | quarters |
| 5 | years    |

In this way, we can express thisAndNext 2 weeks or thisAndPrevious 2 years.

### Changed types

The type of some archive columns have changed from DateTime to Date. The archive grid control displayed both of them as just Date, but we actually need to differentiate and now do so.

## New restriction types

There are some new `RestrictionTypes` as well:

* `ReporterDate` (which adheres to the old operators, only used in Reports)
* `TimeSpan`, encoded in seconds as a new CultureDataFormatter type with marker [TS:
* `EjUser`, referring to an `ejuser.id`
* `UserGroup`, referring to a `usergroup.usergroup_id`
* `IntArray`, used for Tags

Each of these has operators and value hints in the usual manner, accessible through the appropriate MDO list (`restrictionOperators` with the restriction type passed in through the `ExtraInfo` parameter). They are used for new archive columns and should not cause any compatibility issues.
