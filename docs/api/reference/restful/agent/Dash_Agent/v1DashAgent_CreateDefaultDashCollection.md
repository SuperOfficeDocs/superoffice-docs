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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| Pinned | array | Dashboards pinned to the associate |
| Favourites | array | The assocates favourite dashboards |
| Other | array | Other dashboards |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Dash/CreateDefaultDashCollection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 763,
      "UniqueId": "eum",
      "Name": "Schultz-Rice",
      "Description": "Monitored reciprocal open system",
      "AssociateId": 72,
      "Columns": 509,
      "Theme": null,
      "VisibleForAll": 230,
      "VisibleForAssociates": [
        634,
        515
      ],
      "VisibleForGroups": [
        573,
        897
      ],
      "PinForAll": 534,
      "PinForAssociates": [
        392,
        881
      ],
      "PinForGroups": [
        668,
        509
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 584,
      "UniqueId": "assumenda",
      "Name": "Bogan, Wiegand and Roob",
      "Description": "Fully-configurable foreground algorithm",
      "AssociateId": 431,
      "Columns": 615,
      "Theme": null,
      "VisibleForAll": 282,
      "VisibleForAssociates": [
        348,
        321
      ],
      "VisibleForGroups": [
        471,
        855
      ],
      "PinForAll": 656,
      "PinForAssociates": [
        61,
        41
      ],
      "PinForGroups": [
        371,
        288
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 980
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 620,
      "UniqueId": "aliquid",
      "Name": "Hermann, Smitham and Grimes",
      "Description": "Implemented content-based open architecture",
      "AssociateId": 449,
      "Columns": 427,
      "Theme": null,
      "VisibleForAll": 451,
      "VisibleForAssociates": [
        265,
        547
      ],
      "VisibleForGroups": [
        378,
        367
      ],
      "PinForAll": 407,
      "PinForAssociates": [
        66,
        391
      ],
      "PinForGroups": [
        85,
        405
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 531
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 236
    }
  }
}
```
