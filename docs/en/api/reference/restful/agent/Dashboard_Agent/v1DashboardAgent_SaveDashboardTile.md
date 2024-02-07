---
title: POST Agents/Dashboard/SaveDashboardTile
uid: v1DashboardAgent_SaveDashboardTile
generated: true
---

# POST Agents/Dashboard/SaveDashboardTile

```http
POST /api/v1/Agents/Dashboard/SaveDashboardTile
```

Updates the existing DashboardTile or creates a new DashboardTile if the id parameter is empty








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

## Request Body: entity 

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

### Response body: DashboardTile

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

## Sample request

```http!
POST /api/v1/Agents/Dashboard/SaveDashboardTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 862,
  "Caption": "error",
  "Description": "Ergonomic zero administration collaboration",
  "ChartName": "Johns-Durgan",
  "ChartId": "exercitationem",
  "IsDefault": true,
  "AssociateId": 889,
  "GroupId": 893,
  "SelectionId": 964,
  "Config": "in",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Wisozk Inc and Sons",
      "Description": "Devolved non-volatile definition",
      "Type": "Boolean",
      "ListName": "Stiedemann, Willms and Hilpert",
      "ListItems": [
        {},
        {}
      ],
      "Value": "voluptatum",
      "DefaultDataOption": false
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 359,
      "Visibility": "All",
      "DisplayValue": "laudantium"
    },
    {
      "VisibleId": 359,
      "Visibility": "All",
      "DisplayValue": "laudantium"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 759,
  "Caption": "minima",
  "Description": "Innovative homogeneous installation",
  "ChartName": "Bradtke LLC",
  "ChartId": "sed",
  "IsDefault": true,
  "AssociateId": 975,
  "GroupId": 960,
  "SelectionId": 932,
  "Config": "similique",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Heller Inc and Sons",
      "Description": "Object-based web-enabled throughput",
      "Type": "Boolean",
      "ListName": "Douglas Group",
      "ListItems": [
        {},
        {}
      ],
      "Value": "harum",
      "DefaultDataOption": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 103
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 846,
      "Visibility": "All",
      "DisplayValue": "enim",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    },
    {
      "VisibleId": 846,
      "Visibility": "All",
      "DisplayValue": "enim",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 14
    }
  }
}
```