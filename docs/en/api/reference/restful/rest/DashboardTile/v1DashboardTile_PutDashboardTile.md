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
  "DashboardTileId": 824,
  "Caption": "sit",
  "Description": "Advanced zero tolerance encoding",
  "ChartName": "Schultz, Moore and Von",
  "ChartId": "quo",
  "IsDefault": false,
  "AssociateId": 862,
  "GroupId": 612,
  "SelectionId": 357,
  "Config": "et",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Ledner-Dietrich",
      "Description": "Persistent transitional monitoring",
      "Type": "Boolean",
      "ListName": "Nolan-Homenick",
      "ListItems": [
        {},
        {}
      ],
      "Value": "aspernatur",
      "DefaultDataOption": false
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 786,
      "Visibility": "All",
      "DisplayValue": "nihil"
    },
    {
      "VisibleId": 786,
      "Visibility": "All",
      "DisplayValue": "nihil"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 DashboardTile updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 650,
  "Caption": "consequatur",
  "Description": "Re-contextualized responsive attitude",
  "ChartName": "Hand-Adams",
  "ChartId": "vitae",
  "IsDefault": true,
  "AssociateId": 181,
  "GroupId": 69,
  "SelectionId": 269,
  "Config": "laudantium",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Parker LLC",
      "Description": "Sharable neutral benchmark",
      "Type": "Boolean",
      "ListName": "Weimann LLC",
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
          "FieldLength": 281
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 112,
      "Visibility": "All",
      "DisplayValue": "repudiandae",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 224
        }
      }
    },
    {
      "VisibleId": 112,
      "Visibility": "All",
      "DisplayValue": "repudiandae",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 224
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 810
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```