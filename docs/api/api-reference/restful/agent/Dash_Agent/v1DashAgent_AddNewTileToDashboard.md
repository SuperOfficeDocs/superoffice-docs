---
title: POST Agents/Dash/AddNewTileToDashboard
id: v1DashAgent_AddNewTileToDashboard
---

# POST Agents/Dash/AddNewTileToDashboard

```http
POST /api/v1/Agents/Dash/AddNewTileToDashboard
```

Add a new tile to a dashboard with next rank







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dash/AddNewTileToDashboard?$select=name,department,category/id
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

DashboardId, DashTileDefinition 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 |  |
| DashTileDefinition |  | Dashboard Tile definition <para /> Carrier object for DashTileDefinition. Services for the DashTileDefinition Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDashAgent">Dash Agent</see>. |


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
POST /api/v1/Agents/Dash/AddNewTileToDashboard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 403,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 787,
    "Name": "Abernathy, Murray and Bayer",
    "Description": "Managed zero tolerance service-desk",
    "DefaultHeight": 285,
    "DefaultWidth": 82,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Kub Group",
    "SelectionId": 931,
    "CurrencyMode": "Base",
    "CurrencyCode": "necessitatibus",
    "Measure": "Average",
    "MeasureField": "nobis",
    "SortBy": "autem",
    "LayoutConfig": "ut",
    "SecondarySelectionId": 192,
    "MeasureByField": "et",
    "ProviderName": "Berge-Streich"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 549,
  "DashboardId": 294,
  "Height": 737,
  "Width": 958,
  "Rank": 968,
  "DashTileDefinition": {
    "DashboardTileDefinitionId": 449,
    "Name": "Lakin, Nienow and Wilderman",
    "Description": "Synchronised tertiary time-frame",
    "DefaultHeight": 69,
    "DefaultWidth": 980,
    "TileType": "Area",
    "EntityType": "Appointment",
    "EntityName": "Klocko Inc and Sons",
    "SelectionId": 649,
    "CurrencyMode": "Base",
    "CurrencyCode": "quia",
    "Measure": "Average",
    "MeasureField": "et",
    "SortBy": "omnis",
    "LayoutConfig": "praesentium",
    "SecondarySelectionId": 581,
    "MeasureByField": "architecto",
    "ProviderName": "Weissnat-Renner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 336
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
      "FieldLength": 4
    }
  }
}
```