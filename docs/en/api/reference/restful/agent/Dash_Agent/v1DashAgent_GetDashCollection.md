---
title: POST Agents/Dash/GetDashCollection
uid: v1DashAgent_GetDashCollection
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
      "DashboardId": 18,
      "UniqueId": "nesciunt",
      "Name": "Kozey Group",
      "Description": "Virtual upward-trending definition",
      "AssociateId": 619,
      "Columns": 182,
      "Theme": null,
      "VisibleForAll": 586,
      "VisibleForAssociates": [
        720,
        471
      ],
      "VisibleForGroups": [
        377,
        465
      ],
      "PinForAll": 666,
      "PinForAssociates": [
        82,
        471
      ],
      "PinForGroups": [
        539,
        454
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 595
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 496,
      "UniqueId": "sit",
      "Name": "Hilll, Mayer and Wehner",
      "Description": "Networked well-modulated attitude",
      "AssociateId": 843,
      "Columns": 509,
      "Theme": null,
      "VisibleForAll": 19,
      "VisibleForAssociates": [
        136,
        18
      ],
      "VisibleForGroups": [
        878,
        511
      ],
      "PinForAll": 541,
      "PinForAssociates": [
        148,
        755
      ],
      "PinForGroups": [
        994,
        503
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 531
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 887,
      "UniqueId": "repudiandae",
      "Name": "Jaskolski-Skiles",
      "Description": "Secured even-keeled neural-net",
      "AssociateId": 208,
      "Columns": 157,
      "Theme": null,
      "VisibleForAll": 787,
      "VisibleForAssociates": [
        794,
        191
      ],
      "VisibleForGroups": [
        971,
        130
      ],
      "PinForAll": 995,
      "PinForAssociates": [
        839,
        686
      ],
      "PinForGroups": [
        682,
        487
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 48
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 845
    }
  }
}
```