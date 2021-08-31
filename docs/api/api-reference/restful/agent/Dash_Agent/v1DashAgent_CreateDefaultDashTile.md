---
title: CreateDefaultDashTile
id: v1DashAgent_CreateDefaultDashTile
---

# CreateDefaultDashTile

```http
POST /api/v1/Agents/Dash/CreateDefaultDashTile
```

Set default values into a new DashTile.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Dash/CreateDefaultDashTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 56,
  "DashboardId": 898,
  "Height": 800,
  "Width": 573,
  "Rank": 695,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 269,
    "Name": "Johnson-Lindgren",
    "Description": "Re-contextualized next generation Graphic Interface",
    "DefaultHeight": 56,
    "DefaultWidth": 243,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Kutch Group",
    "SelectionId": 662,
    "CurrencyMode": "Base",
    "CurrencyId": 954,
    "Measure": "Average",
    "MeasureField": "eum",
    "SortBy": "consectetur",
    "LayoutConfig": "qui",
    "SecondarySelectionId": 581,
    "MeasureByField": "sed",
    "ProviderName": "Dickinson, O'Hara and Rau",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 60
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
        "Reason": "reinvent rich initiatives"
      },
      "FieldType": "System.String",
      "FieldLength": 553
    }
  }
}
```