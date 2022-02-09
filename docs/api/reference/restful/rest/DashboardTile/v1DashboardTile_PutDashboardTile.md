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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 60,
  "Caption": "nesciunt",
  "Description": "De-engineered bi-directional superstructure",
  "ChartName": "Deckow, Hills and Daugherty",
  "ChartId": "assumenda",
  "IsDefault": true,
  "AssociateId": 46,
  "GroupId": 93,
  "SelectionId": 873,
  "Config": "nostrum",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Kuvalis, Lang and Rogahn",
      "Description": "Object-based asynchronous concept",
      "Type": "Boolean",
      "ListName": "Renner Inc and Sons",
      "ListItems": [
        {},
        {}
      ],
      "Value": "eius",
      "DefaultDataOption": false
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 213,
      "Visibility": "All",
      "DisplayValue": "sint"
    },
    {
      "VisibleId": 213,
      "Visibility": "All",
      "DisplayValue": "sint"
    }
  ]
}
```

```http_
HTTP/1.1 200 DashboardTile updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 169,
  "Caption": "id",
  "Description": "Implemented encompassing info-mediaries",
  "ChartName": "Olson, Eichmann and Funk",
  "ChartId": "rem",
  "IsDefault": false,
  "AssociateId": 568,
  "GroupId": 600,
  "SelectionId": 429,
  "Config": "quo",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Pouros, Schuster and Konopelski",
      "Description": "Synergized client-server productivity",
      "Type": "Boolean",
      "ListName": "Prosacco Group",
      "ListItems": [
        {},
        {}
      ],
      "Value": "deleniti",
      "DefaultDataOption": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 650
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 238,
      "Visibility": "All",
      "DisplayValue": "inventore",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    },
    {
      "VisibleId": 238,
      "Visibility": "All",
      "DisplayValue": "inventore",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 765
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
      "FieldLength": 988
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```