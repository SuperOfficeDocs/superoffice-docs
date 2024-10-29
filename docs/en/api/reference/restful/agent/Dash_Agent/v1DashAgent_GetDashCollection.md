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
      "DashboardId": 656,
      "UniqueId": "odit",
      "Name": "Wiegand-Altenwerth",
      "Description": "Grass-roots value-added functionalities",
      "AssociateId": 459,
      "Columns": 701,
      "Theme": null,
      "VisibleForAll": 375,
      "VisibleForAssociates": [
        377,
        730
      ],
      "VisibleForGroups": [
        590,
        955
      ],
      "PinForAll": 944,
      "PinForAssociates": [
        658,
        450
      ],
      "PinForGroups": [
        641,
        619
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 599
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 354,
      "UniqueId": "illum",
      "Name": "Hahn-Koch",
      "Description": "Seamless eco-centric throughput",
      "AssociateId": 968,
      "Columns": 981,
      "Theme": null,
      "VisibleForAll": 99,
      "VisibleForAssociates": [
        790,
        55
      ],
      "VisibleForGroups": [
        907,
        455
      ],
      "PinForAll": 212,
      "PinForAssociates": [
        919,
        434
      ],
      "PinForGroups": [
        508,
        533
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 934
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 853,
      "UniqueId": "cupiditate",
      "Name": "Kutch Group",
      "Description": "Up-sized mission-critical knowledge base",
      "AssociateId": 465,
      "Columns": 216,
      "Theme": null,
      "VisibleForAll": 388,
      "VisibleForAssociates": [
        608,
        155
      ],
      "VisibleForGroups": [
        799,
        79
      ],
      "PinForAll": 518,
      "PinForAssociates": [
        136,
        406
      ],
      "PinForGroups": [
        159,
        713
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 221
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 792
    }
  }
}
```