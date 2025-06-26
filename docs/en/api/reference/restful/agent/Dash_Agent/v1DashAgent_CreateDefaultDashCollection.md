---
title: POST Agents/Dash/CreateDefaultDashCollection
uid: v1DashAgent_CreateDefaultDashCollection
generated: true
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
      "DashboardId": 906,
      "UniqueId": "odio",
      "Name": "Deckow, Wilkinson and Mitchell",
      "Description": "Optimized directional framework",
      "AssociateId": 952,
      "Columns": 739,
      "Theme": null,
      "VisibleForAll": 308,
      "VisibleForAssociates": [
        240,
        109
      ],
      "VisibleForGroups": [
        435,
        801
      ],
      "PinForAll": 580,
      "PinForAssociates": [
        529,
        88
      ],
      "PinForGroups": [
        721,
        627
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 153
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 832,
      "UniqueId": "aut",
      "Name": "Ondricka-Bogisich",
      "Description": "Fully-configurable optimal portal",
      "AssociateId": 806,
      "Columns": 41,
      "Theme": null,
      "VisibleForAll": 569,
      "VisibleForAssociates": [
        584,
        979
      ],
      "VisibleForGroups": [
        43,
        972
      ],
      "PinForAll": 600,
      "PinForAssociates": [
        789,
        44
      ],
      "PinForGroups": [
        508,
        733
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 307
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 126,
      "UniqueId": "omnis",
      "Name": "Klein-Schaden",
      "Description": "Ergonomic local Graphical User Interface",
      "AssociateId": 444,
      "Columns": 21,
      "Theme": null,
      "VisibleForAll": 742,
      "VisibleForAssociates": [
        68,
        203
      ],
      "VisibleForGroups": [
        847,
        618
      ],
      "PinForAll": 697,
      "PinForAssociates": [
        694,
        597
      ],
      "PinForGroups": [
        232,
        645
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 162
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 16
    }
  }
}
```