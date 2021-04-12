---
title: odata_filters
description: Using ODATA filters
author: {github-id}             # Your GitHub alias.
keywords: search,odata,webapi
so.date:
so.topic: howto
---

# Using filters

## Filter operators

**ints**: eq =, ne, le, lt, gt, ge, set, equals, greater, less, unequals, between

**strings**: contains, is, notBegins, notContains, isNot

**associate**: associateIsOneOf, associateIsNotOneOf,

**list IDs**: oneOf, NotOneOf,

**dates**: before, date, after, dateBetween, beforeToday

**Unary ops**: currentAssociate, beforeToday, today, afterToday, lastWeek, thisWeek, nextWeek, lastMonth, thisMonth, nextMonth, lastQuarter, thisQuarter, nextQuarter, thisHalf, thisYear

**Functions**: substringof(a,b), startswith(a,b), endswith(a,b)

## Example: get all companies with category 3

```http
GET /api/v1/Contact?$select=name,category,number&$filter=category oneOf (3)
```

```json
{
  value = [
    {
      "PrimaryKey": "25",
      "EntityName": "contact",
      "name": "Lena Trevare AS",
      "category": "Leverandør",
      "number": "10033"
    }, {
      "PrimaryKey": "26",
      "EntityName": "contact",
      "name": "Liumseter Hyttegrend",
      "category": "Leverandør",
      "number": "10034"
    }, {
      "PrimaryKey": "27",
      "EntityName": "contact",
      "name": "Mosjøen Boligbyggerlag AS",
      "category": "Leverandør",
      "number": "10035"
    }
  ]
}
```

## Full mode

Full mode returns raw values and display values separately

```http
GET /api/v1/Contact?$select=name,category,number&$filter=category%20oneOf%20(3)&$mode=FULL
```

Returns more information about each data point.

```json
{
 value = [
    {
      "PrimaryKey": 25,
      "EntityName": "contact",
      "StyleHint": "",
      "LinkHint": "nav=contact&contact_id=25",
      "TableRight": {
        "Mask": 1,
        "Reason": "[SR_ACTIVITY_BLOCKED_FIND]"
      },
      "Column": {
        "name": {
          "RawValue": "Lena Trevare AS",
          "DisplayValue": "Lena Trevare AS",
          "LinkHint": "",
          "TooltipHint": "{contact_id=25}"
        },
        "category": {
          "RawValue": 3,
          "DisplayValue": "US:\"Vendor\";NO:\"Leverandør\";",
          "LinkHint": "",
          "TooltipHint": "{category_id=3}"
        },
        "number": {
          "RawValue": "10033",
          "DisplayValue": "10033",
          "LinkHint": "",
          "TooltipHint": "{contact_id=25}"
        }
      }
    },
    {
      "PrimaryKey": 26,
      "EntityName": "contact",
      "StyleHint": "",
      "LinkHint": "nav=contact&contact_id=26",
      "TableRight": {
        "Mask": 1,
        "Reason": "[SR_ACTIVITY_BLOCKED_FIND]"
      },
      "Column": {
        "name": {
          "RawValue": "Liumseter Hyttegrend",
          "DisplayValue": "Liumseter Hyttegrend",
          "LinkHint": "",
          "TooltipHint": "{contact_id=26}"
        },
        "category": {
          "RawValue": 3,
          "DisplayValue": "US:\"Vendor\";NO:\"Leverandør\";",
          "LinkHint": "",
          "TooltipHint": "{category_id=3}"
        },
        "number": {
          "RawValue": "10034",
          "DisplayValue": "10034",
          "LinkHint": "",
          "TooltipHint": "{contact_id=26}"
        }
      }
    },
    {
      "PrimaryKey": 27,
      "EntityName": "contact",
      "StyleHint": "",
      "LinkHint": "nav=contact&contact_id=27",
      "TableRight": {
        "Mask": 1,
        "Reason": "[SR_ACTIVITY_BLOCKED_FIND]"
      },
      "Column": {
        "name": {
          "RawValue": "Mosjøen Boligbyggerlag AS",
          "DisplayValue": "Mosjøen Boligbyggerlag AS",
          "LinkHint": "",
          "TooltipHint": "{contact_id=27}"
        },
        "category": {
          "RawValue": 3,
          "DisplayValue": "US:\"Vendor\";NO:\"Leverandør\";",
          "LinkHint": "",
          "TooltipHint": "{category_id=3}"
        },
        "number": {
          "RawValue": "10035",
          "DisplayValue": "10035",
          "LinkHint": "",
          "TooltipHint": "{contact_id=27}"
        }
      }
    }
  ]
}
```
