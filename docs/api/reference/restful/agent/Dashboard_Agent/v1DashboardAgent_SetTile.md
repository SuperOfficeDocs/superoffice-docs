---
title: POST Agents/Dashboard/SetTile
uid: v1DashboardAgent_SetTile
---

# POST Agents/Dashboard/SetTile

```http
POST /api/v1/Agents/Dashboard/SetTile
```

Sets tile in the given dashboard position







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dashboard/SetTile?$select=name,department,category/id
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

DashboardId, TileId, Position 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 |  |
| TileId | int32 |  |
| Position | int32 |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 | The dashboard id |
| AssociateId | int32 | Id of the associate who owns this dashboard |
| Caption | string | The caption for this dashboard |
| Layout | string | The dashboard layout, how the tiles are organized on the screen |
| Tiles | array | The tiles associated with this dashboard |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Dashboard/SetTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 53,
  "TileId": 968,
  "Position": 489
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 186,
  "AssociateId": 71,
  "Caption": "eaque",
  "Layout": "Four",
  "Tiles": [
    {
      "DashboardTileId": 141,
      "Caption": "illum",
      "Description": "Enterprise-wide uniform implementation",
      "ChartName": "Schuppe Inc and Sons",
      "ChartId": "iste",
      "IsDefault": false,
      "AssociateId": 573,
      "GroupId": 222,
      "SelectionId": 808,
      "Config": "ad",
      "Type": "Bignum",
      "EntityType": "Activity",
      "Options": [
        {},
        {}
      ],
      "VisibleFor": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 838
    }
  }
}
```