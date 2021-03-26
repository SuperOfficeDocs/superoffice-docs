---
title: POST Agents/Find/GetCriteriaInformation
id: v1FindAgent_GetCriteriaInformation
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
| StorageType | string |  |
| ProviderName | string |  |
| StorageKey | string |  |
| StaticColumns | array |  |


## Response: object

Carrier for criteria information. It contains all the search criteria - that is, ArchiveRestrictionInfo - objects, including a  column specification. In addition, it contains the same criteria expressed as an archive, with an array of ArchiveColumnInfo specifications and a set of ArchiveRow rows. The rows of the archive form a subset of the restriction array.



Carrier object for CriteriaInformation.
Services for the CriteriaInformation Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IFindAgent">Find Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Restrictions | array | Array of ArchiveRestrictionInfo restriction specifications (for the first restrictiongroup if there are more than one group |
| CriteriaArchiveColumns | array | Array of ColumnInfo column specifications |
| CriteriaArchiveRows | array | Array of archive list items, i.e., the service layer carrier for archive rows. These are the criteria, represented as archive rows. |
| RestrictionGroups | array | Array of restrictiongroups, including the default first group of restrictions |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Find/GetCriteriaInformation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "StorageType": "neque",
  "ProviderName": "Steuber, Lueilwitz and McLaughlin",
  "StorageKey": "est",
  "StaticColumns": [
    "minus",
    "ut"
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Hammes LLC",
      "Operator": "quis",
      "Values": [
        "magnam",
        "qui"
      ],
      "DisplayValues": [
        "voluptas",
        "accusamus"
      ],
      "ColumnInfo": {},
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 879,
      "InterOperator": "And",
      "UniqueHash": 583
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Pfannerstill Inc and Sons",
      "DisplayTooltip": "autem",
      "DisplayType": "ut",
      "CanOrderBy": true,
      "Name": "Brekke-Murphy",
      "CanRestrictBy": true,
      "RestrictionType": "qui",
      "RestrictionListName": "Gutmann, Friesen and Upton",
      "IsVisible": true,
      "ExtraInfo": "vero",
      "Width": "dicta",
      "IconHint": "voluptas",
      "HeadingIconHint": "quas"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Beahan Inc and Sons",
      "PrimaryKey": 272,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "enim",
          "TooltipHint": "nam",
          "LinkHint": "molestiae"
        }
      },
      "LinkHint": "ea",
      "StyleHint": "quis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 622
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Waelchi-Jacobs",
      "Description": "Object-based local middleware",
      "Rank": 374,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Waelchi-Jacobs",
      "Description": "Object-based local middleware",
      "Rank": 374,
      "Restrictions": [
        {},
        {}
      ]
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 220
    }
  }
}
```