---
title: GET DashTile/{id}
id: v1DashTile_GetDashTile
---

# GET DashTile/{id}

```http
GET /api/v1/DashTile/{id}
```

Gets a DashTile object.

Calls the Dash agent service GetDashTile.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the DashTile to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/DashTile/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Dashboard Tile configuration



DashTile entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | DashTile found. |
| 404 | Not Found. |

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
GET /api/v1/DashTile/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 DashTile found.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 957,
  "DashboardId": 661,
  "Height": 853,
  "Width": 679,
  "Rank": 603,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 49,
    "Name": "Rosenbaum, Schowalter and Kihn",
    "Description": "Inverse neutral open system",
    "DefaultHeight": 120,
    "DefaultWidth": 195,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Reichel-Mante",
    "SelectionId": 585,
    "CurrencyMode": "Base",
    "CurrencyId": 228,
    "Measure": "Average",
    "MeasureField": "nostrum",
    "SortBy": "non",
    "LayoutConfig": "rem",
    "SecondarySelectionId": 378,
    "MeasureByField": "eum",
    "ProviderName": "Sipes-Littel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 657
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
      "FieldLength": 138
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```