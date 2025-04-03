---
title: POST DashboardTile
uid: v1DashboardTile_PostDashboardTile
generated: true
---

# POST DashboardTile

```http
POST /api/v1/DashboardTile
```

Creates a new DashboardTile


Calls the Dashboard agent service SaveDashboardTile.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/DashboardTile?$select=name,department,category/id
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

## Request Body: newEntity 

The DashboardTile to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | Integer | The tile id |
| Caption | String | The tile caption |
| Description | String | The tile description |
| ChartName | String | The original chart name |
| ChartId | String | The original chart Id |
| IsDefault | Boolean | True if this is one of the default tiles |
| AssociateId | Integer | Id of the associate who owns this tile |
| GroupId | Integer | Id of the associates primary group at storage time |
| SelectionId | Integer | The selection that defines the data filter/restrictions |
| Config | String | The tile config |
| Type | String | The tile type, what kind of tile this is |
| EntityType | String | The tile entity type |
| Options | Array | The tile options |
| VisibleFor | Array | The set of users or groups the record is visible for |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: DashboardTileWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 | The tile id |
| Caption | string | The tile caption |
| Description | string | The tile description |
| ChartName | string | The original chart name |
| ChartId | string | The original chart Id |
| IsDefault | bool | True if this is one of the default tiles |
| AssociateId | int32 | Id of the associate who owns this tile |
| GroupId | int32 | Id of the associates primary group at storage time |
| SelectionId | int32 | The selection that defines the data filter/restrictions |
| Config | string | The tile config |
| Type | string | The tile type, what kind of tile this is |
| EntityType | string | The tile entity type |
| Options | array | The tile options |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/DashboardTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 234,
  "Caption": "quia",
  "Description": "Function-based regional help-desk",
  "ChartName": "Schamberger, Thompson and Wiegand",
  "ChartId": "illo",
  "IsDefault": false,
  "AssociateId": 783,
  "GroupId": 913,
  "SelectionId": 142,
  "Config": "architecto",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Hessel Inc and Sons",
      "Description": "Secured homogeneous secured line",
      "Type": "Boolean",
      "ListName": "Feeney, Abernathy and Wiza",
      "ListItems": [
        {},
        {}
      ],
      "Value": "tenetur",
      "DefaultDataOption": false
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 177,
      "Visibility": "All",
      "DisplayValue": "nam"
    },
    {
      "VisibleId": 177,
      "Visibility": "All",
      "DisplayValue": "nam"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 749,
  "Caption": "ut",
  "Description": "Managed background paradigm",
  "ChartName": "Boehm, Reichel and Cronin",
  "ChartId": "fugit",
  "IsDefault": false,
  "AssociateId": 890,
  "GroupId": 846,
  "SelectionId": 569,
  "Config": "consectetur",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Murphy-O'Connell",
      "Description": "Ameliorated multi-tasking alliance",
      "Type": "Boolean",
      "ListName": "Jacobi, D'Amore and Blick",
      "ListItems": [
        {},
        {}
      ],
      "Value": "eum",
      "DefaultDataOption": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 684
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 272,
      "Visibility": "All",
      "DisplayValue": "quidem",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 411
        }
      }
    },
    {
      "VisibleId": 272,
      "Visibility": "All",
      "DisplayValue": "quidem",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 411
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 73
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```