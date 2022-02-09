---
title: POST Agents/Dash/CreateDefaultTileForEntity
id: v1DashAgent_CreateDefaultTileForEntity
---

# POST Agents/Dash/CreateDefaultTileForEntity

```http
POST /api/v1/Agents/Dash/CreateDefaultTileForEntity
```

Set Measure to CountAll and MeasureField to primary key field







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dash/CreateDefaultTileForEntity?$select=name,department,category/id
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

EntityName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EntityName | string |  |


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
POST /api/v1/Agents/Dash/CreateDefaultTileForEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EntityName": "Kirlin LLC"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 417,
  "DashboardId": 863,
  "Height": 435,
  "Width": 404,
  "Rank": 68,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 489,
    "Name": "Hermiston LLC",
    "Description": "Enterprise-wide bi-directional conglomeration",
    "DefaultHeight": 230,
    "DefaultWidth": 140,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Ledner Inc and Sons",
    "SelectionId": 617,
    "CurrencyMode": "Base",
    "CurrencyCode": "doloremque",
    "Measure": "Average",
    "MeasureField": "voluptas",
    "SortBy": "voluptate",
    "LayoutConfig": "explicabo",
    "SecondarySelectionId": 973,
    "MeasureByField": "vero",
    "ProviderName": "McDermott-Kessler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 135
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
      "FieldLength": 651
    }
  }
}
```