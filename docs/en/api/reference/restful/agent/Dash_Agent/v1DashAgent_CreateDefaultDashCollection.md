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
      "DashboardId": 736,
      "UniqueId": "et",
      "Name": "McDermott Group",
      "Description": "Total intangible capability",
      "AssociateId": 117,
      "Columns": 869,
      "Theme": null,
      "VisibleForAll": 689,
      "VisibleForAssociates": [
        420,
        489
      ],
      "VisibleForGroups": [
        579,
        140
      ],
      "PinForAll": 216,
      "PinForAssociates": [
        493,
        636
      ],
      "PinForGroups": [
        188,
        146
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 681
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 270,
      "UniqueId": "voluptate",
      "Name": "Sanford, Orn and Wehner",
      "Description": "Persistent scalable archive",
      "AssociateId": 394,
      "Columns": 357,
      "Theme": null,
      "VisibleForAll": 414,
      "VisibleForAssociates": [
        413,
        648
      ],
      "VisibleForGroups": [
        475,
        909
      ],
      "PinForAll": 797,
      "PinForAssociates": [
        995,
        123
      ],
      "PinForGroups": [
        724,
        970
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 1002
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 180,
      "UniqueId": "culpa",
      "Name": "O'Kon, Herzog and Shanahan",
      "Description": "Profit-focused object-oriented support",
      "AssociateId": 60,
      "Columns": 225,
      "Theme": null,
      "VisibleForAll": 794,
      "VisibleForAssociates": [
        675,
        793
      ],
      "VisibleForGroups": [
        80,
        701
      ],
      "PinForAll": 33,
      "PinForAssociates": [
        418,
        106
      ],
      "PinForGroups": [
        25,
        212
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 483
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 94
    }
  }
}
```