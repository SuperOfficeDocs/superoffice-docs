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
      "DashboardId": 244,
      "UniqueId": "vel",
      "Name": "Bins LLC",
      "Description": "Innovative mission-critical project",
      "AssociateId": 259,
      "Columns": 219,
      "Theme": null,
      "VisibleForAll": 597,
      "VisibleForAssociates": [
        193,
        134
      ],
      "VisibleForGroups": [
        146,
        218
      ],
      "PinForAll": 578,
      "PinForAssociates": [
        754,
        581
      ],
      "PinForGroups": [
        817,
        930
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 343
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 106,
      "UniqueId": "cum",
      "Name": "Swaniawski Group",
      "Description": "Future-proofed bi-directional info-mediaries",
      "AssociateId": 3,
      "Columns": 693,
      "Theme": null,
      "VisibleForAll": 495,
      "VisibleForAssociates": [
        839,
        825
      ],
      "VisibleForGroups": [
        216,
        996
      ],
      "PinForAll": 6,
      "PinForAssociates": [
        337,
        247
      ],
      "PinForGroups": [
        165,
        494
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 707
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 668,
      "UniqueId": "non",
      "Name": "Zieme Group",
      "Description": "Optimized coherent secured line",
      "AssociateId": 391,
      "Columns": 821,
      "Theme": null,
      "VisibleForAll": 159,
      "VisibleForAssociates": [
        270,
        680
      ],
      "VisibleForGroups": [
        188,
        166
      ],
      "PinForAll": 835,
      "PinForAssociates": [
        993,
        37
      ],
      "PinForGroups": [
        120,
        37
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 230
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 323
    }
  }
}
```