---
title: POST Agents/Find/SaveRestrictionsAndGetCriteriaInformation
uid: v1FindAgent_SaveRestrictionsAndGetCriteriaInformation
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
| StorageType | string |  |
| ProviderName | string |  |
| StorageKey | string |  |
| Restrictions | array |  |
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
POST /api/v1/Agents/Find/SaveRestrictionsAndGetCriteriaInformation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StorageType": "molestias",
  "ProviderName": "Kris-Romaguera",
  "StorageKey": "ex",
  "Restrictions": [
    {
      "Name": "Tromp, Gusikowski and Heathcote",
      "Operator": "blanditiis",
      "Values": [
        "aperiam",
        "esse"
      ],
      "DisplayValues": [
        "ut",
        "esse"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 266,
      "InterOperator": "And",
      "UniqueHash": 517
    }
  ],
  "StaticColumns": [
    "itaque",
    "et"
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
      "Name": "McLaughlin, Wiza and Terry",
      "Operator": "id",
      "Values": [
        "aut",
        "repudiandae"
      ],
      "DisplayValues": [
        "et",
        "consectetur"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 438,
      "InterOperator": "And",
      "UniqueHash": 911
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Cummerata, Herzog and Lynch",
      "DisplayTooltip": "sequi",
      "DisplayType": "mollitia",
      "CanOrderBy": false,
      "Name": "Luettgen-Davis",
      "CanRestrictBy": true,
      "RestrictionType": "corrupti",
      "RestrictionListName": "Bernhard-Greenfelder",
      "IsVisible": false,
      "ExtraInfo": "quo",
      "Width": "consequatur",
      "IconHint": "non",
      "HeadingIconHint": "eum"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Anderson Inc and Sons",
      "PrimaryKey": 176,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "atque",
          "TooltipHint": "voluptas",
          "LinkHint": "neque"
        }
      },
      "LinkHint": "commodi",
      "StyleHint": "dolores",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 70
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Green-Schoen",
      "Description": "Open-source optimal application",
      "Rank": 130,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Green-Schoen",
      "Description": "Open-source optimal application",
      "Rank": 130,
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
      "FieldLength": 775
    }
  }
}
```