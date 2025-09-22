---
title: POST Agents/Dash/GetDashCollection
uid: v1DashAgent_GetDashCollection
generated: true
content_type: reference
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 463,
      "UniqueId": "vitae",
      "Name": "Lubowitz, Ernser and Quitzon",
      "Description": "Vision-oriented contextually-based forecast",
      "AssociateId": 845,
      "Columns": 886,
      "Theme": null,
      "VisibleForAll": 888,
      "VisibleForAssociates": [
        415,
        858
      ],
      "VisibleForGroups": [
        297,
        371
      ],
      "PinForAll": 14,
      "PinForAssociates": [
        216,
        775
      ],
      "PinForGroups": [
        239,
        114
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 442
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 770,
      "UniqueId": "ducimus",
      "Name": "Price, Swift and Davis",
      "Description": "Decentralized high-level paradigm",
      "AssociateId": 223,
      "Columns": 994,
      "Theme": null,
      "VisibleForAll": 579,
      "VisibleForAssociates": [
        337,
        960
      ],
      "VisibleForGroups": [
        107,
        977
      ],
      "PinForAll": 582,
      "PinForAssociates": [
        614,
        472
      ],
      "PinForGroups": [
        20,
        581
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 310
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 325,
      "UniqueId": "occaecati",
      "Name": "Gleason-Wiza",
      "Description": "Up-sized foreground project",
      "AssociateId": 800,
      "Columns": 182,
      "Theme": null,
      "VisibleForAll": 719,
      "VisibleForAssociates": [
        519,
        928
      ],
      "VisibleForGroups": [
        895,
        30
      ],
      "PinForAll": 610,
      "PinForAssociates": [
        513,
        932
      ],
      "PinForGroups": [
        605,
        184
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 949
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 282
    }
  }
}
```