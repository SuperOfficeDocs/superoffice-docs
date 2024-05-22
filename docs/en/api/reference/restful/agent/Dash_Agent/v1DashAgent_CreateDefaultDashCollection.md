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
      "DashboardId": 32,
      "UniqueId": "aut",
      "Name": "Witting, Reichel and Metz",
      "Description": "Advanced actuating approach",
      "AssociateId": 814,
      "Columns": 248,
      "Theme": null,
      "VisibleForAll": 346,
      "VisibleForAssociates": [
        299,
        652
      ],
      "VisibleForGroups": [
        790,
        769
      ],
      "PinForAll": 912,
      "PinForAssociates": [
        120,
        561
      ],
      "PinForGroups": [
        439,
        721
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 30
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 894,
      "UniqueId": "voluptatem",
      "Name": "O'Reilly, Lang and Hilll",
      "Description": "Intuitive zero defect synergy",
      "AssociateId": 622,
      "Columns": 99,
      "Theme": null,
      "VisibleForAll": 714,
      "VisibleForAssociates": [
        929,
        632
      ],
      "VisibleForGroups": [
        547,
        134
      ],
      "PinForAll": 505,
      "PinForAssociates": [
        925,
        724
      ],
      "PinForGroups": [
        197,
        818
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 534
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 822,
      "UniqueId": "aut",
      "Name": "Hahn Inc and Sons",
      "Description": "Fundamental non-volatile synergy",
      "AssociateId": 565,
      "Columns": 204,
      "Theme": null,
      "VisibleForAll": 11,
      "VisibleForAssociates": [
        135,
        893
      ],
      "VisibleForGroups": [
        752,
        16
      ],
      "PinForAll": 321,
      "PinForAssociates": [
        343,
        118
      ],
      "PinForGroups": [
        787,
        164
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 898
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 860
    }
  }
}
```