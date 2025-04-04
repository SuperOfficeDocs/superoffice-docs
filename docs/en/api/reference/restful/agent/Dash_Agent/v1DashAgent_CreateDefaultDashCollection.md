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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 850,
      "UniqueId": "officiis",
      "Name": "Rogahn Group",
      "Description": "Digitized analyzing hardware",
      "AssociateId": 49,
      "Columns": 278,
      "Theme": null,
      "VisibleForAll": 797,
      "VisibleForAssociates": [
        648,
        562
      ],
      "VisibleForGroups": [
        378,
        641
      ],
      "PinForAll": 768,
      "PinForAssociates": [
        747,
        524
      ],
      "PinForGroups": [
        896,
        533
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 62
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 571,
      "UniqueId": "aut",
      "Name": "Grant Group",
      "Description": "Advanced local strategy",
      "AssociateId": 872,
      "Columns": 960,
      "Theme": null,
      "VisibleForAll": 356,
      "VisibleForAssociates": [
        521,
        732
      ],
      "VisibleForGroups": [
        647,
        690
      ],
      "PinForAll": 399,
      "PinForAssociates": [
        891,
        398
      ],
      "PinForGroups": [
        493,
        469
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 322
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 62,
      "UniqueId": "nemo",
      "Name": "Will Inc and Sons",
      "Description": "Business-focused attitude-oriented frame",
      "AssociateId": 926,
      "Columns": 71,
      "Theme": null,
      "VisibleForAll": 532,
      "VisibleForAssociates": [
        963,
        686
      ],
      "VisibleForGroups": [
        394,
        423
      ],
      "PinForAll": 980,
      "PinForAssociates": [
        21,
        1002
      ],
      "PinForGroups": [
        261,
        239
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 1000
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 663
    }
  }
}
```