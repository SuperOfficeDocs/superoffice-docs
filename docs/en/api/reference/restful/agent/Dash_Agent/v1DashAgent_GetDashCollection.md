---
title: POST Agents/Dash/GetDashCollection
uid: v1DashAgent_GetDashCollection
generated: true
content_type: reference
---

# POST Agents/Dash/GetDashCollection

```http
POST /api/v1/Agents/Dash/GetDashCollection
```

Gets a collection of dashboards for the current associate


NsApiSlow threshold: 5000 ms.






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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 825,
      "UniqueId": "asperiores",
      "Name": "Pacocha, Padberg and Wunsch",
      "Description": "Grass-roots leading edge middleware",
      "AssociateId": 853,
      "Columns": 621,
      "Theme": null,
      "VisibleForAll": 730,
      "VisibleForAssociates": [
        840,
        497
      ],
      "VisibleForGroups": [
        345,
        16
      ],
      "PinForAll": 434,
      "PinForAssociates": [
        976,
        446
      ],
      "PinForGroups": [
        429,
        730
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 555
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 219,
      "UniqueId": "molestiae",
      "Name": "Dickens-Carter",
      "Description": "Face to face disintermediate hub",
      "AssociateId": 544,
      "Columns": 615,
      "Theme": null,
      "VisibleForAll": 563,
      "VisibleForAssociates": [
        137,
        268
      ],
      "VisibleForGroups": [
        930,
        648
      ],
      "PinForAll": 144,
      "PinForAssociates": [
        921,
        900
      ],
      "PinForGroups": [
        732,
        16
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 888
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 906,
      "UniqueId": "officiis",
      "Name": "Denesik Group",
      "Description": "Multi-tiered well-modulated database",
      "AssociateId": 803,
      "Columns": 305,
      "Theme": null,
      "VisibleForAll": 390,
      "VisibleForAssociates": [
        95,
        458
      ],
      "VisibleForGroups": [
        487,
        773
      ],
      "PinForAll": 565,
      "PinForAssociates": [
        803,
        312
      ],
      "PinForGroups": [
        996,
        112
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 492
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 679
    }
  }
}
```