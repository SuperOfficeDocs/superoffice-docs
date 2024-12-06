---
title: POST Agents/Find/SaveRestrictionsAndGetCriteriaInformation2
uid: v1FindAgent_SaveRestrictionsAndGetCriteriaInformation2
generated: true
---

# POST Agents/Find/SaveRestrictionsAndGetCriteriaInformation2

```http
POST /api/v1/Agents/Find/SaveRestrictionsAndGetCriteriaInformation2
```

Save an array of restrictions for later use as search criteria (including as dynamic selection and Find).


Then, return the same result as a call to GetCriteriaInformation would have done. The purpose is to encapsulate saving and updating of a GUI in one round trip.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/SaveRestrictionsAndGetCriteriaInformation2?$select=name,department,category/id
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
| Restrictions | String |  |
| StaticColumns | String |  |

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
POST /api/v1/Agents/Find/SaveRestrictionsAndGetCriteriaInformation2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "StorageType": "omnis",
  "ProviderName": "Hand, Lakin and Johnson",
  "StorageKey": "sapiente",
  "Restrictions": "quod",
  "StaticColumns": "commodi"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Murray-Corkery",
      "Operator": "architecto",
      "Values": [
        "animi",
        "sequi"
      ],
      "DisplayValues": [
        "iusto",
        "nobis"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 497,
      "InterOperator": "And",
      "UniqueHash": 79
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Kirlin, Deckow and Predovic",
      "DisplayTooltip": "rerum",
      "DisplayType": "quasi",
      "CanOrderBy": true,
      "Name": "Hills, Lynch and Dickens",
      "CanRestrictBy": false,
      "RestrictionType": "explicabo",
      "RestrictionListName": "Osinski-Bradtke",
      "IsVisible": false,
      "ExtraInfo": "qui",
      "Width": "perferendis",
      "IconHint": "et",
      "HeadingIconHint": "sit"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Anderson-Krajcik",
      "PrimaryKey": 322,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "voluptatem",
          "TooltipHint": "dolores",
          "LinkHint": "rem"
        }
      },
      "LinkHint": "sint",
      "StyleHint": "repellendus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 737
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Carter-Parker",
      "Description": "Networked well-modulated application",
      "Rank": 899,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Carter-Parker",
      "Description": "Networked well-modulated application",
      "Rank": 899,
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
      "FieldLength": 945
    }
  }
}
```