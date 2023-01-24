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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Find/SaveRestrictionsAndGetCriteriaInformation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StorageType": "cumque",
  "ProviderName": "Rodriguez LLC",
  "StorageKey": "ad",
  "Restrictions": [
    {
      "Name": "Daniel Inc and Sons",
      "Operator": "magni",
      "Values": [
        "vel",
        "possimus"
      ],
      "DisplayValues": [
        "reprehenderit",
        "quos"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 625,
      "InterOperator": "And",
      "UniqueHash": 220
    }
  ],
  "StaticColumns": [
    "nihil",
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
      "Name": "Sauer Group",
      "Operator": "enim",
      "Values": [
        "molestiae",
        "velit"
      ],
      "DisplayValues": [
        "culpa",
        "eveniet"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 806,
      "InterOperator": "And",
      "UniqueHash": 628
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Prohaska Inc and Sons",
      "DisplayTooltip": "excepturi",
      "DisplayType": "sit",
      "CanOrderBy": false,
      "Name": "Lebsack, Orn and Heathcote",
      "CanRestrictBy": false,
      "RestrictionType": "deserunt",
      "RestrictionListName": "Deckow Group",
      "IsVisible": true,
      "ExtraInfo": "mollitia",
      "Width": "autem",
      "IconHint": "ut",
      "HeadingIconHint": "velit"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Ernser LLC",
      "PrimaryKey": 818,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "laborum",
          "TooltipHint": "sapiente",
          "LinkHint": "consequatur"
        }
      },
      "LinkHint": "omnis",
      "StyleHint": "nostrum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Stoltenberg Group",
      "Description": "Self-enabling uniform infrastructure",
      "Rank": 583,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Stoltenberg Group",
      "Description": "Self-enabling uniform infrastructure",
      "Rank": 583,
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
      "FieldLength": 590
    }
  }
}
```