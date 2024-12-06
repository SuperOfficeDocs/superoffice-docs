---
title: POST Agents/Find/SaveRestrictionsAndGetCriteriaInformation
uid: v1FindAgent_SaveRestrictionsAndGetCriteriaInformation
generated: true
---

# POST Agents/Find/SaveRestrictionsAndGetCriteriaInformation

```http
POST /api/v1/Agents/Find/SaveRestrictionsAndGetCriteriaInformation
```

Save an array of restrictions for later use as search criteria (including as dynamic selection and Find).


Then, return the same result as a call to GetCriteriaInformation would have done. The purpose is to encapsulate saving and updating of a GUI in one round trip.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/SaveRestrictionsAndGetCriteriaInformation?$select=name,department,category/id
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

StorageType, ProviderName, StorageKey, Restrictions, StaticColumns 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | String |  |
| ProviderName | String |  |
| StorageKey | String |  |
| Restrictions | Array |  |
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
POST /api/v1/Agents/Find/SaveRestrictionsAndGetCriteriaInformation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StorageType": "commodi",
  "ProviderName": "McClure, Hilpert and Deckow",
  "StorageKey": "neque",
  "Restrictions": [
    {
      "Name": "Dicki, Marvin and Jast",
      "Operator": "molestias",
      "Values": [
        "facilis",
        "occaecati"
      ],
      "DisplayValues": [
        "tenetur",
        "dolore"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 158,
      "InterOperator": "And",
      "UniqueHash": 221
    }
  ],
  "StaticColumns": [
    "officia",
    "tenetur"
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
      "Name": "Mayer-Schiller",
      "Operator": "hic",
      "Values": [
        "ullam",
        "aut"
      ],
      "DisplayValues": [
        "voluptatem",
        "nemo"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 273,
      "InterOperator": "And",
      "UniqueHash": 733
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Lockman, Yundt and Grant",
      "DisplayTooltip": "possimus",
      "DisplayType": "ducimus",
      "CanOrderBy": false,
      "Name": "Schultz LLC",
      "CanRestrictBy": false,
      "RestrictionType": "temporibus",
      "RestrictionListName": "Grady LLC",
      "IsVisible": false,
      "ExtraInfo": "expedita",
      "Width": "nostrum",
      "IconHint": "eligendi",
      "HeadingIconHint": "veniam"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Herman-Ruecker",
      "PrimaryKey": 383,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "iste",
          "TooltipHint": "perferendis",
          "LinkHint": "qui"
        }
      },
      "LinkHint": "modi",
      "StyleHint": "voluptas",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 385
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Bednar LLC",
      "Description": "Implemented cohesive superstructure",
      "Rank": 558,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Bednar LLC",
      "Description": "Implemented cohesive superstructure",
      "Rank": 558,
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
      "FieldLength": 808
    }
  }
}
```