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
      "DashboardId": 735,
      "UniqueId": "suscipit",
      "Name": "Rau, Reilly and Green",
      "Description": "Open-source tertiary time-frame",
      "AssociateId": 836,
      "Columns": 272,
      "Theme": null,
      "VisibleForAll": 971,
      "VisibleForAssociates": [
        156,
        803
      ],
      "VisibleForGroups": [
        606,
        318
      ],
      "PinForAll": 865,
      "PinForAssociates": [
        114,
        573
      ],
      "PinForGroups": [
        399,
        881
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 554
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 95,
      "UniqueId": "enim",
      "Name": "Hilpert, Emard and Barrows",
      "Description": "Seamless modular neural-net",
      "AssociateId": 989,
      "Columns": 752,
      "Theme": null,
      "VisibleForAll": 662,
      "VisibleForAssociates": [
        70,
        59
      ],
      "VisibleForGroups": [
        733,
        636
      ],
      "PinForAll": 1002,
      "PinForAssociates": [
        298,
        309
      ],
      "PinForGroups": [
        697,
        27
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 769
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 772,
      "UniqueId": "voluptatem",
      "Name": "Ullrich-Konopelski",
      "Description": "Extended object-oriented process improvement",
      "AssociateId": 590,
      "Columns": 571,
      "Theme": null,
      "VisibleForAll": 798,
      "VisibleForAssociates": [
        364,
        182
      ],
      "VisibleForGroups": [
        4,
        982
      ],
      "PinForAll": 180,
      "PinForAssociates": [
        719,
        83
      ],
      "PinForGroups": [
        138,
        921
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 801
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 667
    }
  }
}
```