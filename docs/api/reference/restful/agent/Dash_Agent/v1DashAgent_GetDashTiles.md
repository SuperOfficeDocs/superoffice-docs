---
title: POST Agents/Dash/GetDashTiles
id: v1DashAgent_GetDashTiles
---

# POST Agents/Dash/GetDashTiles

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 286
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DashboardTileId": 500,
    "DashboardId": 977,
    "Height": 47,
    "Width": 513,
    "Rank": 991,
    "DashTileDefinition": {
      "DashboardTileDefinitionId": 783,
      "Name": "Torphy-Marvin",
      "Description": "Polarised neutral solution",
      "DefaultHeight": 462,
      "DefaultWidth": 758,
      "TileType": "Area",
      "EntityType": "Appointment",
      "EntityName": "Swift-Rosenbaum",
      "SelectionId": 981,
      "CurrencyMode": "Base",
      "CurrencyCode": "repellendus",
      "Measure": "Average",
      "MeasureField": "unde",
      "SortBy": "et",
      "LayoutConfig": "quia",
      "SecondarySelectionId": 176,
      "MeasureByField": "eum",
      "ProviderName": "Thiel LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "redefine compelling technologies"
          },
          "FieldType": "System.String",
          "FieldLength": 565
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
        "FieldLength": 477
      }
    }
  }
]
```