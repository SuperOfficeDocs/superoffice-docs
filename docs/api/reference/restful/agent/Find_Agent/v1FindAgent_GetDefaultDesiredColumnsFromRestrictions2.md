---
title: POST Agents/Find/GetDefaultDesiredColumnsFromRestrictions2
id: v1FindAgent_GetDefaultDesiredColumnsFromRestrictions2
---

# POST Agents/Find/GetDefaultDesiredColumnsFromRestrictions2

```http
POST /api/v1/Agents/Find/GetDefaultDesiredColumnsFromRestrictions2
```

Calculate the default desired columns, i.

e., the result columns for a given search. The search is defined by a provider name and a set of restrictions. This is the algorithm that is used by the Find service method.

Archive Restriction strings are OData or SQL-ish.
They are parsed and converted into ArchiveRestrictions.

For example:

```http
"name begins 'Super'"
"category = 3"
"category in (2,3,4)"
"xstop set"
"registered after '2014.3.4'"
"registered dateBetween ('2014.11.29', '2014.12.25')"
```

Unary operators:

```http
"updatedDate lastWeek", "assocId currentAssociate"
```

## Brackets and or

AND and OR can be used to combine terms. AND has a higher priority than OR

```http
"business = 2  AND name contains 'super'"
```

Brackets can be used for grouping.

```http
"(business = 2 or category = 3) and name contains 'super'"
```

## Aggregation operators

The column names can encode grouping and summarizing.
You add functions and modifiers to the column name to trigger aggregation.

Example: group last names together, and inject a header row for each group.

```http
GroupBy(lastName):Header
```

Example: count instances of middle names, and hide the individual rows,
report just the totals for each group using a footer. Note how the modifiers stack.

```http
Count(middleName):HideDetail:Footer
```

Example: the aggregator functions can nest, so you can say

```http
GroupBy(DatePart(personUpdatedDate):YearMonth):Header
```

## Strings

Use the begins or contains operators to do string searches.
You can also use the normal = operator to do string exact match checks.

Use backslash to escape single quotes in strings
(note that backslash needs to be doubled because c# also uses backslash escapes):

```http
"department contains 'Bob\\'s'"
```

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/GetDefaultDesiredColumnsFromRestrictions2?$select=name,department,category/id
```

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request

ProviderName, Restrictions

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProviderName | string |  |
| Restrictions | string |  |

## Response: array

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| DisplayName | string |  |
| DisplayTooltip | string |  |
| DisplayType | string |  |
| CanOrderBy | bool |  |
| Name | string |  |
| CanRestrictBy | bool |  |
| RestrictionType | string |  |
| RestrictionListName | string |  |
| IsVisible | bool |  |
| ExtraInfo | string |  |
| Width | string |  |
| IconHint | string |  |
| HeadingIconHint | string |  |

## Sample Request

```http!
POST /api/v1/Agents/Find/GetDefaultDesiredColumnsFromRestrictions2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Ankunding Group",
  "Restrictions": "sint"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DisplayName": "Stiedemann-Beatty",
    "DisplayTooltip": "quibusdam",
    "DisplayType": "veritatis",
    "CanOrderBy": true,
    "Name": "Steuber Group",
    "CanRestrictBy": false,
    "RestrictionType": "sint",
    "RestrictionListName": "Champlin-Pagac",
    "IsVisible": true,
    "ExtraInfo": "voluptatibus",
    "Width": "quis",
    "IconHint": "aut",
    "HeadingIconHint": "ipsum"
  }
]
```
