---
title: POST Agents/Dashboard/SaveDashboard
id: v1DashboardAgent_SaveDashboard
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

## Response: object

Dashboard configuration

Carrier object for Dashboard.
Services for the Dashboard Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDashboardAgent">Dashboard Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 | The dashboard id |
| AssociateId | int32 | Id of the associate who owns this dashboard |
| Caption | string | The caption for this dashboard |
| Layout | string | The dashboard layout, how the tiles are organized on the screen |
| Tiles | array | The tiles associated with this dashboard |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Dashboard/SaveDashboard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 758,
  "AssociateId": 453,
  "Caption": "libero",
  "Layout": "Four",
  "Tiles": [
    {
      "DashboardTileId": 371,
      "Caption": "dignissimos",
      "Description": "Exclusive logistical moderator",
      "ChartName": "O'Hara LLC",
      "ChartId": "quia",
      "IsDefault": true,
      "AssociateId": 297,
      "GroupId": 636,
      "SelectionId": 21,
      "Config": "odio",
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

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 135,
  "AssociateId": 940,
  "Caption": "ut",
  "Layout": "Four",
  "Tiles": [
    {
      "DashboardTileId": 620,
      "Caption": "debitis",
      "Description": "Streamlined modular knowledge user",
      "ChartName": "Kassulke-Hills",
      "ChartId": "dolore",
      "IsDefault": true,
      "AssociateId": 20,
      "GroupId": 583,
      "SelectionId": 831,
      "Config": "provident",
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
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 242
        }
      }
    }
  ],
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
      "FieldLength": 355
    }
  }
}
```
