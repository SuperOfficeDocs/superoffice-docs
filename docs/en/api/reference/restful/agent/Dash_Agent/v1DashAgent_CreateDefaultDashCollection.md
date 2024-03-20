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
      "DashboardId": 364,
      "UniqueId": "nam",
      "Name": "Kub, Smitham and Kihn",
      "Description": "Centralized needs-based matrices",
      "AssociateId": 161,
      "Columns": 676,
      "Theme": null,
      "VisibleForAll": 429,
      "VisibleForAssociates": [
        3,
        321
      ],
      "VisibleForGroups": [
        646,
        11
      ],
      "PinForAll": 824,
      "PinForAssociates": [
        217,
        232
      ],
      "PinForGroups": [
        469,
        539
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 919
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 590,
      "UniqueId": "impedit",
      "Name": "Brekke Group",
      "Description": "Synchronised secondary alliance",
      "AssociateId": 921,
      "Columns": 596,
      "Theme": null,
      "VisibleForAll": 169,
      "VisibleForAssociates": [
        706,
        843
      ],
      "VisibleForGroups": [
        455,
        266
      ],
      "PinForAll": 318,
      "PinForAssociates": [
        494,
        956
      ],
      "PinForGroups": [
        139,
        429
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 745,
      "UniqueId": "culpa",
      "Name": "Schultz Group",
      "Description": "Horizontal zero defect functionalities",
      "AssociateId": 259,
      "Columns": 761,
      "Theme": null,
      "VisibleForAll": 262,
      "VisibleForAssociates": [
        594,
        675
      ],
      "VisibleForGroups": [
        904,
        800
      ],
      "PinForAll": 391,
      "PinForAssociates": [
        911,
        421
      ],
      "PinForGroups": [
        557,
        466
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 764
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 424
    }
  }
}
```