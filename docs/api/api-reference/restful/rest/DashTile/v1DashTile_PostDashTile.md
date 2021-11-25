---
title: POST DashTile
id: v1DashTile_PostDashTile
---

# POST DashTile

```http
POST /api/v1/DashTile
```

Creates a new DashTile

Calls the Dash agent service SaveDashTile.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/DashTile?$select=name,department,category/id
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

The DashTile to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 | Primary key |
| DashboardId | int32 | The associated dashboard |
| Height | int32 | Height used by this tile in the dashboard |
| Width | int32 | Width used by this tile in the dashboard |
| Rank | int32 | Rank order |
| DashTileDefinition |  | The tile definition entity |


## Response: object

Dashboard Tile configuration



DashTile entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 | Primary key |
| DashboardId | int32 | The associated dashboard |
| Height | int32 | Height used by this tile in the dashboard |
| Width | int32 | Width used by this tile in the dashboard |
| Rank | int32 | Rank order |
| DashTileDefinition |  | The tile definition entity |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/DashTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 71,
  "DashboardId": 995,
  "Height": 368,
  "Width": 423,
  "Rank": 779,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 281,
    "Name": "Klein-Stehr",
    "Description": "Total 24/7 Graphical User Interface",
    "DefaultHeight": 373,
    "DefaultWidth": 421,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Harvey-Mueller",
    "SelectionId": 183,
    "CurrencyMode": "Base",
    "CurrencyCode": "voluptate",
    "Measure": "Average",
    "MeasureField": "quo",
    "SortBy": "voluptatibus",
    "LayoutConfig": "cupiditate",
    "SecondarySelectionId": 870,
    "MeasureByField": "ipsa",
    "ProviderName": "Crist, Braun and Wuckert"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 328,
  "DashboardId": 987,
  "Height": 840,
  "Width": 1001,
  "Rank": 522,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 970,
    "Name": "Boehm-Ankunding",
    "Description": "Intuitive multi-tasking encryption",
    "DefaultHeight": 786,
    "DefaultWidth": 365,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Kirlin Inc and Sons",
    "SelectionId": 399,
    "CurrencyMode": "Base",
    "CurrencyCode": "accusamus",
    "Measure": "Average",
    "MeasureField": "maiores",
    "SortBy": "aliquid",
    "LayoutConfig": "recusandae",
    "SecondarySelectionId": 563,
    "MeasureByField": "dolores",
    "ProviderName": "Reinger-Huels",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 289
      }
    }
  },
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
      "FieldLength": 977
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```