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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 927,
  "DashboardId": 93,
  "Height": 144,
  "Width": 417,
  "Rank": 850,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 61,
    "Name": "Lang, Donnelly and Blanda",
    "Description": "Enterprise-wide discrete groupware",
    "DefaultHeight": 977,
    "DefaultWidth": 906,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Smith-Wilderman",
    "SelectionId": 641,
    "CurrencyMode": "Base",
    "CurrencyCode": "omnis",
    "Measure": "Average",
    "MeasureField": "consequatur",
    "SortBy": "facere",
    "LayoutConfig": "earum",
    "SecondarySelectionId": 364,
    "MeasureByField": "illum",
    "ProviderName": "Batz, Lockman and Hamill"
  }
}
```

```http_
HTTP/1.1 200 DashTile updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 171,
  "DashboardId": 530,
  "Height": 813,
  "Width": 449,
  "Rank": 771,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 570,
    "Name": "Ortiz LLC",
    "Description": "Visionary scalable support",
    "DefaultHeight": 474,
    "DefaultWidth": 240,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Dietrich, Rosenbaum and Kertzmann",
    "SelectionId": 934,
    "CurrencyMode": "Base",
    "CurrencyCode": "est",
    "Measure": "Average",
    "MeasureField": "beatae",
    "SortBy": "facilis",
    "LayoutConfig": "eligendi",
    "SecondarySelectionId": 849,
    "MeasureByField": "itaque",
    "ProviderName": "Nikolaus-Weissnat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 656
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
      "FieldType": "System.Int32",
      "FieldLength": 881
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```