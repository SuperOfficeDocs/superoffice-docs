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
      "DashboardId": 733,
      "UniqueId": "magni",
      "Name": "Bogan, Buckridge and Little",
      "Description": "Streamlined uniform interface",
      "AssociateId": 546,
      "Columns": 997,
      "Theme": null,
      "VisibleForAll": 520,
      "VisibleForAssociates": [
        44,
        797
      ],
      "VisibleForGroups": [
        583,
        302
      ],
      "PinForAll": 434,
      "PinForAssociates": [
        514,
        542
      ],
      "PinForGroups": [
        803,
        684
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 507
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 149,
      "UniqueId": "sed",
      "Name": "Graham-Emmerich",
      "Description": "Enhanced 24 hour software",
      "AssociateId": 960,
      "Columns": 583,
      "Theme": null,
      "VisibleForAll": 93,
      "VisibleForAssociates": [
        146,
        132
      ],
      "VisibleForGroups": [
        383,
        817
      ],
      "PinForAll": 988,
      "PinForAssociates": [
        722,
        167
      ],
      "PinForGroups": [
        461,
        228
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 940
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 538,
      "UniqueId": "accusamus",
      "Name": "Champlin Inc and Sons",
      "Description": "Devolved logistical throughput",
      "AssociateId": 29,
      "Columns": 730,
      "Theme": null,
      "VisibleForAll": 916,
      "VisibleForAssociates": [
        251,
        236
      ],
      "VisibleForGroups": [
        56,
        741
      ],
      "PinForAll": 260,
      "PinForAssociates": [
        267,
        424
      ],
      "PinForGroups": [
        294,
        189
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 515
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 654
    }
  }
}
```