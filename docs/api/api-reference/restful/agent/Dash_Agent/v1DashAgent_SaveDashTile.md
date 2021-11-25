---
title: POST Agents/Dash/SaveDashTile
id: v1DashAgent_SaveDashTile
---

# POST Agents/Dash/SaveDashTile

```http
POST /api/v1/Agents/Dash/SaveDashTile
```

Updates the existing DashTile or creates a new DashTile if the id parameter is empty








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



Carrier object for DashTile.
Services for the DashTile Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDashAgent">Dash Agent</see>.

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

## Sample Request

```http!
POST /api/v1/Agents/Dash/SaveDashTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 327,
  "DashboardId": 178,
  "Height": 413,
  "Width": 680,
  "Rank": 245,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 961,
    "Name": "Mayert-Schiller",
    "Description": "Networked 6th generation architecture",
    "DefaultHeight": 389,
    "DefaultWidth": 673,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Waelchi, Huel and Bauch",
    "SelectionId": 702,
    "CurrencyMode": "Base",
    "CurrencyCode": "soluta",
    "Measure": "Average",
    "MeasureField": "sit",
    "SortBy": "repudiandae",
    "LayoutConfig": "corporis",
    "SecondarySelectionId": 612,
    "MeasureByField": "sed",
    "ProviderName": "Witting-Conn"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 54,
  "DashboardId": 509,
  "Height": 450,
  "Width": 591,
  "Rank": 114,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 219,
    "Name": "Pfannerstill LLC",
    "Description": "Re-contextualized optimal standardization",
    "DefaultHeight": 530,
    "DefaultWidth": 552,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Kunde-Fritsch",
    "SelectionId": 20,
    "CurrencyMode": "Base",
    "CurrencyCode": "ea",
    "Measure": "Average",
    "MeasureField": "fuga",
    "SortBy": "veniam",
    "LayoutConfig": "accusantium",
    "SecondarySelectionId": 494,
    "MeasureByField": "aut",
    "ProviderName": "Moore, Emard and Ritchie",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 2
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
      "FieldLength": 963
    }
  }
}
```