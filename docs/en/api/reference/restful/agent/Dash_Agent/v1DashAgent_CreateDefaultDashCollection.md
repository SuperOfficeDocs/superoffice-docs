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
      "DashboardId": 660,
      "UniqueId": "quia",
      "Name": "Swift, Gerhold and Raynor",
      "Description": "Triple-buffered incremental function",
      "AssociateId": 984,
      "Columns": 460,
      "Theme": null,
      "VisibleForAll": 365,
      "VisibleForAssociates": [
        758,
        456
      ],
      "VisibleForGroups": [
        414,
        510
      ],
      "PinForAll": 940,
      "PinForAssociates": [
        707,
        608
      ],
      "PinForGroups": [
        638,
        94
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 161
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 32,
      "UniqueId": "quis",
      "Name": "Bode, O'Hara and Ledner",
      "Description": "Persevering clear-thinking throughput",
      "AssociateId": 180,
      "Columns": 982,
      "Theme": null,
      "VisibleForAll": 4,
      "VisibleForAssociates": [
        239,
        743
      ],
      "VisibleForGroups": [
        180,
        87
      ],
      "PinForAll": 451,
      "PinForAssociates": [
        252,
        451
      ],
      "PinForGroups": [
        220,
        506
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 569
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 556,
      "UniqueId": "et",
      "Name": "Pagac Inc and Sons",
      "Description": "De-engineered content-based application",
      "AssociateId": 986,
      "Columns": 930,
      "Theme": null,
      "VisibleForAll": 238,
      "VisibleForAssociates": [
        330,
        545
      ],
      "VisibleForGroups": [
        259,
        602
      ],
      "PinForAll": 439,
      "PinForAssociates": [
        246,
        33
      ],
      "PinForGroups": [
        969,
        119
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
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 881
    }
  }
}
```