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
      "DashboardId": 572,
      "UniqueId": "eum",
      "Name": "DuBuque Inc and Sons",
      "Description": "Vision-oriented secondary budgetary management",
      "AssociateId": 642,
      "Columns": 850,
      "Theme": null,
      "VisibleForAll": 837,
      "VisibleForAssociates": [
        756,
        649
      ],
      "VisibleForGroups": [
        121,
        218
      ],
      "PinForAll": 932,
      "PinForAssociates": [
        620,
        612
      ],
      "PinForGroups": [
        161,
        554
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 649,
      "UniqueId": "rem",
      "Name": "Durgan LLC",
      "Description": "Face to face coherent knowledge user",
      "AssociateId": 419,
      "Columns": 931,
      "Theme": null,
      "VisibleForAll": 513,
      "VisibleForAssociates": [
        714,
        458
      ],
      "VisibleForGroups": [
        980,
        769
      ],
      "PinForAll": 778,
      "PinForAssociates": [
        598,
        69
      ],
      "PinForGroups": [
        869,
        887
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 311
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 722,
      "UniqueId": "impedit",
      "Name": "Gorczany, Hayes and Wunsch",
      "Description": "Enterprise-wide next generation ability",
      "AssociateId": 137,
      "Columns": 573,
      "Theme": null,
      "VisibleForAll": 852,
      "VisibleForAssociates": [
        216,
        271
      ],
      "VisibleForGroups": [
        193,
        175
      ],
      "PinForAll": 944,
      "PinForAssociates": [
        705,
        548
      ],
      "PinForGroups": [
        801,
        787
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 110
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 411
    }
  }
}
```