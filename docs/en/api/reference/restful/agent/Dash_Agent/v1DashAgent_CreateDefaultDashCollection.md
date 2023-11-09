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
      "DashboardId": 806,
      "UniqueId": "quo",
      "Name": "Greenholt, Sauer and Mosciski",
      "Description": "Open-source optimal hierarchy",
      "AssociateId": 103,
      "Columns": 753,
      "Theme": null,
      "VisibleForAll": 909,
      "VisibleForAssociates": [
        140,
        83
      ],
      "VisibleForGroups": [
        534,
        810
      ],
      "PinForAll": 232,
      "PinForAssociates": [
        473,
        610
      ],
      "PinForGroups": [
        217,
        750
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 685,
      "UniqueId": "sunt",
      "Name": "Grant Inc and Sons",
      "Description": "Function-based cohesive utilisation",
      "AssociateId": 354,
      "Columns": 228,
      "Theme": null,
      "VisibleForAll": 551,
      "VisibleForAssociates": [
        42,
        715
      ],
      "VisibleForGroups": [
        980,
        536
      ],
      "PinForAll": 915,
      "PinForAssociates": [
        630,
        335
      ],
      "PinForGroups": [
        578,
        417
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 163
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 357,
      "UniqueId": "aut",
      "Name": "Kirlin LLC",
      "Description": "User-friendly non-volatile alliance",
      "AssociateId": 956,
      "Columns": 898,
      "Theme": null,
      "VisibleForAll": 377,
      "VisibleForAssociates": [
        727,
        797
      ],
      "VisibleForGroups": [
        484,
        857
      ],
      "PinForAll": 541,
      "PinForAssociates": [
        198,
        412
      ],
      "PinForGroups": [
        260,
        489
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 991
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 849
    }
  }
}
```