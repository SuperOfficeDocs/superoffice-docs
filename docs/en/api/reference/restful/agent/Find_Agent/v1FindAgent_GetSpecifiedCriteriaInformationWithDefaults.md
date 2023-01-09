---
title: POST Agents/Find/GetSpecifiedCriteriaInformationWithDefaults
uid: v1FindAgent_GetSpecifiedCriteriaInformationWithDefaults
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Find/GetSpecifiedCriteriaInformationWithDefaults
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StorageType": "temporibus",
  "ProviderName": "Emmerich-Barton",
  "StorageKey": "veniam",
  "DesiredColumnNames": [
    "Adams, Aufderhar and Beatty",
    "Donnelly LLC"
  ],
  "StaticColumns": [
    "enim",
    "sequi"
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
      "Name": "Schowalter LLC",
      "Operator": "impedit",
      "Values": [
        "aut",
        "odit"
      ],
      "DisplayValues": [
        "ducimus",
        "perspiciatis"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 653,
      "InterOperator": "And",
      "UniqueHash": 692
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Welch, Pouros and Schmitt",
      "DisplayTooltip": "qui",
      "DisplayType": "nihil",
      "CanOrderBy": false,
      "Name": "Breitenberg-Bauch",
      "CanRestrictBy": false,
      "RestrictionType": "libero",
      "RestrictionListName": "Kunze, Kuvalis and Maggio",
      "IsVisible": false,
      "ExtraInfo": "eos",
      "Width": "culpa",
      "IconHint": "doloremque",
      "HeadingIconHint": "voluptas"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Johns-Ortiz",
      "PrimaryKey": 762,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "nam",
          "TooltipHint": "et",
          "LinkHint": "qui"
        }
      },
      "LinkHint": "et",
      "StyleHint": "nulla",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 648
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Kutch Inc and Sons",
      "Description": "Multi-layered regional secured line",
      "Rank": 385,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Kutch Inc and Sons",
      "Description": "Multi-layered regional secured line",
      "Rank": 385,
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
      "FieldLength": 80
    }
  }
}
```