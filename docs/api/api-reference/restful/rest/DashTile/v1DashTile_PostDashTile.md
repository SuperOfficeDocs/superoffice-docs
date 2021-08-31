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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 926,
  "DashboardId": 477,
  "Height": 121,
  "Width": 163,
  "Rank": 565,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 275,
    "Name": "Towne, McCullough and Romaguera",
    "Description": "Cloned demand-driven budgetary management",
    "DefaultHeight": 731,
    "DefaultWidth": 429,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Torphy LLC",
    "SelectionId": 697,
    "CurrencyMode": "Base",
    "CurrencyId": 14,
    "Measure": "Average",
    "MeasureField": "et",
    "SortBy": "sequi",
    "LayoutConfig": "illo",
    "SecondarySelectionId": 64,
    "MeasureByField": "animi",
    "ProviderName": "Bechtelar Inc and Sons"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 600,
  "DashboardId": 949,
  "Height": 126,
  "Width": 198,
  "Rank": 458,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 767,
    "Name": "Shields, Stehr and Jacobi",
    "Description": "Cross-platform 24/7 array",
    "DefaultHeight": 122,
    "DefaultWidth": 823,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Simonis, Gutmann and Witting",
    "SelectionId": 503,
    "CurrencyMode": "Base",
    "CurrencyId": 221,
    "Measure": "Average",
    "MeasureField": "ullam",
    "SortBy": "ea",
    "LayoutConfig": "perspiciatis",
    "SecondarySelectionId": 649,
    "MeasureByField": "tempora",
    "ProviderName": "Roberts, Beer and Koepp",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 845
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
      "FieldLength": 868
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```