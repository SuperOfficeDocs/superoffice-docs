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


NsApiSlow threshold: 5000 ms.







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
      "DashboardId": 680,
      "UniqueId": "sed",
      "Name": "Roberts, Mitchell and Sauer",
      "Description": "Right-sized radical customer loyalty",
      "AssociateId": 181,
      "Columns": 850,
      "Theme": null,
      "VisibleForAll": 310,
      "VisibleForAssociates": [
        268,
        496
      ],
      "VisibleForGroups": [
        752,
        182
      ],
      "PinForAll": 656,
      "PinForAssociates": [
        814,
        29
      ],
      "PinForGroups": [
        304,
        650
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 446,
      "UniqueId": "et",
      "Name": "O'Connell-Nolan",
      "Description": "Organic analyzing archive",
      "AssociateId": 974,
      "Columns": 45,
      "Theme": null,
      "VisibleForAll": 503,
      "VisibleForAssociates": [
        687,
        503
      ],
      "VisibleForGroups": [
        160,
        419
      ],
      "PinForAll": 461,
      "PinForAssociates": [
        91,
        246
      ],
      "PinForGroups": [
        245,
        491
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 492
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 381,
      "UniqueId": "sit",
      "Name": "Jenkins Inc and Sons",
      "Description": "Visionary fresh-thinking internet solution",
      "AssociateId": 266,
      "Columns": 602,
      "Theme": null,
      "VisibleForAll": 64,
      "VisibleForAssociates": [
        262,
        39
      ],
      "VisibleForGroups": [
        404,
        818
      ],
      "PinForAll": 715,
      "PinForAssociates": [
        430,
        444
      ],
      "PinForGroups": [
        268,
        307
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 373
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 604
    }
  }
}
```