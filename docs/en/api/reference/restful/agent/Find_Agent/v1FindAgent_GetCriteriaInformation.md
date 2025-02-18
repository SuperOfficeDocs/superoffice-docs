---
title: POST Agents/Find/GetCriteriaInformation
uid: v1FindAgent_GetCriteriaInformation
generated: true
---

# POST Agents/Find/GetCriteriaInformation

```http
POST /api/v1/Agents/Find/GetCriteriaInformation
```

Get criteria information from a set of saved criteria.


The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/GetCriteriaInformation?$select=name,department,category/id
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

StorageType, ProviderName, StorageKey, StaticColumns 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | String |  |
| ProviderName | String |  |
| StorageKey | String |  |
| StaticColumns | Array |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: CriteriaInformation

| Property Name | Type |  Description |
|----------------|------|--------------|
| Restrictions | array | Array of ArchiveRestrictionInfo restriction specifications (for the first restrictiongroup if there are more than one group |
| CriteriaArchiveColumns | array | Array of ColumnInfo column specifications |
| CriteriaArchiveRows | array | Array of archive list items, i.e., the service layer carrier for archive rows. These are the criteria, represented as archive rows. |
| RestrictionGroups | array | Array of restrictiongroups, including the default first group of restrictions |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Find/GetCriteriaInformation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StorageType": "incidunt",
  "ProviderName": "Botsford, Murray and Feil",
  "StorageKey": "eum",
  "StaticColumns": [
    "omnis",
    "sed"
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Kuphal Inc and Sons",
      "Operator": "culpa",
      "Values": [
        "error",
        "ut"
      ],
      "DisplayValues": [
        "assumenda",
        "magnam"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 520,
      "InterOperator": "And",
      "UniqueHash": 528
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Harvey-Steuber",
      "DisplayTooltip": "sunt",
      "DisplayType": "praesentium",
      "CanOrderBy": false,
      "Name": "Cartwright-McDermott",
      "CanRestrictBy": false,
      "RestrictionType": "vel",
      "RestrictionListName": "Jast-Hoppe",
      "IsVisible": false,
      "ExtraInfo": "laborum",
      "Width": "atque",
      "IconHint": "et",
      "HeadingIconHint": "neque"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Metz, Cormier and Sipes",
      "PrimaryKey": 454,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "nulla",
          "TooltipHint": "animi",
          "LinkHint": "autem"
        }
      },
      "LinkHint": "fugiat",
      "StyleHint": "rem",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 712
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Hilpert, Legros and Schaden",
      "Description": "Quality-focused didactic info-mediaries",
      "Rank": 619,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Hilpert, Legros and Schaden",
      "Description": "Quality-focused didactic info-mediaries",
      "Rank": 619,
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
      "FieldLength": 750
    }
  }
}
```