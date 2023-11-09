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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 94,
      "UniqueId": "vel",
      "Name": "Howell Inc and Sons",
      "Description": "Focused 6th generation open architecture",
      "AssociateId": 654,
      "Columns": 308,
      "Theme": null,
      "VisibleForAll": 689,
      "VisibleForAssociates": [
        308,
        528
      ],
      "VisibleForGroups": [
        488,
        321
      ],
      "PinForAll": 900,
      "PinForAssociates": [
        726,
        563
      ],
      "PinForGroups": [
        407,
        719
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 278
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 23,
      "UniqueId": "tenetur",
      "Name": "Schaefer Inc and Sons",
      "Description": "Reduced 24/7 access",
      "AssociateId": 297,
      "Columns": 919,
      "Theme": null,
      "VisibleForAll": 533,
      "VisibleForAssociates": [
        898,
        150
      ],
      "VisibleForGroups": [
        44,
        74
      ],
      "PinForAll": 569,
      "PinForAssociates": [
        992,
        122
      ],
      "PinForGroups": [
        699,
        403
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 883
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 909,
      "UniqueId": "eum",
      "Name": "Beier-Waelchi",
      "Description": "Optional secondary orchestration",
      "AssociateId": 744,
      "Columns": 242,
      "Theme": null,
      "VisibleForAll": 949,
      "VisibleForAssociates": [
        874,
        798
      ],
      "VisibleForGroups": [
        979,
        200
      ],
      "PinForAll": 682,
      "PinForAssociates": [
        449,
        246
      ],
      "PinForGroups": [
        895,
        842
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 648
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 179
    }
  }
}
```