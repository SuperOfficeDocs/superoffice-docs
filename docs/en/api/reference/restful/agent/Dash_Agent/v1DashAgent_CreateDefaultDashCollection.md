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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 203,
      "UniqueId": "et",
      "Name": "Batz, McCullough and O'Connell",
      "Description": "Expanded human-resource groupware",
      "AssociateId": 550,
      "Columns": 669,
      "Theme": null,
      "VisibleForAll": 608,
      "VisibleForAssociates": [
        788,
        942
      ],
      "VisibleForGroups": [
        334,
        767
      ],
      "PinForAll": 379,
      "PinForAssociates": [
        887,
        572
      ],
      "PinForGroups": [
        705,
        355
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 367
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 231,
      "UniqueId": "porro",
      "Name": "Cartwright, Moore and Weissnat",
      "Description": "Seamless grid-enabled concept",
      "AssociateId": 883,
      "Columns": 9,
      "Theme": null,
      "VisibleForAll": 678,
      "VisibleForAssociates": [
        838,
        841
      ],
      "VisibleForGroups": [
        811,
        40
      ],
      "PinForAll": 518,
      "PinForAssociates": [
        994,
        798
      ],
      "PinForGroups": [
        324,
        934
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 167
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 161,
      "UniqueId": "nisi",
      "Name": "Tromp Group",
      "Description": "Persistent system-worthy archive",
      "AssociateId": 806,
      "Columns": 551,
      "Theme": null,
      "VisibleForAll": 755,
      "VisibleForAssociates": [
        285,
        143
      ],
      "VisibleForGroups": [
        42,
        114
      ],
      "PinForAll": 381,
      "PinForAssociates": [
        524,
        338
      ],
      "PinForGroups": [
        1001,
        152
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 70
        }
      }
    }
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
```