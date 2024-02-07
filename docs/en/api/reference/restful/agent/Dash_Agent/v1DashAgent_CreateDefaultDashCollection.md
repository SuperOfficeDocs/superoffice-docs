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
      "DashboardId": 456,
      "UniqueId": "sed",
      "Name": "Schumm Inc and Sons",
      "Description": "Adaptive national product",
      "AssociateId": 214,
      "Columns": 859,
      "Theme": null,
      "VisibleForAll": 525,
      "VisibleForAssociates": [
        409,
        677
      ],
      "VisibleForGroups": [
        838,
        945
      ],
      "PinForAll": 468,
      "PinForAssociates": [
        586,
        431
      ],
      "PinForGroups": [
        756,
        297
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 984
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 718,
      "UniqueId": "ullam",
      "Name": "Gutkowski-Green",
      "Description": "Total optimizing strategy",
      "AssociateId": 472,
      "Columns": 534,
      "Theme": null,
      "VisibleForAll": 810,
      "VisibleForAssociates": [
        30,
        894
      ],
      "VisibleForGroups": [
        663,
        772
      ],
      "PinForAll": 37,
      "PinForAssociates": [
        129,
        699
      ],
      "PinForGroups": [
        970,
        705
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 498
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 246,
      "UniqueId": "accusamus",
      "Name": "Bartoletti Group",
      "Description": "Face to face national analyzer",
      "AssociateId": 260,
      "Columns": 137,
      "Theme": null,
      "VisibleForAll": 97,
      "VisibleForAssociates": [
        658,
        32
      ],
      "VisibleForGroups": [
        90,
        84
      ],
      "PinForAll": 605,
      "PinForAssociates": [
        267,
        247
      ],
      "PinForGroups": [
        503,
        344
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 237
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 694
    }
  }
}
```