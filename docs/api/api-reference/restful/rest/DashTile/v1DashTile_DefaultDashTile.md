---
title: GET DashTile/default
id: v1DashTile_DefaultDashTile
---

# GET DashTile/default

```http
GET /api/v1/DashTile/default
```

Set default values into a new DashTile.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Dash agent service CreateDefaultDashTile.






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
GET /api/v1/DashTile/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 158,
  "DashboardId": 644,
  "Height": 649,
  "Width": 14,
  "Rank": 707,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 161,
    "Name": "Heller Group",
    "Description": "Networked actuating hardware",
    "DefaultHeight": 873,
    "DefaultWidth": 281,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Gutmann, Berge and Brown",
    "SelectionId": 85,
    "CurrencyMode": "Base",
    "CurrencyId": 563,
    "Measure": "Average",
    "MeasureField": "reiciendis",
    "SortBy": "voluptas",
    "LayoutConfig": "distinctio",
    "SecondarySelectionId": 605,
    "MeasureByField": "id",
    "ProviderName": "Gleason Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 906
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
      "FieldLength": 556
    }
  }
}
```