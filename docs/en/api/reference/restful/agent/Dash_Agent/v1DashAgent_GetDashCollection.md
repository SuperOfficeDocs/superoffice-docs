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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 175,
      "UniqueId": "provident",
      "Name": "Jakubowski, Towne and Turner",
      "Description": "Switchable scalable workforce",
      "AssociateId": 145,
      "Columns": 907,
      "Theme": null,
      "VisibleForAll": 328,
      "VisibleForAssociates": [
        122,
        373
      ],
      "VisibleForGroups": [
        463,
        244
      ],
      "PinForAll": 115,
      "PinForAssociates": [
        188,
        825
      ],
      "PinForGroups": [
        930,
        923
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 547
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 308,
      "UniqueId": "provident",
      "Name": "Schulist, Bartoletti and Stiedemann",
      "Description": "Decentralized discrete interface",
      "AssociateId": 593,
      "Columns": 237,
      "Theme": null,
      "VisibleForAll": 585,
      "VisibleForAssociates": [
        372,
        49
      ],
      "VisibleForGroups": [
        159,
        809
      ],
      "PinForAll": 827,
      "PinForAssociates": [
        741,
        450
      ],
      "PinForGroups": [
        338,
        570
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 283
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 716,
      "UniqueId": "repellendus",
      "Name": "Hyatt-Carroll",
      "Description": "Object-based leading edge installation",
      "AssociateId": 608,
      "Columns": 113,
      "Theme": null,
      "VisibleForAll": 312,
      "VisibleForAssociates": [
        572,
        520
      ],
      "VisibleForGroups": [
        280,
        535
      ],
      "PinForAll": 624,
      "PinForAssociates": [
        972,
        839
      ],
      "PinForGroups": [
        439,
        945
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 530
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 421
    }
  }
}
```