---
title: Criteria Operators 
description: Defined what operators are used with which data types and describes how they are used.
author: {AnthonyYates}
keywords: NewSelection, Selection, Find
so.topic: article
so.envir: cloud, onsite
so.client: we
---

## Operators and data types

Difference data types can have different operators.

| Data type       | Description                                                                 |
|-----------------|-----------------------------------------------------------------------------|
| All types       | equals, isNull, isNotNull                                                   |
| Bool            | set                                                                         |
| Int, Decimal    | equals, = , unequals, !=, less, <, greater, >, between                      |
| String          | begins, contains, is, notBegins, notContains, isNot                         |
| Date            | See `Working with dates` section                                            |
| DateTime        | See `Working with dates` section                                            |
| Associate       | associateIsOneOf, associateIsNotOneOf, currentAssociate                     |
| Lists           | equals, oneOf, notOneOf                                                     |
| intArray / Tags | intArrayAllOf, intArrayNotAllOf, intArrayOneOf, intArrayNotAnyOf            |

### Working with dates

The following table contains the list of common date and datetime operators.

| Data type       | Description                                                                    |
|-----------------|--------------------------------------------------------------------------------|
| Date            | after, afterToday, before, beforeToday, between, date, from, equals, to, today |
| DateTime        | dateTime, beforeTime, afterTime                                                |

The Date and DateTime restriction types have had their relative operators changed. Relative operators are those that refer to the current date, and several existing relative operators are considered legacy.

### Legacy relative operators

| Data type | Description                                                                 |
|-----------|-----------------------------------------------------------------------------|
| Weeks     | lastWeek, thisWeek, nextWeek                                            |
| Months    | lastMonth, thisMonth, nextMonth                                        |
| Quarter   | lastQuarter, thisQuarter, nextQuarter                                 |
| Year      | thisHalf, thisYear                                                       |

### New relative operators

Instead of having period-specific operators, they are now more generic. Each relative operator takes two arguments; the number of periods and the period type.

* thisPeriod
* thisAndNext
* thisAndPrevious
* nextPeriod
* previousPeriod
* thisPreviousAndNext

| Period Types |              |
|-- |:---------|
| 1 | days     |
| 2 | weeks    |
| 3 | months   |
| 4 | quarters |
| 5 | years    |

In this way we can express thisAndNext 2 weeks or thisAndPrevious 2 years.

> [!NOTE]
> The old operators still exist within the code and will work; however their use is strongly discouraged. If saved through the criteria API, they will be converted to the new, equivalent operators > and values.

Some archive columns have changed type from DateTime to Date. The archive grid control displayed both of them as just Date, but we actually need to differentiate and now do so.

There are some new `RestrictionTypes` as well:

* `ReporterDate` (which adheres to the old operators, only used in Reports)
* `TimeSpan`, encoded in seconds as a new CultureDataFormatter type with marker [TS:
* `EjUser`, referring to an `ejuser.id`
* `UserGroup`, referring to a `usergroup.usergroup_id`
* `IntArray`, used for Tags

Each of these has operators and value hints in the usual manner, accessible through the appropriate MDO list (`restrictionOperators` with the restriction type passed in through the `ExtraInfo` parameter). They are used for new archive columns and should not cause any compatibility issues.
