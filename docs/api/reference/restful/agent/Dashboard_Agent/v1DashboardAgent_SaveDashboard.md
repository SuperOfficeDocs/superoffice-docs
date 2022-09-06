---
title: POST Agents/Dashboard/SaveDashboard
uid: v1DashboardAgent_SaveDashboard
---

# POST Agents/Dashboard/SaveDashboard

```http
POST /api/v1/Agents/Dashboard/SaveDashboard
```

Updates the existing Dashboard or creates a new Dashboard if the id parameter is empty

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

The Dashboard to be saved.

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 | The dashboard id |
| AssociateId | int32 | Id of the associate who owns this dashboard |
| Caption | string | The caption for this dashboard |
| Layout | string | The dashboard layout, how the tiles are organized on the screen |
| Tiles | array | The tiles associated with this dashboard |

## Response

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
POST /api/v1/Agents/Dashboard/SaveDashboard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 824,
  "AssociateId": 999,
  "Caption": "voluptates",
  "Layout": "Four",
  "Tiles": [
    {
      "DashboardTileId": 873,
      "Caption": "ipsum",
      "Description": "Ergonomic zero tolerance open system",
      "ChartName": "Lindgren, Davis and Ryan",
      "ChartId": "culpa",
      "IsDefault": true,
      "AssociateId": 254,
      "GroupId": 847,
      "SelectionId": 59,
      "Config": "quod",
      "Type": "Bignum",
      "EntityType": "Activity",
      "Options": [
        {},
        {}
      ],
      "VisibleFor": [
        {},
        {}
      ]
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 87,
  "AssociateId": 256,
  "Caption": "itaque",
  "Layout": "Four",
  "Tiles": [
    {
      "DashboardTileId": 459,
      "Caption": "illum",
      "Description": "Extended assymetric instruction set",
      "ChartName": "Kuhic Group",
      "ChartId": "rerum",
      "IsDefault": true,
      "AssociateId": 134,
      "GroupId": 555,
      "SelectionId": 134,
      "Config": "laboriosam",
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
          "FieldLength": 637
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 420
    }
  }
}
```
