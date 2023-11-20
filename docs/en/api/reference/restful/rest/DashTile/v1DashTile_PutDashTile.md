---
title: PUT DashTile/{id}
uid: v1DashTile_PutDashTile
generated: true
---

# PUT DashTile/{id}

```http
PUT /api/v1/DashTile/{id}
```

Updates the existing DashTile






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DashTile id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/DashTile/{id}?$select=name,department,category/id
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

DashTile updated.

| Response | Description |
|----------------|-------------|
| 200 | DashTile updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: DashTileWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 | Primary key |
| DashboardId | int32 | The associated dashboard |
| Height | int32 | Height used by this tile in the dashboard |
| Width | int32 | Width used by this tile in the dashboard |
| Rank | int32 | Rank order |
| DashTileDefinition | DashTileDefinition | The tile definition entity |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/DashTile/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 442,
  "DashboardId": 678,
  "Height": 796,
  "Width": 527,
  "Rank": 83,
  "DashTileDefinition": null
}
```

## Sample response

```http_
HTTP/1.1 200 DashTile updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 104,
  "DashboardId": 910,
  "Height": 769,
  "Width": 302,
  "Rank": 734,
  "DashTileDefinition": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 570
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```