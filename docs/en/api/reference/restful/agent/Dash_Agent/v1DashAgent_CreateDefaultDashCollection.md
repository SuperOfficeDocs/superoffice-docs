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
      "DashboardId": 771,
      "UniqueId": "modi",
      "Name": "Monahan, Hoppe and Zemlak",
      "Description": "Centralized heuristic migration",
      "AssociateId": 288,
      "Columns": 988,
      "Theme": null,
      "VisibleForAll": 291,
      "VisibleForAssociates": [
        807,
        833
      ],
      "VisibleForGroups": [
        332,
        82
      ],
      "PinForAll": 703,
      "PinForAssociates": [
        523,
        14
      ],
      "PinForGroups": [
        233,
        610
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 808
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 878,
      "UniqueId": "doloribus",
      "Name": "Kunde LLC",
      "Description": "Universal assymetric contingency",
      "AssociateId": 766,
      "Columns": 393,
      "Theme": null,
      "VisibleForAll": 459,
      "VisibleForAssociates": [
        300,
        353
      ],
      "VisibleForGroups": [
        341,
        322
      ],
      "PinForAll": 786,
      "PinForAssociates": [
        673,
        948
      ],
      "PinForGroups": [
        519,
        353
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 37
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 941,
      "UniqueId": "vero",
      "Name": "Fisher Group",
      "Description": "Public-key client-server product",
      "AssociateId": 880,
      "Columns": 700,
      "Theme": null,
      "VisibleForAll": 658,
      "VisibleForAssociates": [
        43,
        84
      ],
      "VisibleForGroups": [
        365,
        954
      ],
      "PinForAll": 762,
      "PinForAssociates": [
        953,
        864
      ],
      "PinForGroups": [
        555,
        491
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 368
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 102
    }
  }
}
```