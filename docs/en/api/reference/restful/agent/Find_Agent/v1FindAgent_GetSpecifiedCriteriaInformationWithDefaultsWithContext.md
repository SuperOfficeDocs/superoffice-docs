---
title: POST Agents/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext
uid: v1FindAgent_GetSpecifiedCriteriaInformationWithDefaultsWithContext
generated: true
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
| StorageType | String |  |
| ProviderName | String |  |
| StorageKey | String |  |
| DesiredColumnNames | Array |  |
| StaticColumns | Array |  |
| Context | String |  |

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
POST /api/v1/Agents/Find/GetSpecifiedCriteriaInformationWithDefaultsWithContext
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StorageType": "aliquam",
  "ProviderName": "Blanda LLC",
  "StorageKey": "tenetur",
  "DesiredColumnNames": [
    "Witting, Schroeder and Grant",
    "Hodkiewicz, Keeling and Treutel"
  ],
  "StaticColumns": [
    "porro",
    "voluptatem"
  ],
  "Context": "temporibus"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Cole Inc and Sons",
      "Operator": "qui",
      "Values": [
        "facere",
        "distinctio"
      ],
      "DisplayValues": [
        "aspernatur",
        "soluta"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 318,
      "InterOperator": "And",
      "UniqueHash": 612
    }
  ],
  "CriteriaArchiveColumns": [
    {
      "DisplayName": "Johnson-Runolfsdottir",
      "DisplayTooltip": "incidunt",
      "DisplayType": "voluptate",
      "CanOrderBy": false,
      "Name": "Treutel LLC",
      "CanRestrictBy": false,
      "RestrictionType": "sunt",
      "RestrictionListName": "Mante LLC",
      "IsVisible": false,
      "ExtraInfo": "magnam",
      "Width": "qui",
      "IconHint": "consequatur",
      "HeadingIconHint": "explicabo"
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "Tromp-Mueller",
      "PrimaryKey": 635,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "non",
          "TooltipHint": "quasi",
          "LinkHint": "modi"
        }
      },
      "LinkHint": "quia",
      "StyleHint": "ipsum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 89
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Langworth-Casper",
      "Description": "Inverse zero tolerance definition",
      "Rank": 555,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Langworth-Casper",
      "Description": "Inverse zero tolerance definition",
      "Rank": 555,
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
      "FieldLength": 657
    }
  }
}
```