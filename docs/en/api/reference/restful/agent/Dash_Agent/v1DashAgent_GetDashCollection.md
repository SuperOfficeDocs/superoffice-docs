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
      "DashboardId": 884,
      "UniqueId": "quia",
      "Name": "Hoeger Group",
      "Description": "Operative national emulation",
      "AssociateId": 250,
      "Columns": 411,
      "Theme": null,
      "VisibleForAll": 233,
      "VisibleForAssociates": [
        924,
        894
      ],
      "VisibleForGroups": [
        349,
        204
      ],
      "PinForAll": 831,
      "PinForAssociates": [
        456,
        69
      ],
      "PinForGroups": [
        951,
        421
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 200
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 778,
      "UniqueId": "rem",
      "Name": "Dickinson-McCullough",
      "Description": "User-friendly 24 hour task-force",
      "AssociateId": 913,
      "Columns": 826,
      "Theme": null,
      "VisibleForAll": 809,
      "VisibleForAssociates": [
        442,
        891
      ],
      "VisibleForGroups": [
        350,
        63
      ],
      "PinForAll": 506,
      "PinForAssociates": [
        92,
        233
      ],
      "PinForGroups": [
        121,
        798
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 388
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 73,
      "UniqueId": "ut",
      "Name": "Kris, Wolf and Parisian",
      "Description": "Object-based secondary implementation",
      "AssociateId": 176,
      "Columns": 939,
      "Theme": null,
      "VisibleForAll": 988,
      "VisibleForAssociates": [
        397,
        760
      ],
      "VisibleForGroups": [
        544,
        605
      ],
      "PinForAll": 345,
      "PinForAssociates": [
        358,
        627
      ],
      "PinForGroups": [
        609,
        873
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 265
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 332
    }
  }
}
```