---
title: PUT DashTile/{id}
id: v1DashTile_PutDashTile
---

# PUT DashTile/{id}

```http
PUT /api/v1/DashTile/{id}
```

Updates the existing DashTile






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DashTile id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/DashTile/{id}?$select=name,department,category/id
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
| 200 | DashTile updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/DashTile/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 874,
  "DashboardId": 752,
  "Height": 414,
  "Width": 11,
  "Rank": 701,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 449,
    "Name": "Jacobi LLC",
    "Description": "Profound eco-centric extranet",
    "DefaultHeight": 548,
    "DefaultWidth": 766,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Prohaska Inc and Sons",
    "SelectionId": 315,
    "CurrencyMode": "Base",
    "CurrencyId": 648,
    "Measure": "Average",
    "MeasureField": "vero",
    "SortBy": "doloremque",
    "LayoutConfig": "ducimus",
    "SecondarySelectionId": 969,
    "MeasureByField": "eius",
    "ProviderName": "Kohler LLC"
  }
}
```

```http_
HTTP/1.1 200 DashTile updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 779,
  "DashboardId": 351,
  "Height": 398,
  "Width": 439,
  "Rank": 721,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 115,
    "Name": "Walter, Eichmann and Hintz",
    "Description": "Open-architected system-worthy info-mediaries",
    "DefaultHeight": 650,
    "DefaultWidth": 41,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Heidenreich Inc and Sons",
    "SelectionId": 498,
    "CurrencyMode": "Base",
    "CurrencyId": 884,
    "Measure": "Average",
    "MeasureField": "saepe",
    "SortBy": "sit",
    "LayoutConfig": "tempore",
    "SecondarySelectionId": 680,
    "MeasureByField": "quos",
    "ProviderName": "Pfannerstill LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 314
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
      "FieldLength": 336
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```