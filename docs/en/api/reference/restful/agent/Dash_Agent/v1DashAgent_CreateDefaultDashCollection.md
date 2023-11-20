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
      "DashboardId": 86,
      "UniqueId": "ut",
      "Name": "Beier Group",
      "Description": "Focused human-resource adapter",
      "AssociateId": 570,
      "Columns": 515,
      "Theme": null,
      "VisibleForAll": 658,
      "VisibleForAssociates": [
        804,
        744
      ],
      "VisibleForGroups": [
        998,
        764
      ],
      "PinForAll": 263,
      "PinForAssociates": [
        82,
        421
      ],
      "PinForGroups": [
        284,
        214
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 883,
      "UniqueId": "vel",
      "Name": "Schaden, Bosco and Marks",
      "Description": "Decentralized context-sensitive conglomeration",
      "AssociateId": 172,
      "Columns": 598,
      "Theme": null,
      "VisibleForAll": 523,
      "VisibleForAssociates": [
        947,
        888
      ],
      "VisibleForGroups": [
        99,
        321
      ],
      "PinForAll": 216,
      "PinForAssociates": [
        139,
        3
      ],
      "PinForGroups": [
        941,
        835
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 957
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 259,
      "UniqueId": "ad",
      "Name": "Kuhlman Inc and Sons",
      "Description": "Synchronised neutral archive",
      "AssociateId": 101,
      "Columns": 162,
      "Theme": null,
      "VisibleForAll": 876,
      "VisibleForAssociates": [
        948,
        677
      ],
      "VisibleForGroups": [
        639,
        657
      ],
      "PinForAll": 127,
      "PinForAssociates": [
        521,
        687
      ],
      "PinForGroups": [
        953,
        263
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 386
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 974
    }
  }
}
```