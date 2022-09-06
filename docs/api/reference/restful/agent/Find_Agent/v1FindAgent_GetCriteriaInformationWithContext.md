---
title: POST Agents/Find/GetCriteriaInformationWithContext
uid: v1FindAgent_GetCriteriaInformationWithContext
---

# POST Agents/Find/GetCriteriaInformationWithContext

```http
POST /api/v1/Agents/Find/GetCriteriaInformationWithContext
```

Get criteria information from a set of saved criteria.

The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/GetCriteriaInformationWithContext?$select=name,department,category/id
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

StorageType, ProviderName, StorageKey, StaticColumns, Context

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | string |  |
| ProviderName | string |  |
| StorageKey | string |  |
| StaticColumns | array |  |
| Context | string |  |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| Restrictions | array | Array of ArchiveRestrictionInfo restriction specifications (for the first restrictiongroup if there are more than one group |
| CriteriaArchiveColumns | array | Array of ColumnInfo column specifications |
| CriteriaArchiveRows | array | Array of archive list items, i.e., the service layer carrier for archive rows. These are the criteria, represented as archive rows. |
| RestrictionGroups | array | Array of restrictiongroups, including the default first group of restrictions |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Find/GetCriteriaInformationWithContext
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "StorageType": "quidem",
  "ProviderName": "Ratke, Bednar and Halvorson",
  "StorageKey": "praesentium",
  "StaticColumns": [
    "culpa",
    "ipsa"
  ],
  "Context": "non"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Padberg Inc and Sons",
      "Operator": "possimus",
      "Values": [
        "iusto",
        "qui"
      ],
      "DisplayValues": [
        "impedit",
        "consequuntur"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 348,
      "InterOperator": "And",
      "UniqueHash": 939
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Wyman Group",
      "DisplayTooltip": "aut",
      "DisplayType": "ut",
      "CanOrderBy": true,
      "Name": "Mayert Inc and Sons",
      "CanRestrictBy": false,
      "RestrictionType": "quidem",
      "RestrictionListName": "Predovic, Veum and Leuschke",
      "IsVisible": false,
      "ExtraInfo": "incidunt",
      "Width": "at",
      "IconHint": "consectetur",
      "HeadingIconHint": "et"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Beatty-Jast",
      "PrimaryKey": 908,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "reprehenderit",
          "TooltipHint": "earum",
          "LinkHint": "voluptates"
        }
      },
      "LinkHint": "sit",
      "StyleHint": "modi",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Beier, Adams and Morar",
      "Description": "Streamlined assymetric paradigm",
      "Rank": 15,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Beier, Adams and Morar",
      "Description": "Streamlined assymetric paradigm",
      "Rank": 15,
      "Restrictions": [
        {},
        {}
      ]
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 680
    }
  }
}
```
