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
      "DashboardId": 33,
      "UniqueId": "harum",
      "Name": "Leuschke LLC",
      "Description": "Synergized hybrid success",
      "AssociateId": 743,
      "Columns": 517,
      "Theme": null,
      "VisibleForAll": 25,
      "VisibleForAssociates": [
        130,
        379
      ],
      "VisibleForGroups": [
        490,
        443
      ],
      "PinForAll": 169,
      "PinForAssociates": [
        267,
        677
      ],
      "PinForGroups": [
        597,
        85
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 172
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 910,
      "UniqueId": "sequi",
      "Name": "Pacocha-Koepp",
      "Description": "Inverse global projection",
      "AssociateId": 507,
      "Columns": 830,
      "Theme": null,
      "VisibleForAll": 494,
      "VisibleForAssociates": [
        141,
        908
      ],
      "VisibleForGroups": [
        838,
        264
      ],
      "PinForAll": 549,
      "PinForAssociates": [
        165,
        463
      ],
      "PinForGroups": [
        695,
        57
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 287
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 537,
      "UniqueId": "nihil",
      "Name": "Hauck Inc and Sons",
      "Description": "Quality-focused real-time monitoring",
      "AssociateId": 546,
      "Columns": 899,
      "Theme": null,
      "VisibleForAll": 842,
      "VisibleForAssociates": [
        844,
        53
      ],
      "VisibleForGroups": [
        702,
        422
      ],
      "PinForAll": 629,
      "PinForAssociates": [
        924,
        367
      ],
      "PinForGroups": [
        467,
        599
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 904
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 518
    }
  }
}
```