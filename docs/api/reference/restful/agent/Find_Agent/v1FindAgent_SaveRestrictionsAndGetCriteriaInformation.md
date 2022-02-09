---
title: POST Agents/Find/SaveRestrictionsAndGetCriteriaInformation
id: v1FindAgent_SaveRestrictionsAndGetCriteriaInformation
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
POST /api/v1/Agents/Find/SaveRestrictionsAndGetCriteriaInformation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StorageType": "cum",
  "ProviderName": "Bosco, Howe and Jacobi",
  "StorageKey": "voluptas",
  "Restrictions": [
    {
      "Name": "Muller LLC",
      "Operator": "ex",
      "Values": [
        "soluta",
        "similique"
      ],
      "DisplayValues": [
        "magnam",
        "reprehenderit"
      ],
      "ColumnInfo": {},
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 472,
      "InterOperator": "And",
      "UniqueHash": 178
    }
  ],
  "StaticColumns": [
    "quam",
    "et"
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Kris LLC",
      "Operator": "dolore",
      "Values": [
        "minima",
        "doloribus"
      ],
      "DisplayValues": [
        "voluptas",
        "est"
      ],
      "ColumnInfo": {},
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 990,
      "InterOperator": "And",
      "UniqueHash": 706
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "O'Hara Inc and Sons",
      "DisplayTooltip": "aut",
      "DisplayType": "voluptatibus",
      "CanOrderBy": true,
      "Name": "Conn-Marks",
      "CanRestrictBy": true,
      "RestrictionType": "numquam",
      "RestrictionListName": "Donnelly Inc and Sons",
      "IsVisible": false,
      "ExtraInfo": "similique",
      "Width": "maiores",
      "IconHint": "doloremque",
      "HeadingIconHint": "sunt"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Schuppe-Wintheiser",
      "PrimaryKey": 733,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "beatae",
          "TooltipHint": "aut",
          "LinkHint": "ut"
        }
      },
      "LinkHint": "voluptates",
      "StyleHint": "doloremque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 153
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Borer, Schoen and Bogan",
      "Description": "Secured context-sensitive help-desk",
      "Rank": 847,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Borer, Schoen and Bogan",
      "Description": "Secured context-sensitive help-desk",
      "Rank": 847,
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
      "FieldLength": 8
    }
  }
}
```