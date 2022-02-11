---
title: POST Agents/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext
id: v1FindAgent_GetSpecifiedCriteriaInformationWithDefaultsWithContext
---

# POST Agents/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext

```http
POST /api/v1/Agents/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext
```

Get criteria information from a set of saved criteria, for a specific set of columns.

The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control. ALL columns specified in the call will be present in the results; those that do not have corresponding criteria set will have empty values and the default (first) operator, with the IsActive flag set to false.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext?$select=name,department,category/id
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

StorageType, ProviderName, StorageKey, DesiredColumnNames, StaticColumns, Context 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | string |  |
| ProviderName | string |  |
| StorageKey | string |  |
| DesiredColumnNames | array |  |
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
POST /api/v1/Agents/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StorageType": "officiis",
  "ProviderName": "Ernser LLC",
  "StorageKey": "porro",
  "DesiredColumnNames": [
    "McKenzie LLC",
    "O'Connell-Effertz"
  ],
  "StaticColumns": [
    "aperiam",
    "nobis"
  ],
  "Context": "adipisci"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Waelchi Group",
      "Operator": "molestias",
      "Values": [
        "repellendus",
        "voluptates"
      ],
      "DisplayValues": [
        "consequatur",
        "dignissimos"
      ],
      "ColumnInfo": {},
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 368,
      "InterOperator": "And",
      "UniqueHash": 885
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Harvey-Connelly",
      "DisplayTooltip": "vero",
      "DisplayType": "et",
      "CanOrderBy": true,
      "Name": "Stanton-Schultz",
      "CanRestrictBy": false,
      "RestrictionType": "autem",
      "RestrictionListName": "Effertz LLC",
      "IsVisible": true,
      "ExtraInfo": "voluptas",
      "Width": "sit",
      "IconHint": "ipsam",
      "HeadingIconHint": "labore"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "King, Kuhlman and Wisozk",
      "PrimaryKey": 508,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "possimus",
          "TooltipHint": "velit",
          "LinkHint": "hic"
        }
      },
      "LinkHint": "quia",
      "StyleHint": "officiis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Cassin-Ward",
      "Description": "Robust asynchronous strategy",
      "Rank": 115,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Cassin-Ward",
      "Description": "Robust asynchronous strategy",
      "Rank": 115,
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
      "FieldLength": 827
    }
  }
}
```