---
title: POST Agents/Dashboard/SaveDashboard
uid: v1DashboardAgent_SaveDashboard
generated: true
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
| DashboardId | Integer | The dashboard id |
| AssociateId | Integer | Id of the associate who owns this dashboard |
| Caption | String | The caption for this dashboard |
| Layout | String | The dashboard layout, how the tiles are organized on the screen |
| Tiles | Array | The tiles associated with this dashboard |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: Dashboard

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 | The dashboard id |
| AssociateId | int32 | Id of the associate who owns this dashboard |
| Caption | string | The caption for this dashboard |
| Layout | string | The dashboard layout, how the tiles are organized on the screen |
| Tiles | array | The tiles associated with this dashboard |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Dashboard/SaveDashboard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 296,
  "AssociateId": 331,
  "Caption": "quaerat",
  "Layout": "Four",
  "Tiles": [
    {
      "DashboardTileId": 685,
      "Caption": "consequatur",
      "Description": "Customer-focused actuating product",
      "ChartName": "Lehner, Anderson and Stanton",
      "ChartId": "voluptatem",
      "IsDefault": false,
      "AssociateId": 377,
      "GroupId": 648,
      "SelectionId": 939,
      "Config": "veritatis",
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
  "DashboardId": 552,
  "AssociateId": 208,
  "Caption": "qui",
  "Layout": "Four",
  "Tiles": [
    {
      "DashboardTileId": 744,
      "Caption": "et",
      "Description": "Profit-focused dynamic collaboration",
      "ChartName": "Strosin Group",
      "ChartId": "sunt",
      "IsDefault": false,
      "AssociateId": 803,
      "GroupId": 252,
      "SelectionId": 740,
      "Config": "perspiciatis",
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
          "FieldLength": 388
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 445
    }
  }
}
```