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
      "DashboardId": 17,
      "UniqueId": "quis",
      "Name": "Auer-Rippin",
      "Description": "Centralized responsive customer loyalty",
      "AssociateId": 108,
      "Columns": 460,
      "Theme": null,
      "VisibleForAll": 448,
      "VisibleForAssociates": [
        35,
        861
      ],
      "VisibleForGroups": [
        919,
        13
      ],
      "PinForAll": 107,
      "PinForAssociates": [
        558,
        875
      ],
      "PinForGroups": [
        358,
        972
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 716
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 916,
      "UniqueId": "laboriosam",
      "Name": "Kautzer-Kris",
      "Description": "Reverse-engineered secondary definition",
      "AssociateId": 987,
      "Columns": 733,
      "Theme": null,
      "VisibleForAll": 210,
      "VisibleForAssociates": [
        702,
        346
      ],
      "VisibleForGroups": [
        768,
        749
      ],
      "PinForAll": 221,
      "PinForAssociates": [
        957,
        724
      ],
      "PinForGroups": [
        847,
        963
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 350
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 519,
      "UniqueId": "doloremque",
      "Name": "Morissette, Torphy and Pagac",
      "Description": "Sharable even-keeled application",
      "AssociateId": 650,
      "Columns": 578,
      "Theme": null,
      "VisibleForAll": 213,
      "VisibleForAssociates": [
        737,
        392
      ],
      "VisibleForGroups": [
        389,
        591
      ],
      "PinForAll": 548,
      "PinForAssociates": [
        969,
        191
      ],
      "PinForGroups": [
        254,
        115
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 985
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 849
    }
  }
}
```