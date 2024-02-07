---
title: POST Agents/Find/GetSpecifiedCriteriaInformationWithDefaults
uid: v1FindAgent_GetSpecifiedCriteriaInformationWithDefaults
generated: true
---

# POST Agents/Find/GetSpecifiedCriteriaInformationWithDefaults

```http
POST /api/v1/Agents/Find/GetSpecifiedCriteriaInformationWithDefaults
```

Get criteria information from a set of saved criteria, for a specific set of columns.


The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control. ALL columns specified in the call will be present in the results; those that do not have corresponding criteria set will have empty values and the default (first) operator, with the IsActive flag set to false.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/GetSpecifiedCriteriaInformationWithDefaults?$select=name,department,category/id
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

StorageType, ProviderName, StorageKey, DesiredColumnNames, StaticColumns 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | String |  |
| ProviderName | String |  |
| StorageKey | String |  |
| DesiredColumnNames | Array |  |
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
POST /api/v1/Agents/Find/GetSpecifiedCriteriaInformationWithDefaults
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StorageType": "dolorem",
  "ProviderName": "Nicolas, Boyle and O'Keefe",
  "StorageKey": "quis",
  "DesiredColumnNames": [
    "Nolan-Mraz",
    "Rippin-Trantow"
  ],
  "StaticColumns": [
    "et",
    "ut"
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
      "Name": "Rice Group",
      "Operator": "ut",
      "Values": [
        "laudantium",
        "autem"
      ],
      "DisplayValues": [
        "maiores",
        "tenetur"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 438,
      "InterOperator": "And",
      "UniqueHash": 375
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Dietrich-Lockman",
      "DisplayTooltip": "suscipit",
      "DisplayType": "et",
      "CanOrderBy": true,
      "Name": "Schowalter, Crona and Olson",
      "CanRestrictBy": false,
      "RestrictionType": "laborum",
      "RestrictionListName": "Herzog LLC",
      "IsVisible": true,
      "ExtraInfo": "in",
      "Width": "aspernatur",
      "IconHint": "est",
      "HeadingIconHint": "vero"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Ritchie-Hills",
      "PrimaryKey": 63,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "iusto",
          "TooltipHint": "officia",
          "LinkHint": "rem"
        }
      },
      "LinkHint": "cupiditate",
      "StyleHint": "dicta",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 188
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Reynolds, Harvey and Hoppe",
      "Description": "Visionary holistic application",
      "Rank": 319,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Reynolds, Harvey and Hoppe",
      "Description": "Visionary holistic application",
      "Rank": 319,
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
      "FieldLength": 178
    }
  }
}
```