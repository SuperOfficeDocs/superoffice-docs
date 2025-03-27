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
      "DashboardId": 951,
      "UniqueId": "mollitia",
      "Name": "Mann Inc and Sons",
      "Description": "Multi-tiered heuristic pricing structure",
      "AssociateId": 450,
      "Columns": 476,
      "Theme": null,
      "VisibleForAll": 976,
      "VisibleForAssociates": [
        876,
        919
      ],
      "VisibleForGroups": [
        5,
        832
      ],
      "PinForAll": 137,
      "PinForAssociates": [
        445,
        886
      ],
      "PinForGroups": [
        91,
        552
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 910
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 94,
      "UniqueId": "quia",
      "Name": "Gaylord Group",
      "Description": "Centralized local Graphical User Interface",
      "AssociateId": 189,
      "Columns": 698,
      "Theme": null,
      "VisibleForAll": 17,
      "VisibleForAssociates": [
        232,
        260
      ],
      "VisibleForGroups": [
        783,
        295
      ],
      "PinForAll": 462,
      "PinForAssociates": [
        888,
        783
      ],
      "PinForGroups": [
        434,
        262
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 16
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 633,
      "UniqueId": "et",
      "Name": "Champlin, Schowalter and Cormier",
      "Description": "Integrated interactive complexity",
      "AssociateId": 185,
      "Columns": 809,
      "Theme": null,
      "VisibleForAll": 368,
      "VisibleForAssociates": [
        649,
        755
      ],
      "VisibleForGroups": [
        324,
        430
      ],
      "PinForAll": 44,
      "PinForAssociates": [
        907,
        817
      ],
      "PinForGroups": [
        727,
        973
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 290
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 413
    }
  }
}
```