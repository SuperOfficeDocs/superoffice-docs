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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 385,
      "UniqueId": "omnis",
      "Name": "Huels-Turcotte",
      "Description": "Stand-alone grid-enabled core",
      "AssociateId": 687,
      "Columns": 724,
      "Theme": null,
      "VisibleForAll": 380,
      "VisibleForAssociates": [
        44,
        326
      ],
      "VisibleForGroups": [
        386,
        459
      ],
      "PinForAll": 952,
      "PinForAssociates": [
        145,
        663
      ],
      "PinForGroups": [
        209,
        193
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 400
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 634,
      "UniqueId": "molestias",
      "Name": "Price, Fritsch and Corkery",
      "Description": "Visionary mobile website",
      "AssociateId": 682,
      "Columns": 888,
      "Theme": null,
      "VisibleForAll": 16,
      "VisibleForAssociates": [
        24,
        31
      ],
      "VisibleForGroups": [
        824,
        908
      ],
      "PinForAll": 985,
      "PinForAssociates": [
        654,
        654
      ],
      "PinForGroups": [
        612,
        223
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 983
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 985,
      "UniqueId": "eaque",
      "Name": "Leffler, Mosciski and Nikolaus",
      "Description": "Implemented logistical archive",
      "AssociateId": 800,
      "Columns": 679,
      "Theme": null,
      "VisibleForAll": 34,
      "VisibleForAssociates": [
        399,
        115
      ],
      "VisibleForGroups": [
        120,
        487
      ],
      "PinForAll": 92,
      "PinForAssociates": [
        681,
        92
      ],
      "PinForGroups": [
        572,
        277
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 400
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 719
    }
  }
}
```