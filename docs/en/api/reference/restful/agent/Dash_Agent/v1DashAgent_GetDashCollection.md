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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 800,
      "UniqueId": "dolores",
      "Name": "Herzog-Gorczany",
      "Description": "Polarised maximized function",
      "AssociateId": 344,
      "Columns": 505,
      "Theme": null,
      "VisibleForAll": 818,
      "VisibleForAssociates": [
        373,
        442
      ],
      "VisibleForGroups": [
        197,
        25
      ],
      "PinForAll": 105,
      "PinForAssociates": [
        829,
        53
      ],
      "PinForGroups": [
        971,
        743
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 703
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 589,
      "UniqueId": "omnis",
      "Name": "Shanahan LLC",
      "Description": "Universal empowering middleware",
      "AssociateId": 617,
      "Columns": 648,
      "Theme": null,
      "VisibleForAll": 912,
      "VisibleForAssociates": [
        732,
        975
      ],
      "VisibleForGroups": [
        161,
        349
      ],
      "PinForAll": 643,
      "PinForAssociates": [
        252,
        993
      ],
      "PinForGroups": [
        145,
        955
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 923
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 664,
      "UniqueId": "enim",
      "Name": "Tillman, Dickens and Wuckert",
      "Description": "Reduced even-keeled task-force",
      "AssociateId": 586,
      "Columns": 630,
      "Theme": null,
      "VisibleForAll": 196,
      "VisibleForAssociates": [
        677,
        205
      ],
      "VisibleForGroups": [
        853,
        659
      ],
      "PinForAll": 444,
      "PinForAssociates": [
        959,
        652
      ],
      "PinForGroups": [
        613,
        758
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 315
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 218
    }
  }
}
```