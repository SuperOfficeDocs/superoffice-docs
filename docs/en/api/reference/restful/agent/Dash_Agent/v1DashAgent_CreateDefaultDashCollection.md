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
      "DashboardId": 71,
      "UniqueId": "nesciunt",
      "Name": "Koelpin-Beer",
      "Description": "Sharable neutral budgetary management",
      "AssociateId": 530,
      "Columns": 963,
      "Theme": null,
      "VisibleForAll": 207,
      "VisibleForAssociates": [
        260,
        32
      ],
      "VisibleForGroups": [
        628,
        680
      ],
      "PinForAll": 827,
      "PinForAssociates": [
        99,
        101
      ],
      "PinForGroups": [
        379,
        404
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 880
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 980,
      "UniqueId": "nulla",
      "Name": "Walker Group",
      "Description": "Organic zero administration info-mediaries",
      "AssociateId": 149,
      "Columns": 311,
      "Theme": null,
      "VisibleForAll": 308,
      "VisibleForAssociates": [
        689,
        26
      ],
      "VisibleForGroups": [
        968,
        980
      ],
      "PinForAll": 198,
      "PinForAssociates": [
        61,
        132
      ],
      "PinForGroups": [
        915,
        944
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 637
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 134,
      "UniqueId": "magnam",
      "Name": "Jerde Group",
      "Description": "Triple-buffered context-sensitive policy",
      "AssociateId": 888,
      "Columns": 884,
      "Theme": null,
      "VisibleForAll": 379,
      "VisibleForAssociates": [
        282,
        174
      ],
      "VisibleForGroups": [
        268,
        582
      ],
      "PinForAll": 816,
      "PinForAssociates": [
        188,
        17
      ],
      "PinForGroups": [
        156,
        368
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 982
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 177
    }
  }
}
```