---
title: GetDashTile
id: v1DashAgent_GetDashTile
---

# GetDashTile

```http
POST /api/v1/Agents/Dash/GetDashTile
```

Gets a DashTile object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| dashTileId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dash/GetDashTile?dashTileId=833
POST /api/v1/Agents/Dash/GetDashTile?$select=name,department,category/id
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
POST /api/v1/Agents/Dash/GetDashTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 585,
  "DashboardId": 74,
  "Height": 969,
  "Width": 163,
  "Rank": 774,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 124,
    "Name": "Cassin, Donnelly and West",
    "Description": "Multi-lateral even-keeled knowledge base",
    "DefaultHeight": 186,
    "DefaultWidth": 636,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Armstrong Inc and Sons",
    "SelectionId": 432,
    "CurrencyMode": "Base",
    "CurrencyId": 988,
    "Measure": "Average",
    "MeasureField": "repudiandae",
    "SortBy": "et",
    "LayoutConfig": "beatae",
    "SecondarySelectionId": 546,
    "MeasureByField": "cumque",
    "ProviderName": "Green Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 364
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
      "FieldLength": 521
    }
  }
}
```