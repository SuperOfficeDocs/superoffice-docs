---
title: PUT DashboardTile/{id}
id: v1DashboardTile_PutDashboardTile
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


## Response: object

Dashboard Tile configuration



DashboardTile entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | DashboardTile updated. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/DashboardTile/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 846,
  "Caption": "atque",
  "Description": "Managed homogeneous knowledge user",
  "ChartName": "Reilly-Armstrong",
  "ChartId": "iste",
  "IsDefault": false,
  "AssociateId": 497,
  "GroupId": 457,
  "SelectionId": 177,
  "Config": "voluptatibus",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Feest Inc and Sons",
      "Description": "Digitized assymetric hierarchy",
      "Type": "Boolean",
      "ListName": "Rau-Schamberger",
      "ListItems": [
        {},
        {}
      ],
      "Value": "eum",
      "DefaultDataOption": true
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 955,
      "Visibility": "All",
      "DisplayValue": "ut"
    },
    {
      "VisibleId": 955,
      "Visibility": "All",
      "DisplayValue": "ut"
    }
  ]
}
```

```http_
HTTP/1.1 200 DashboardTile updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 81,
  "Caption": "quae",
  "Description": "Organized client-driven throughput",
  "ChartName": "Rutherford-Ratke",
  "ChartId": "quasi",
  "IsDefault": false,
  "AssociateId": 459,
  "GroupId": 556,
  "SelectionId": 901,
  "Config": "commodi",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Roob, Douglas and Kling",
      "Description": "Programmable optimizing help-desk",
      "Type": "Boolean",
      "ListName": "Morar-Smith",
      "ListItems": [
        {},
        {}
      ],
      "Value": "eos",
      "DefaultDataOption": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 765
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 100,
      "Visibility": "All",
      "DisplayValue": "explicabo",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 689
        }
      }
    },
    {
      "VisibleId": 100,
      "Visibility": "All",
      "DisplayValue": "explicabo",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 689
        }
      }
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
      "FieldLength": 982
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```