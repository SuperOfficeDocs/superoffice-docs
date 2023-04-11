---
title: POST Agents/Dash/CreateDefaultDashCollection
uid: v1DashAgent_CreateDefaultDashCollection
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
      "DashboardId": 157,
      "UniqueId": "maiores",
      "Name": "Ondricka Inc and Sons",
      "Description": "Expanded 24/7 installation",
      "AssociateId": 362,
      "Columns": 481,
      "Theme": null,
      "VisibleForAll": 912,
      "VisibleForAssociates": [
        609,
        983
      ],
      "VisibleForGroups": [
        896,
        686
      ],
      "PinForAll": 851,
      "PinForAssociates": [
        708,
        6
      ],
      "PinForGroups": [
        991,
        884
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 807,
      "UniqueId": "illum",
      "Name": "Wolff LLC",
      "Description": "Down-sized attitude-oriented implementation",
      "AssociateId": 365,
      "Columns": 74,
      "Theme": null,
      "VisibleForAll": 684,
      "VisibleForAssociates": [
        963,
        305
      ],
      "VisibleForGroups": [
        986,
        831
      ],
      "PinForAll": 280,
      "PinForAssociates": [
        272,
        653
      ],
      "PinForGroups": [
        954,
        15
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 156
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 240,
      "UniqueId": "at",
      "Name": "Smith, Hilpert and Kohler",
      "Description": "Implemented zero defect initiative",
      "AssociateId": 593,
      "Columns": 426,
      "Theme": null,
      "VisibleForAll": 919,
      "VisibleForAssociates": [
        747,
        344
      ],
      "VisibleForGroups": [
        761,
        34
      ],
      "PinForAll": 683,
      "PinForAssociates": [
        795,
        574
      ],
      "PinForGroups": [
        555,
        772
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 53
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 536
    }
  }
}
```