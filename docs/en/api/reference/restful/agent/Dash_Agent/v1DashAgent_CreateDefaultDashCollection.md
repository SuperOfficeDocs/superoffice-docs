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
      "DashboardId": 434,
      "UniqueId": "nostrum",
      "Name": "Hessel LLC",
      "Description": "Quality-focused radical strategy",
      "AssociateId": 770,
      "Columns": 881,
      "Theme": null,
      "VisibleForAll": 789,
      "VisibleForAssociates": [
        328,
        836
      ],
      "VisibleForGroups": [
        976,
        926
      ],
      "PinForAll": 701,
      "PinForAssociates": [
        799,
        276
      ],
      "PinForGroups": [
        848,
        308
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 993
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 124,
      "UniqueId": "recusandae",
      "Name": "Brown, Kunde and Marks",
      "Description": "Future-proofed 5th generation productivity",
      "AssociateId": 424,
      "Columns": 492,
      "Theme": null,
      "VisibleForAll": 274,
      "VisibleForAssociates": [
        607,
        694
      ],
      "VisibleForGroups": [
        827,
        283
      ],
      "PinForAll": 301,
      "PinForAssociates": [
        646,
        20
      ],
      "PinForGroups": [
        256,
        82
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 487
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 794,
      "UniqueId": "ab",
      "Name": "Hansen, Monahan and Labadie",
      "Description": "Grass-roots needs-based utilisation",
      "AssociateId": 743,
      "Columns": 906,
      "Theme": null,
      "VisibleForAll": 243,
      "VisibleForAssociates": [
        130,
        966
      ],
      "VisibleForGroups": [
        906,
        557
      ],
      "PinForAll": 728,
      "PinForAssociates": [
        194,
        35
      ],
      "PinForGroups": [
        331,
        626
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 398
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 309
    }
  }
}
```