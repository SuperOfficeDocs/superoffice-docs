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
      "DashboardId": 196,
      "UniqueId": "quia",
      "Name": "Raynor Inc and Sons",
      "Description": "Optional 5th generation time-frame",
      "AssociateId": 479,
      "Columns": 301,
      "Theme": null,
      "VisibleForAll": 466,
      "VisibleForAssociates": [
        919,
        172
      ],
      "VisibleForGroups": [
        508,
        158
      ],
      "PinForAll": 218,
      "PinForAssociates": [
        454,
        217
      ],
      "PinForGroups": [
        312,
        159
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 442,
      "UniqueId": "ea",
      "Name": "Steuber Inc and Sons",
      "Description": "Integrated zero tolerance system engine",
      "AssociateId": 733,
      "Columns": 406,
      "Theme": null,
      "VisibleForAll": 384,
      "VisibleForAssociates": [
        685,
        889
      ],
      "VisibleForGroups": [
        585,
        813
      ],
      "PinForAll": 246,
      "PinForAssociates": [
        32,
        763
      ],
      "PinForGroups": [
        822,
        619
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 490
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 140,
      "UniqueId": "non",
      "Name": "Hickle, Christiansen and Dooley",
      "Description": "Managed composite Graphic Interface",
      "AssociateId": 214,
      "Columns": 530,
      "Theme": null,
      "VisibleForAll": 45,
      "VisibleForAssociates": [
        51,
        1002
      ],
      "VisibleForGroups": [
        553,
        206
      ],
      "PinForAll": 850,
      "PinForAssociates": [
        353,
        499
      ],
      "PinForGroups": [
        737,
        658
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 439
    }
  }
}
```