---
title: POST Agents/Dash/CreateDefaultDashCollection
uid: v1DashAgent_CreateDefaultDashCollection
---

# POST Agents/Dash/CreateDefaultDashCollection

```http
POST /api/v1/Agents/Dash/CreateDefaultDashCollection
```

Set default values into a new DashCollection.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Pinned | array | Dashboards pinned to the associate |
| Favourites | array | The assocates favourite dashboards |
| Other | array | Other dashboards |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Dash/CreateDefaultDashCollection
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
      "DashboardId": 162,
      "UniqueId": "perspiciatis",
      "Name": "Hilll-Kirlin",
      "Description": "Self-enabling real-time framework",
      "AssociateId": 955,
      "Columns": 240,
      "Theme": null,
      "VisibleForAll": 989,
      "VisibleForAssociates": [
        513,
        70
      ],
      "VisibleForGroups": [
        225,
        379
      ],
      "PinForAll": 921,
      "PinForAssociates": [
        381,
        504
      ],
      "PinForGroups": [
        27,
        72
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 952,
      "UniqueId": "ea",
      "Name": "Schumm-Padberg",
      "Description": "Synergistic bottom-line leverage",
      "AssociateId": 603,
      "Columns": 133,
      "Theme": null,
      "VisibleForAll": 292,
      "VisibleForAssociates": [
        625,
        894
      ],
      "VisibleForGroups": [
        808,
        154
      ],
      "PinForAll": 532,
      "PinForAssociates": [
        107,
        661
      ],
      "PinForGroups": [
        600,
        267
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 761
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 549,
      "UniqueId": "pariatur",
      "Name": "Jerde, Jast and Armstrong",
      "Description": "Fully-configurable dynamic secured line",
      "AssociateId": 682,
      "Columns": 495,
      "Theme": null,
      "VisibleForAll": 784,
      "VisibleForAssociates": [
        357,
        248
      ],
      "VisibleForGroups": [
        472,
        57
      ],
      "PinForAll": 215,
      "PinForAssociates": [
        511,
        369
      ],
      "PinForGroups": [
        751,
        475
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 33
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 236
    }
  }
}
```