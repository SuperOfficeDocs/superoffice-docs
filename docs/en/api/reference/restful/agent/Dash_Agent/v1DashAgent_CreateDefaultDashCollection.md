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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 912,
      "UniqueId": "dicta",
      "Name": "Kuphal Inc and Sons",
      "Description": "Enhanced modular projection",
      "AssociateId": 438,
      "Columns": 22,
      "Theme": null,
      "VisibleForAll": 314,
      "VisibleForAssociates": [
        516,
        490
      ],
      "VisibleForGroups": [
        152,
        311
      ],
      "PinForAll": 213,
      "PinForAssociates": [
        578,
        703
      ],
      "PinForGroups": [
        411,
        105
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 775
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 132,
      "UniqueId": "et",
      "Name": "Wisozk-Frami",
      "Description": "Self-enabling asynchronous project",
      "AssociateId": 294,
      "Columns": 575,
      "Theme": null,
      "VisibleForAll": 56,
      "VisibleForAssociates": [
        356,
        416
      ],
      "VisibleForGroups": [
        57,
        614
      ],
      "PinForAll": 713,
      "PinForAssociates": [
        345,
        728
      ],
      "PinForGroups": [
        589,
        290
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 915
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 613,
      "UniqueId": "necessitatibus",
      "Name": "Rau, Rolfson and Jacobs",
      "Description": "Versatile mobile middleware",
      "AssociateId": 840,
      "Columns": 642,
      "Theme": null,
      "VisibleForAll": 148,
      "VisibleForAssociates": [
        679,
        359
      ],
      "VisibleForGroups": [
        759,
        272
      ],
      "PinForAll": 161,
      "PinForAssociates": [
        720,
        171
      ],
      "PinForGroups": [
        56,
        972
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 301
    }
  }
}
```