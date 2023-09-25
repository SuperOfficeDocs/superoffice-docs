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
      "DashboardId": 2,
      "UniqueId": "non",
      "Name": "Quitzon-Quitzon",
      "Description": "Down-sized web-enabled concept",
      "AssociateId": 332,
      "Columns": 606,
      "Theme": null,
      "VisibleForAll": 340,
      "VisibleForAssociates": [
        231,
        132
      ],
      "VisibleForGroups": [
        394,
        524
      ],
      "PinForAll": 759,
      "PinForAssociates": [
        471,
        621
      ],
      "PinForGroups": [
        915,
        90
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 41
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 792,
      "UniqueId": "et",
      "Name": "Stroman-Wisoky",
      "Description": "Triple-buffered bifurcated structure",
      "AssociateId": 144,
      "Columns": 405,
      "Theme": null,
      "VisibleForAll": 625,
      "VisibleForAssociates": [
        703,
        603
      ],
      "VisibleForGroups": [
        401,
        957
      ],
      "PinForAll": 118,
      "PinForAssociates": [
        59,
        131
      ],
      "PinForGroups": [
        412,
        452
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 33
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 283,
      "UniqueId": "fugit",
      "Name": "Hessel-Deckow",
      "Description": "Visionary systemic open architecture",
      "AssociateId": 30,
      "Columns": 862,
      "Theme": null,
      "VisibleForAll": 794,
      "VisibleForAssociates": [
        992,
        154
      ],
      "VisibleForGroups": [
        946,
        168
      ],
      "PinForAll": 882,
      "PinForAssociates": [
        139,
        695
      ],
      "PinForGroups": [
        457,
        318
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 278
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 80
    }
  }
}
```