---
title: GetDashTiles
id: v1DashAgent_GetDashTiles
---

# GetDashTiles

```http
POST /api/v1/Agents/Dash/GetDashTiles
```

Gets the ordered list of tiles for a dashboard







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dash/GetDashTiles?$select=name,department,category/id
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

## Request Body: request  

DashboardId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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

## Sample Request

```http!
POST /api/v1/Agents/Dash/GetDashTiles
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 52
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DashboardTileId": 640,
    "DashboardId": 281,
    "Height": 215,
    "Width": 492,
    "Rank": 154,
    "DashTileDefinition": {
      "DashboardTileDefinitionId": 947,
      "Name": "Reichert Group",
      "Description": "Re-contextualized actuating local area network",
      "DefaultHeight": 791,
      "DefaultWidth": 502,
      "TileType": "Area",
      "EntityType": "Appointment",
      "EntityName": "Beahan, Glover and Kuphal",
      "SelectionId": 910,
      "CurrencyMode": "Base",
      "CurrencyId": 1000,
      "Measure": "Average",
      "MeasureField": "cupiditate",
      "SortBy": "vel",
      "LayoutConfig": "aut",
      "SecondarySelectionId": 315,
      "MeasureByField": "quis",
      "ProviderName": "Glover-Rempel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 680
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
          "Reason": "matrix frictionless users"
        },
        "FieldType": "System.Int32",
        "FieldLength": 509
      }
    }
  }
]
```