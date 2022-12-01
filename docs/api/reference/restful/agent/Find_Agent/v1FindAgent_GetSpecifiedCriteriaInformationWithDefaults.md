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
| StorageType | string |  |
| ProviderName | string |  |
| StorageKey | string |  |
| DesiredColumnNames | array |  |
| StaticColumns | array |  |


## Response: 

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
POST /api/v1/Agents/Find/GetSpecifiedCriteriaInformationWithDefaults
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StorageType": "deleniti",
  "ProviderName": "Crona-Purdy",
  "StorageKey": "occaecati",
  "DesiredColumnNames": [
    "Rath LLC",
    "Jacobi-Greenholt"
  ],
  "StaticColumns": [
    "hic",
    "est"
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
      "Name": "Romaguera Inc and Sons",
      "Operator": "ut",
      "Values": [
        "quibusdam",
        "et"
      ],
      "DisplayValues": [
        "pariatur",
        "vel"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 209,
      "InterOperator": "And",
      "UniqueHash": 575
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Bauch-Volkman",
      "DisplayTooltip": "iusto",
      "DisplayType": "recusandae",
      "CanOrderBy": true,
      "Name": "McClure Inc and Sons",
      "CanRestrictBy": true,
      "RestrictionType": "vitae",
      "RestrictionListName": "Bruen-Stanton",
      "IsVisible": false,
      "ExtraInfo": "hic",
      "Width": "qui",
      "IconHint": "magni",
      "HeadingIconHint": "dignissimos"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Sanford, Okuneva and Parisian",
      "PrimaryKey": 317,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "consequatur",
          "TooltipHint": "sit",
          "LinkHint": "voluptatem"
        }
      },
      "LinkHint": "a",
      "StyleHint": "quo",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Hudson, Collins and Runolfsson",
      "Description": "Open-source 4th generation projection",
      "Rank": 839,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Hudson, Collins and Runolfsson",
      "Description": "Open-source 4th generation projection",
      "Rank": 839,
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
      "FieldType": "System.String",
      "FieldLength": 694
    }
  }
}
```