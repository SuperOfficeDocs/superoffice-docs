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
      "DashboardId": 44,
      "UniqueId": "ut",
      "Name": "Bechtelar-Ritchie",
      "Description": "Synergistic methodical success",
      "AssociateId": 600,
      "Columns": 276,
      "Theme": null,
      "VisibleForAll": 638,
      "VisibleForAssociates": [
        545,
        686
      ],
      "VisibleForGroups": [
        286,
        464
      ],
      "PinForAll": 939,
      "PinForAssociates": [
        445,
        228
      ],
      "PinForGroups": [
        709,
        627
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
      "DashboardId": 541,
      "UniqueId": "optio",
      "Name": "Mraz Inc and Sons",
      "Description": "Polarised secondary complexity",
      "AssociateId": 939,
      "Columns": 164,
      "Theme": null,
      "VisibleForAll": 22,
      "VisibleForAssociates": [
        427,
        622
      ],
      "VisibleForGroups": [
        128,
        908
      ],
      "PinForAll": 766,
      "PinForAssociates": [
        17,
        965
      ],
      "PinForGroups": [
        293,
        365
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 565
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 516,
      "UniqueId": "qui",
      "Name": "Hickle-Abbott",
      "Description": "Innovative executive function",
      "AssociateId": 50,
      "Columns": 507,
      "Theme": null,
      "VisibleForAll": 761,
      "VisibleForAssociates": [
        19,
        100
      ],
      "VisibleForGroups": [
        957,
        656
      ],
      "PinForAll": 196,
      "PinForAssociates": [
        159,
        96
      ],
      "PinForGroups": [
        710,
        297
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 553
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 613
    }
  }
}
```