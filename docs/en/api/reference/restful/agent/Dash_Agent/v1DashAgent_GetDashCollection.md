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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 638,
      "UniqueId": "rerum",
      "Name": "Rosenbaum LLC",
      "Description": "Reverse-engineered responsive functionalities",
      "AssociateId": 934,
      "Columns": 284,
      "Theme": null,
      "VisibleForAll": 24,
      "VisibleForAssociates": [
        108,
        680
      ],
      "VisibleForGroups": [
        266,
        137
      ],
      "PinForAll": 234,
      "PinForAssociates": [
        894,
        502
      ],
      "PinForGroups": [
        79,
        87
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 219,
      "UniqueId": "vero",
      "Name": "Wunsch-McLaughlin",
      "Description": "Extended real-time info-mediaries",
      "AssociateId": 768,
      "Columns": 192,
      "Theme": null,
      "VisibleForAll": 14,
      "VisibleForAssociates": [
        68,
        108
      ],
      "VisibleForGroups": [
        942,
        244
      ],
      "PinForAll": 312,
      "PinForAssociates": [
        57,
        634
      ],
      "PinForGroups": [
        770,
        557
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 345
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 273,
      "UniqueId": "est",
      "Name": "Yost-Paucek",
      "Description": "Face to face zero defect Graphical User Interface",
      "AssociateId": 849,
      "Columns": 929,
      "Theme": null,
      "VisibleForAll": 260,
      "VisibleForAssociates": [
        715,
        650
      ],
      "VisibleForGroups": [
        237,
        147
      ],
      "PinForAll": 290,
      "PinForAssociates": [
        105,
        199
      ],
      "PinForGroups": [
        596,
        317
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 533
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 544
    }
  }
}
```