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
      "DashboardId": 692,
      "UniqueId": "omnis",
      "Name": "Goodwin-Beer",
      "Description": "Switchable web-enabled benchmark",
      "AssociateId": 446,
      "Columns": 968,
      "Theme": null,
      "VisibleForAll": 819,
      "VisibleForAssociates": [
        44,
        498
      ],
      "VisibleForGroups": [
        572,
        925
      ],
      "PinForAll": 783,
      "PinForAssociates": [
        247,
        514
      ],
      "PinForGroups": [
        239,
        725
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 409
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 78,
      "UniqueId": "et",
      "Name": "Kuhlman-Reichel",
      "Description": "Ameliorated global framework",
      "AssociateId": 735,
      "Columns": 882,
      "Theme": null,
      "VisibleForAll": 893,
      "VisibleForAssociates": [
        69,
        255
      ],
      "VisibleForGroups": [
        591,
        157
      ],
      "PinForAll": 297,
      "PinForAssociates": [
        202,
        681
      ],
      "PinForGroups": [
        735,
        337
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 272
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 282,
      "UniqueId": "reiciendis",
      "Name": "Fritsch Inc and Sons",
      "Description": "Expanded client-server function",
      "AssociateId": 766,
      "Columns": 682,
      "Theme": null,
      "VisibleForAll": 897,
      "VisibleForAssociates": [
        707,
        46
      ],
      "VisibleForGroups": [
        770,
        236
      ],
      "PinForAll": 941,
      "PinForAssociates": [
        60,
        170
      ],
      "PinForGroups": [
        989,
        980
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 165
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 975
    }
  }
}
```