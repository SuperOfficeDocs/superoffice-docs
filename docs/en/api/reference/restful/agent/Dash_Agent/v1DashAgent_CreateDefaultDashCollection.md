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
      "DashboardId": 844,
      "UniqueId": "incidunt",
      "Name": "Walsh-Kerluke",
      "Description": "Expanded stable product",
      "AssociateId": 587,
      "Columns": 655,
      "Theme": null,
      "VisibleForAll": 604,
      "VisibleForAssociates": [
        647,
        482
      ],
      "VisibleForGroups": [
        587,
        797
      ],
      "PinForAll": 424,
      "PinForAssociates": [
        764,
        32
      ],
      "PinForGroups": [
        323,
        324
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 295
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 505,
      "UniqueId": "tempore",
      "Name": "Hartmann-Abernathy",
      "Description": "Extended 24 hour customer loyalty",
      "AssociateId": 617,
      "Columns": 171,
      "Theme": null,
      "VisibleForAll": 786,
      "VisibleForAssociates": [
        445,
        670
      ],
      "VisibleForGroups": [
        81,
        664
      ],
      "PinForAll": 637,
      "PinForAssociates": [
        45,
        265
      ],
      "PinForGroups": [
        597,
        470
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 151
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 34,
      "UniqueId": "veniam",
      "Name": "McDermott-Wiza",
      "Description": "Customizable executive open system",
      "AssociateId": 851,
      "Columns": 255,
      "Theme": null,
      "VisibleForAll": 446,
      "VisibleForAssociates": [
        560,
        363
      ],
      "VisibleForGroups": [
        340,
        427
      ],
      "PinForAll": 872,
      "PinForAssociates": [
        272,
        605
      ],
      "PinForGroups": [
        273,
        870
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 897
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 599
    }
  }
}
```