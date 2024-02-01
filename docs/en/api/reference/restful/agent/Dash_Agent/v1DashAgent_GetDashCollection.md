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
      "DashboardId": 332,
      "UniqueId": "et",
      "Name": "Stanton Group",
      "Description": "Open-architected cohesive circuit",
      "AssociateId": 101,
      "Columns": 491,
      "Theme": null,
      "VisibleForAll": 981,
      "VisibleForAssociates": [
        619,
        582
      ],
      "VisibleForGroups": [
        227,
        575
      ],
      "PinForAll": 987,
      "PinForAssociates": [
        777,
        89
      ],
      "PinForGroups": [
        790,
        419
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 882
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 778,
      "UniqueId": "praesentium",
      "Name": "Botsford Inc and Sons",
      "Description": "Secured value-added benchmark",
      "AssociateId": 776,
      "Columns": 927,
      "Theme": null,
      "VisibleForAll": 367,
      "VisibleForAssociates": [
        337,
        312
      ],
      "VisibleForGroups": [
        624,
        677
      ],
      "PinForAll": 648,
      "PinForAssociates": [
        773,
        266
      ],
      "PinForGroups": [
        214,
        606
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 584
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 784,
      "UniqueId": "corrupti",
      "Name": "Bergnaum-Parker",
      "Description": "Distributed optimal emulation",
      "AssociateId": 208,
      "Columns": 694,
      "Theme": null,
      "VisibleForAll": 462,
      "VisibleForAssociates": [
        678,
        115
      ],
      "VisibleForGroups": [
        784,
        806
      ],
      "PinForAll": 267,
      "PinForAssociates": [
        125,
        569
      ],
      "PinForGroups": [
        921,
        153
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 953
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 897
    }
  }
}
```