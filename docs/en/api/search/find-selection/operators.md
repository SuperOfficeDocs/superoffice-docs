---
title: Criteria operators
description: Defines what operators are used with which data types and describes how they are used.
author: AnthonyYates
keywords: NewSelection, Selection, Find
content_type: reference
deployment: online, onsite
platform: web
redirect_from: /en/api/netserver/search/find-selection/operators
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

**Relative operators** refer to the current date. For the `Date` and `DateTime` restriction types, these operators have changed and some are now considered legacy. Overall, 11 of the old date operators will be removed and 6 new will be added to cover for the ones removed.

Why? The current dynamic date ranges for selections in SuperOffice CRM do not cover all the ranges that are necessary for keeping selections up to date and providing good data quality. The date ranges already in SuperOffice have been few and not very conclusive of the function they served. We have therefore decided to remove some of them and to add a few that will cover a bigger range of dates, for the past, the current and the future.

### Common Date and DateTime operators

| Data type | Operator |
|-----------|----------|
| Date      | after, afterToday, before, beforeToday, between, date, from, equals, to, today |
| DateTime  | dateTime, beforeTime, afterTime |

### Operators

There are two types of operators, period and relative operators.

Period specific accept one argument, the period type.

* thisPeriod (period type)
* thisPreviousAndNext (period type)

Relative operators take 2 arguments; the number of periods and the period type.

* thisAndNext (n) (period type)
* thisAndPrevious (n) (period type)
* nextPeriod (n) (period type)
* previousPeriod (n) (period type)

| Period type value | Period type names |
|-- |:---------|
| 1 | day, days |
| 2 | week, weeks, wk, wks    |
| 3 | month, months, mon, mos   |
| 4 | quarter, quarters, qtr, qtrs |
| 5 | halfyear, halfyears, hyr, hyrs |
| 6 | year, years, yr, yrs    |

In this way, you can express  `next` 2 weeks or `thisAndNext` 2 months or `thisAndPrevious` 2 years.

Period type names are eqivalent, meaning  `next` 2 week, `next` 2 weeks, `next` 2 wk and `next` 2 wks mean the same criteria.

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

### Changed types

The type of some archive columns has changed from DateTime to Date. The archive grid control displayed both of them as just Date, but we actually need to differentiate and now do so.

## New restriction types

There are some new `RestrictionTypes` as well:

* `ReporterDate` (which adheres to the old operators, only used in Reports)
* `TimeSpan`, encoded in seconds as a new CultureDataFormatter type with marker [TS:
* `EjUser`, referring to an `ejuser.id`
* `UserGroup`, referring to a `usergroup.usergroup_id`
* `IntArray`, used for Tags

Each of these has operators and value hints in the usual manner, accessible through the appropriate MDO list (`restrictionOperators` with the restriction type passed in through the `ExtraInfo` parameter). They are used for new archive columns and should not cause any compatibility issues.
