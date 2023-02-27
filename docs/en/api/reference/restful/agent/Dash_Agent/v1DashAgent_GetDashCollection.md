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
| TableRight | TableRight |  |
| FieldProperties | object |  |

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
      "DashboardId": 778,
      "UniqueId": "veniam",
      "Name": "Koss Group",
      "Description": "Total uniform policy",
      "AssociateId": 462,
      "Columns": 722,
      "Theme": null,
      "VisibleForAll": 662,
      "VisibleForAssociates": [
        308,
        438
      ],
      "VisibleForGroups": [
        32,
        325
      ],
      "PinForAll": 471,
      "PinForAssociates": [
        842,
        625
      ],
      "PinForGroups": [
        104,
        21
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 175
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 973,
      "UniqueId": "qui",
      "Name": "Leffler, Swaniawski and Schulist",
      "Description": "Centralized full-range budgetary management",
      "AssociateId": 322,
      "Columns": 917,
      "Theme": null,
      "VisibleForAll": 158,
      "VisibleForAssociates": [
        703,
        904
      ],
      "VisibleForGroups": [
        346,
        838
      ],
      "PinForAll": 844,
      "PinForAssociates": [
        930,
        332
      ],
      "PinForGroups": [
        339,
        693
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 366,
      "UniqueId": "quis",
      "Name": "Dietrich Group",
      "Description": "Self-enabling homogeneous definition",
      "AssociateId": 180,
      "Columns": 982,
      "Theme": null,
      "VisibleForAll": 783,
      "VisibleForAssociates": [
        822,
        364
      ],
      "VisibleForGroups": [
        922,
        245
      ],
      "PinForAll": 512,
      "PinForAssociates": [
        844,
        827
      ],
      "PinForGroups": [
        357,
        245
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 212
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 925
    }
  }
}
```