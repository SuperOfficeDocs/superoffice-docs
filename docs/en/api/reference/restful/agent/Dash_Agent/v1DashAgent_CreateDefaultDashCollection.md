---
title: POST Agents/Dash/CreateDefaultDashCollection
uid: v1DashAgent_CreateDefaultDashCollection
generated: true
content_type: reference
---

# POST Agents/Dash/CreateDefaultDashCollection

```http
POST /api/v1/Agents/Dash/CreateDefaultDashCollection
```

Loading default values into a new DashCollection.








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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

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
      "DashboardId": 807,
      "UniqueId": "distinctio",
      "Name": "O'Keefe, Mueller and Ankunding",
      "Description": "Total demand-driven leverage",
      "AssociateId": 198,
      "Columns": 891,
      "Theme": null,
      "VisibleForAll": 551,
      "VisibleForAssociates": [
        502,
        450
      ],
      "VisibleForGroups": [
        296,
        758
      ],
      "PinForAll": 30,
      "PinForAssociates": [
        960,
        568
      ],
      "PinForGroups": [
        385,
        108
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 325
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 62,
      "UniqueId": "dolores",
      "Name": "Prohaska, Goldner and Frami",
      "Description": "Monitored object-oriented support",
      "AssociateId": 105,
      "Columns": 9,
      "Theme": null,
      "VisibleForAll": 273,
      "VisibleForAssociates": [
        271,
        202
      ],
      "VisibleForGroups": [
        524,
        405
      ],
      "PinForAll": 899,
      "PinForAssociates": [
        501,
        498
      ],
      "PinForGroups": [
        110,
        90
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 131
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 662,
      "UniqueId": "odio",
      "Name": "Runolfsson Inc and Sons",
      "Description": "Stand-alone motivating alliance",
      "AssociateId": 182,
      "Columns": 450,
      "Theme": null,
      "VisibleForAll": 32,
      "VisibleForAssociates": [
        65,
        561
      ],
      "VisibleForGroups": [
        839,
        618
      ],
      "PinForAll": 600,
      "PinForAssociates": [
        410,
        546
      ],
      "PinForGroups": [
        766,
        543
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 751
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 163
    }
  }
}
```