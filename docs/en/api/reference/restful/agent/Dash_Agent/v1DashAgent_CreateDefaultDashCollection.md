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
      "DashboardId": 887,
      "UniqueId": "nisi",
      "Name": "Lind, Lynch and Homenick",
      "Description": "Balanced even-keeled orchestration",
      "AssociateId": 339,
      "Columns": 720,
      "Theme": null,
      "VisibleForAll": 377,
      "VisibleForAssociates": [
        909,
        661
      ],
      "VisibleForGroups": [
        234,
        139
      ],
      "PinForAll": 351,
      "PinForAssociates": [
        904,
        434
      ],
      "PinForGroups": [
        52,
        722
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 427
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 928,
      "UniqueId": "enim",
      "Name": "Rodriguez-Nienow",
      "Description": "Triple-buffered human-resource methodology",
      "AssociateId": 252,
      "Columns": 627,
      "Theme": null,
      "VisibleForAll": 928,
      "VisibleForAssociates": [
        322,
        839
      ],
      "VisibleForGroups": [
        594,
        533
      ],
      "PinForAll": 459,
      "PinForAssociates": [
        59,
        307
      ],
      "PinForGroups": [
        1000,
        832
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 195
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 821,
      "UniqueId": "architecto",
      "Name": "Green, Gibson and Prosacco",
      "Description": "Synergized optimal support",
      "AssociateId": 51,
      "Columns": 137,
      "Theme": null,
      "VisibleForAll": 47,
      "VisibleForAssociates": [
        447,
        13
      ],
      "VisibleForGroups": [
        159,
        907
      ],
      "PinForAll": 556,
      "PinForAssociates": [
        10,
        647
      ],
      "PinForGroups": [
        523,
        315
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 55
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 111
    }
  }
}
```