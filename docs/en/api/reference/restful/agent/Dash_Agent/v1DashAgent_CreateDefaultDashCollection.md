---
title: POST Agents/Dash/CreateDefaultDashCollection
uid: v1DashAgent_CreateDefaultDashCollection
---

# POST Agents/Dash/CreateDefaultDashCollection

```http
POST /api/v1/Agents/Dash/CreateDefaultDashCollection
```

Set default values into a new DashCollection.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: DashCollection

| Property Name | Type |  Description |
|----------------|------|--------------|
| Pinned | array | Dashboards pinned to the associate |
| Favourites | array | The assocates favourite dashboards |
| Other | array | Other dashboards |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Dash/CreateDefaultDashCollection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 197,
      "UniqueId": "possimus",
      "Name": "Maggio, Doyle and Bahringer",
      "Description": "Multi-channelled full-range knowledge user",
      "AssociateId": 441,
      "Columns": 843,
      "Theme": null,
      "VisibleForAll": 207,
      "VisibleForAssociates": [
        565,
        691
      ],
      "VisibleForGroups": [
        955,
        401
      ],
      "PinForAll": 61,
      "PinForAssociates": [
        857,
        14
      ],
      "PinForGroups": [
        66,
        476
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 469
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 600,
      "UniqueId": "quas",
      "Name": "Kris LLC",
      "Description": "Compatible systematic success",
      "AssociateId": 880,
      "Columns": 197,
      "Theme": null,
      "VisibleForAll": 103,
      "VisibleForAssociates": [
        520,
        587
      ],
      "VisibleForGroups": [
        549,
        154
      ],
      "PinForAll": 514,
      "PinForAssociates": [
        469,
        779
      ],
      "PinForGroups": [
        285,
        990
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 247
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 875,
      "UniqueId": "alias",
      "Name": "Funk, Stanton and Jenkins",
      "Description": "Optional stable success",
      "AssociateId": 305,
      "Columns": 457,
      "Theme": null,
      "VisibleForAll": 788,
      "VisibleForAssociates": [
        246,
        347
      ],
      "VisibleForGroups": [
        357,
        203
      ],
      "PinForAll": 713,
      "PinForAssociates": [
        623,
        57
      ],
      "PinForGroups": [
        320,
        393
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 742
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 183
    }
  }
}
```