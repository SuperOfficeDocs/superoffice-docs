---
# Mandatory fields.
title: erp_search_operators       # (Required) Very important for SEO.
description: ERP sync search-operator reference # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: reference     # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# ERP search operators

Here are the operators (from `SuperOffice.ErpSync.Contracts`) the connector will need to support for the different field types if it exposes fields available for [advanced search][1].

## String operators

Supported operators in class `StringOperators` for string fields through advanced search. None of these should be case sensitive.

| Operator | Constant |
|---|---|
| Equals | public const string EQUALS = "="; |
| Begins with | public const string BEGINS_WITH = "begins"; |
| Contains | public const string CONTAINS = "contains"; |
| Ends with | public const string ENDS_WITH = "ends"; |
| Does not begin with | public const string NOT_BEGINS_WITH = "notbegins"; |
| Does not contain | public const string NOT_CONTAINS = "notcontains"; |
| Does not end with | public const string NOT_ENDS_WITH = "notends"; |
| Does not equal | public const string NOT_EQUALS = "isnot"; |
| Between | public const string BETWEEN = "between"; |

## Integer operators

Supported operators in class `IntOperators` for int fields through advanced search.

| Operator | Constant |
|---|---|
| Equals |public const string EQUALS = "="; |
| Greater than | public const string GREATER_THAN = ">"; |
| Less than | public const string LESS_THAN = "<"; |
| Greater than or equals | public const string GREATER_OR_EQUAL = ">="; |
| Less than or equals | public const string LESS_OR_EQUAL = "<="; |
| Does not equal | public const string NOT_EQUALS = "!="; |
| Between | public const string BETWEEN = "between"; |

## Double operators

Supported operators in class `DoubleOperators` for double fields through advanced search.

| Operator | Constant |
|---|---|
| Equals | public const string EQUALS = "="; |
| Greater than | public const string GREATER_THAN = ">"; |
| Less than | public const string LESS_THAN = "<"; |
| Greater than or equals | public const string GREATER_OR_EQUAL = ">="; |
| Less than or equals | public const string LESS_OR_EQUAL = "<="; |
| Does not equal | public const string NOT_EQUALS = "!="; |
| Between | public const string BETWEEN = "between"; |

## Bool operators

Supported operators in class `BoolOperators` for boolean fields through advanced search.

| Operator | Constant |
|---|---|
| Equals | public const string EQUALS = "="; |

## List operators

Supported operators in class `ListOperators` for list fields through advanced search.

| Operator | Constant |
|---|---|
| Equals | public const string ONE_OF = "oneof"; |
| Does not equal | public const string NOT_ONE_OF = "notoneof"; |

## DateTime operators

> [!NOTE]
> Regarding datetime comparisons: The connector itself will be responsible for determining the best comparison method for DateTime values. In some cases, the correct way is to only compare the Date part of the value, while in other cases it will probably be better to also compare the Time.

Supported operators in class `DateTimeOperators` for datetime fields through advanced search.

| Operator | Constant |
|---|---|
| Equals | public const string EQUALS = "="; |
| Before | public const string BEFORE = "before"; |
| After | public const string AFTER = "after"; |
| Before or equal | public const string BEFORE_OR_EQUAL = "beforeOrEqual"; |
| After or equal | public const string AFTER_OR_EQUAL = "afterOrEqual"; |
| Between | public const string BETWEEN = "between"; |

### Enum MatchType

The `IsMatchDateTime` method takes an optional parameter of type `DateTimeOperators.MatchType` (defaults to `DateAndTime_IgnoreSeconds`) which the connector can use to tell the method how to compare the restriction and search values.

* DateOnly
* TimeOnly
* TimeOnly_IgnoreSeconds
* DateAndTime
* DateAndTime_IgnoreSeconds

<!-- Referenced links -->
[1]: search.md
