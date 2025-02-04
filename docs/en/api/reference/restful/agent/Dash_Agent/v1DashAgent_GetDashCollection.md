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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 637,
      "UniqueId": "iure",
      "Name": "Schaden, Larkin and Maggio",
      "Description": "Progressive secondary forecast",
      "AssociateId": 249,
      "Columns": 229,
      "Theme": null,
      "VisibleForAll": 509,
      "VisibleForAssociates": [
        367,
        305
      ],
      "VisibleForGroups": [
        181,
        248
      ],
      "PinForAll": 975,
      "PinForAssociates": [
        6,
        370
      ],
      "PinForGroups": [
        479,
        21
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 841
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 452,
      "UniqueId": "laborum",
      "Name": "Deckow, Krajcik and Yundt",
      "Description": "Fundamental attitude-oriented pricing structure",
      "AssociateId": 680,
      "Columns": 403,
      "Theme": null,
      "VisibleForAll": 137,
      "VisibleForAssociates": [
        267,
        160
      ],
      "VisibleForGroups": [
        500,
        80
      ],
      "PinForAll": 177,
      "PinForAssociates": [
        972,
        184
      ],
      "PinForGroups": [
        499,
        170
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 163
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 313,
      "UniqueId": "ducimus",
      "Name": "Balistreri, Donnelly and Windler",
      "Description": "Customizable multi-tasking middleware",
      "AssociateId": 840,
      "Columns": 598,
      "Theme": null,
      "VisibleForAll": 785,
      "VisibleForAssociates": [
        851,
        860
      ],
      "VisibleForGroups": [
        746,
        396
      ],
      "PinForAll": 565,
      "PinForAssociates": [
        333,
        552
      ],
      "PinForGroups": [
        943,
        50
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 357
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 920
    }
  }
}
```