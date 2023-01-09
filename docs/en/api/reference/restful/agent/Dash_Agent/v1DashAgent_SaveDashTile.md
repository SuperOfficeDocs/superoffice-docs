---
title: POST Agents/Dash/SaveDashTile
uid: v1DashAgent_SaveDashTile
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
| DashboardTileId | Integer | Primary key |
| DashboardId | Integer | The associated dashboard |
| Height | Integer | Height used by this tile in the dashboard |
| Width | Integer | Width used by this tile in the dashboard |
| Rank | Integer | Rank order |
| DashTileDefinition | DashTileDefinition | The tile definition entity |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: DashTile

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 | Primary key |
| DashboardId | int32 | The associated dashboard |
| Height | int32 | Height used by this tile in the dashboard |
| Width | int32 | Width used by this tile in the dashboard |
| Rank | int32 | Rank order |
| DashTileDefinition | DashTileDefinition | The tile definition entity |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Dash/SaveDashTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 973,
  "DashboardId": 620,
  "Height": 781,
  "Width": 178,
  "Rank": 999,
  "DashTileDefinition": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 492,
  "DashboardId": 53,
  "Height": 437,
  "Width": 112,
  "Rank": 665,
  "DashTileDefinition": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 749
    }
  }
}
```