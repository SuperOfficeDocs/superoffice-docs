---
title: POST Agents/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext
uid: v1FindAgent_GetSpecifiedCriteriaInformationWithDefaultsWithContext
generated: true
---

# POST Agents/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext

```http
POST /api/v1/Agents/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext
```

Get criteria information from a set of saved criteria, for a specific set of columns.


The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control. ALL columns specified in the call will be present in the results; those that do not have corresponding criteria set will have empty values and the default (first) operator, with the IsActive flag set to false.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext?$select=name,department,category/id
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

StorageType, ProviderName, StorageKey, DesiredColumnNames, StaticColumns, Context 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | String |  |
| ProviderName | String |  |
| StorageKey | String |  |
| DesiredColumnNames | Array |  |
| StaticColumns | Array |  |
| Context | String |  |

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
POST /api/v1/Agents/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "StorageType": "nostrum",
  "ProviderName": "Schoen, Ruecker and Huels",
  "StorageKey": "occaecati",
  "DesiredColumnNames": [
    "Schultz, Bayer and Crist",
    "Moen Group"
  ],
  "StaticColumns": [
    "nesciunt",
    "enim"
  ],
  "Context": "quam"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Runte-Weimann",
      "Operator": "esse",
      "Values": [
        "et",
        "ut"
      ],
      "DisplayValues": [
        "nihil",
        "ex"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 31,
      "InterOperator": "And",
      "UniqueHash": 943
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Keebler, Satterfield and Flatley",
      "DisplayTooltip": "nulla",
      "DisplayType": "in",
      "CanOrderBy": false,
      "Name": "Welch, Schuppe and Torphy",
      "CanRestrictBy": false,
      "RestrictionType": "amet",
      "RestrictionListName": "Kunde-Goodwin",
      "IsVisible": false,
      "ExtraInfo": "perferendis",
      "Width": "quod",
      "IconHint": "doloremque",
      "HeadingIconHint": "id"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Bernhard, Abshire and Lynch",
      "PrimaryKey": 561,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "fuga",
          "TooltipHint": "alias",
          "LinkHint": "cupiditate"
        }
      },
      "LinkHint": "nobis",
      "StyleHint": "quos",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 999
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Lebsack Group",
      "Description": "Cross-platform composite secured line",
      "Rank": 740,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Lebsack Group",
      "Description": "Cross-platform composite secured line",
      "Rank": 740,
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
      "FieldLength": 840
    }
  }
}
```