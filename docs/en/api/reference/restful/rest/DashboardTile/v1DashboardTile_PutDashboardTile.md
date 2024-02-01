---
title: PUT DashboardTile/{id}
uid: v1DashboardTile_PutDashboardTile
generated: true
---

# PUT DashboardTile/{id}

```http
PUT /api/v1/DashboardTile/{id}
```

Updates the existing DashboardTile






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DashboardTile id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/DashboardTile/{id}?$select=name,department,category/id
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

DashboardTile updated.

| Response | Description |
|----------------|-------------|
| 200 | DashboardTile updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/DashboardTile/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 761,
  "Caption": "veritatis",
  "Description": "Persevering leading edge info-mediaries",
  "ChartName": "Hauck-Abernathy",
  "ChartId": "maiores",
  "IsDefault": false,
  "AssociateId": 817,
  "GroupId": 957,
  "SelectionId": 31,
  "Config": "accusantium",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Bednar-Lubowitz",
      "Description": "Down-sized incremental instruction set",
      "Type": "Boolean",
      "ListName": "Jacobson-Davis",
      "ListItems": [
        {},
        {}
      ],
      "Value": "laboriosam",
      "DefaultDataOption": false
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 859,
      "Visibility": "All",
      "DisplayValue": "sunt"
    },
    {
      "VisibleId": 859,
      "Visibility": "All",
      "DisplayValue": "sunt"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 DashboardTile updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 660,
  "Caption": "aliquid",
  "Description": "Vision-oriented discrete internet solution",
  "ChartName": "Ruecker-Kunze",
  "ChartId": "ut",
  "IsDefault": false,
  "AssociateId": 529,
  "GroupId": 384,
  "SelectionId": 404,
  "Config": "dolores",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Windler, Dietrich and Kunde",
      "Description": "Virtual holistic toolset",
      "Type": "Boolean",
      "ListName": "Runolfsson Inc and Sons",
      "ListItems": [
        {},
        {}
      ],
      "Value": "sed",
      "DefaultDataOption": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 601
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 148,
      "Visibility": "All",
      "DisplayValue": "facere",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 89
        }
      }
    },
    {
      "VisibleId": 148,
      "Visibility": "All",
      "DisplayValue": "facere",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 89
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 501
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```