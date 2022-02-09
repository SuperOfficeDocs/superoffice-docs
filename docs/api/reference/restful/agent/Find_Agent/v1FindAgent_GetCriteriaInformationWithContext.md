---
title: POST Agents/Find/GetCriteriaInformationWithContext
id: v1FindAgent_GetCriteriaInformationWithContext
---

# POST Agents/Find/GetCriteriaInformationWithContext

```http
POST /api/v1/Agents/Find/GetCriteriaInformationWithContext
```

Get criteria information from a set of saved criteria.

The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/GetCriteriaInformationWithContext?$select=name,department,category/id
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

StorageType, ProviderName, StorageKey, StaticColumns, Context 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | string |  |
| ProviderName | string |  |
| StorageKey | string |  |
| StaticColumns | array |  |
| Context | string |  |


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
POST /api/v1/Agents/Find/GetCriteriaInformationWithContext
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "StorageType": "explicabo",
  "ProviderName": "Lindgren Group",
  "StorageKey": "sed",
  "StaticColumns": [
    "itaque",
    "praesentium"
  ],
  "Context": "quia"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Larkin, Stamm and Murray",
      "Operator": "eius",
      "Values": [
        "et",
        "omnis"
      ],
      "DisplayValues": [
        "minima",
        "voluptatem"
      ],
      "ColumnInfo": {},
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 316,
      "InterOperator": "And",
      "UniqueHash": 128
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Turner, Braun and Kilback",
      "DisplayTooltip": "ut",
      "DisplayType": "nulla",
      "CanOrderBy": false,
      "Name": "Cassin, Kohler and Jerde",
      "CanRestrictBy": true,
      "RestrictionType": "laborum",
      "RestrictionListName": "Kreiger, Klocko and Ondricka",
      "IsVisible": true,
      "ExtraInfo": "consequatur",
      "Width": "et",
      "IconHint": "rerum",
      "HeadingIconHint": "aut"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Moen, Baumbach and Gutkowski",
      "PrimaryKey": 493,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "nobis",
          "TooltipHint": "consequatur",
          "LinkHint": "et"
        }
      },
      "LinkHint": "totam",
      "StyleHint": "possimus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 543
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Johnson, Nienow and Lueilwitz",
      "Description": "Synchronised leading edge alliance",
      "Rank": 58,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Johnson, Nienow and Lueilwitz",
      "Description": "Synchronised leading edge alliance",
      "Rank": 58,
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
      "FieldType": "System.Int32",
      "FieldLength": 572
    }
  }
}
```