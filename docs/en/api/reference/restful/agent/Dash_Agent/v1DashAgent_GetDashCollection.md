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
      "DashboardId": 589,
      "UniqueId": "dolorum",
      "Name": "Wilderman Inc and Sons",
      "Description": "Exclusive tangible portal",
      "AssociateId": 509,
      "Columns": 716,
      "Theme": null,
      "VisibleForAll": 248,
      "VisibleForAssociates": [
        794,
        322
      ],
      "VisibleForGroups": [
        416,
        372
      ],
      "PinForAll": 209,
      "PinForAssociates": [
        28,
        914
      ],
      "PinForGroups": [
        998,
        243
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 69
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 222,
      "UniqueId": "velit",
      "Name": "Langworth-Cummerata",
      "Description": "Proactive static policy",
      "AssociateId": 681,
      "Columns": 283,
      "Theme": null,
      "VisibleForAll": 40,
      "VisibleForAssociates": [
        477,
        644
      ],
      "VisibleForGroups": [
        519,
        498
      ],
      "PinForAll": 670,
      "PinForAssociates": [
        563,
        856
      ],
      "PinForGroups": [
        639,
        208
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 354,
      "UniqueId": "assumenda",
      "Name": "Schroeder-Rau",
      "Description": "Centralized full-range task-force",
      "AssociateId": 99,
      "Columns": 330,
      "Theme": null,
      "VisibleForAll": 814,
      "VisibleForAssociates": [
        462,
        183
      ],
      "VisibleForGroups": [
        835,
        856
      ],
      "PinForAll": 424,
      "PinForAssociates": [
        465,
        198
      ],
      "PinForGroups": [
        662,
        100
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 907
    }
  }
}
```