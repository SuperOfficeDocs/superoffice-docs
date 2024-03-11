---
title: POST Agents/Dash/GetDashCollection
uid: v1DashAgent_GetDashCollection
generated: true
---

# POST Agents/Dash/GetDashCollection

```http
POST /api/v1/Agents/Dash/GetDashCollection
```

Gets a collection of dashboards for the current associate







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dash/GetDashCollection?$select=name,department,category/id
```


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
POST /api/v1/Agents/Dash/GetDashCollection
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
      "DashboardId": 143,
      "UniqueId": "quis",
      "Name": "Renner, Hessel and Towne",
      "Description": "Up-sized zero administration definition",
      "AssociateId": 798,
      "Columns": 665,
      "Theme": null,
      "VisibleForAll": 130,
      "VisibleForAssociates": [
        731,
        290
      ],
      "VisibleForGroups": [
        968,
        745
      ],
      "PinForAll": 658,
      "PinForAssociates": [
        294,
        281
      ],
      "PinForGroups": [
        135,
        492
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 754
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 585,
      "UniqueId": "dolore",
      "Name": "Zemlak-Purdy",
      "Description": "Inverse motivating instruction set",
      "AssociateId": 261,
      "Columns": 551,
      "Theme": null,
      "VisibleForAll": 399,
      "VisibleForAssociates": [
        149,
        894
      ],
      "VisibleForGroups": [
        917,
        940
      ],
      "PinForAll": 28,
      "PinForAssociates": [
        694,
        637
      ],
      "PinForGroups": [
        188,
        99
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 906
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 521,
      "UniqueId": "et",
      "Name": "Donnelly-VonRueden",
      "Description": "Function-based hybrid application",
      "AssociateId": 133,
      "Columns": 498,
      "Theme": null,
      "VisibleForAll": 230,
      "VisibleForAssociates": [
        41,
        39
      ],
      "VisibleForGroups": [
        733,
        810
      ],
      "PinForAll": 349,
      "PinForAssociates": [
        97,
        629
      ],
      "PinForGroups": [
        527,
        358
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
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 798
    }
  }
}
```