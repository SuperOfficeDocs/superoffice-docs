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
  "StorageType": "eius",
  "ProviderName": "Klocko, Marquardt and Mills",
  "StorageKey": "voluptatem",
  "Restrictions": [
    {
      "Name": "Gibson, Aufderhar and Moore",
      "Operator": "consequatur",
      "Values": [
        "et",
        "molestias"
      ],
      "DisplayValues": [
        "fugit",
        "corrupti"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 710,
      "InterOperator": "And",
      "UniqueHash": 1001
    }
  ],
  "StaticColumns": [
    "consequatur",
    "earum"
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
      "Name": "Upton, Gislason and Gorczany",
      "Operator": "mollitia",
      "Values": [
        "fugit",
        "iste"
      ],
      "DisplayValues": [
        "optio",
        "iste"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 387,
      "InterOperator": "And",
      "UniqueHash": 756
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Kihn, Carroll and Abshire",
      "DisplayTooltip": "cupiditate",
      "DisplayType": "eos",
      "CanOrderBy": true,
      "Name": "Leannon, Kreiger and Nikolaus",
      "CanRestrictBy": true,
      "RestrictionType": "tenetur",
      "RestrictionListName": "Kessler-Friesen",
      "IsVisible": false,
      "ExtraInfo": "accusamus",
      "Width": "qui",
      "IconHint": "nostrum",
      "HeadingIconHint": "debitis"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Johns-Champlin",
      "PrimaryKey": 507,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "quo",
          "TooltipHint": "dolorem",
          "LinkHint": "omnis"
        }
      },
      "LinkHint": "ducimus",
      "StyleHint": "qui",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Kreiger, Klocko and Watsica",
      "Description": "Digitized maximized core",
      "Rank": 168,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Kreiger, Klocko and Watsica",
      "Description": "Digitized maximized core",
      "Rank": 168,
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
      "FieldLength": 121
    }
  }
}
```