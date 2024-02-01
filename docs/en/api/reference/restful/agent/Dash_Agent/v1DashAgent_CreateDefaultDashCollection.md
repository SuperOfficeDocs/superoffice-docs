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
      "DashboardId": 217,
      "UniqueId": "perferendis",
      "Name": "Mitchell, Mohr and Wuckert",
      "Description": "Profound static internet solution",
      "AssociateId": 766,
      "Columns": 17,
      "Theme": null,
      "VisibleForAll": 126,
      "VisibleForAssociates": [
        774,
        133
      ],
      "VisibleForGroups": [
        145,
        842
      ],
      "PinForAll": 84,
      "PinForAssociates": [
        831,
        733
      ],
      "PinForGroups": [
        660,
        698
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 688
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 236,
      "UniqueId": "exercitationem",
      "Name": "D'Amore, Abbott and Marks",
      "Description": "Pre-emptive next generation internet solution",
      "AssociateId": 17,
      "Columns": 184,
      "Theme": null,
      "VisibleForAll": 394,
      "VisibleForAssociates": [
        621,
        483
      ],
      "VisibleForGroups": [
        293,
        852
      ],
      "PinForAll": 825,
      "PinForAssociates": [
        526,
        996
      ],
      "PinForGroups": [
        903,
        989
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 769
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 146,
      "UniqueId": "quia",
      "Name": "Kulas Group",
      "Description": "Universal full-range leverage",
      "AssociateId": 974,
      "Columns": 645,
      "Theme": null,
      "VisibleForAll": 956,
      "VisibleForAssociates": [
        173,
        205
      ],
      "VisibleForGroups": [
        561,
        581
      ],
      "PinForAll": 128,
      "PinForAssociates": [
        446,
        351
      ],
      "PinForGroups": [
        620,
        987
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 902
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 991
    }
  }
}
```